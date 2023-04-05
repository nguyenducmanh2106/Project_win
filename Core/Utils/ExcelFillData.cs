using OfficeOpenXml;
using OfficeOpenXml.DataValidation;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IIG.Core.Framework.ICom.Infrastructure.Utils
{
    public class ExcelFillData
    {
        public static void FillReport(string filename, string templatefilename, DataSet data)
        {
            FillReport(filename, templatefilename, data, new string[] { "%", "%" });
        }

        public static void FillReport(string filename, string templatefilename, DataSet data, string[] deliminator)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                var pathFile = Path.Combine(Environment.CurrentDirectory, @"OutputExcel\" + filename);
                if (File.Exists(pathFile))
                    File.Delete(pathFile);

                using (var file = new FileStream(Path.Combine(Environment.CurrentDirectory, @"OutputExcel\" + filename), FileMode.CreateNew))
                {
                    using (var temp = new FileStream(Path.Combine(Environment.CurrentDirectory, @"TemplateExcel\" + templatefilename), FileMode.Open))
                    {
                        using (var xls = new ExcelPackage(file, temp))
                        {


                            foreach (var n in xls.Workbook.Names)
                            {


                                FillWorksheetData(data, n.Worksheet, n, deliminator);
                            }

                            foreach (var ws in xls.Workbook.Worksheets)
                            {
                                foreach (var n in ws.Names)
                                {
                                    FillWorksheetData(data, ws, n, deliminator);
                                }
                            }

                            foreach (var ws in xls.Workbook.Worksheets)
                            {
                                foreach (var c in ws.Cells)
                                {
                                    var s = "" + c.Value;
                                    if (s.StartsWith(deliminator[0]) == false &&
                                        s.EndsWith(deliminator[1]) == false)
                                        continue;
                                    s = s.Replace(deliminator[0], "").Replace(deliminator[1], "");
                                    var ss = s.Split('.');
                                    try
                                    {
                                        c.Value = data.Tables[ss[0]]?.Rows[0][ss[1]];
                                    }
                                    catch (Exception ex) { throw ex; }
                                }
                            }

                            ////Thêm phần render lại Address
                            //var exist = data.Tables.Contains("Products");
                            //if (exist)
                            //{
                            //    var rowCount = data.Tables["Products"].Rows.Count;
                            //    string rangeName = "SanPham";
                            //    var range = xls.Workbook.Names[rangeName];
                            //    range.Address = $"'San pham'!$B$3:$B${rowCount + 3}";
                            //    xls.Workbook.Names.Remove(rangeName);
                            //    xls.Workbook.Names.Add(rangeName, range);
                            //}

                            xls.Save();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void FillWorksheetData(DataSet data, ExcelWorksheet ws, ExcelNamedRange n, string[] deliminator)
        {
            try
            {
                if (data.Tables.Contains(n.Name) == false)
                    return;

                var dt = data.Tables[n.Name];

                int row = n.Start.Row;

                var cn = new string[n.Columns];
                var st = new int[n.Columns];
                for (int i = 0; i < n.Columns; i++)
                {
                    var data1 = n;
                    cn[i] = (data1.Value as object[,])[0, i]?.ToString()?.Replace(deliminator[0], "").Replace(deliminator[1], "");
                    if (cn[i] != null && cn[i].Contains("."))
                        cn[i] = cn[i].Split('.')[1];
                    st[i] = ws.Cells[row, n.Start.Column + i].StyleID;
                }

                foreach (DataRow r in dt.Rows)
                {
                    List<CellAddressModel> listCellAddress = new List<CellAddressModel>();

                    for (int col = 0; col < n.Columns; col++)
                    {
                        if (cn[col] != null && dt.Columns.Contains(cn[col]))
                        {
                            //format kiểu dữ liệu kiểu Date khi ghi vào file excel
                            switch (r[cn[col]].GetType().Name)
                            {
                                case nameof(DateTime):
                                    ws.Cells[row, n.Start.Column + col].Value = r[cn[col]] != null ? Convert.ToDateTime(r[cn[col]]).ToString("dd/MM/yyyy") : "";
                                    break;
                                //case nameof(Int32):
                                //case nameof(Int64):
                                //case nameof(Decimal):
                                //case nameof(Double):
                                //    ws.Cells[row, n.Start.Column + col].Value = r[cn[col]] != null ? @String.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:#,##0}", r[cn[col]]) : "";
                                //    break;
                                default:
                                    ws.Cells[row, n.Start.Column + col].Value = r[cn[col]];
                                    break;
                            }

                        }

                        ws.Cells[row, n.Start.Column + col].StyleID = st[col];
                        var mergeAddress = ws.Cells[row, n.Start.Column + col].Merge;
                        if (mergeAddress)
                        {
                            //var a = ws.Cells[row, n.Start.Column + col].Address;

                            //Lấy về dải địa chỉ merge cell 
                            var b3address = GetMergedRangeAddress(ws.Cells[row, n.Start.Column + col]);
                            var starColumn = ws.Cells[b3address].EntireColumn.StartColumn;
                            var endColumn = ws.Cells[b3address].EntireColumn.EndColumn;
                            var startRow = ws.Cells[b3address].EntireRow.StartRow;
                            var endRow = ws.Cells[b3address].EntireRow.EndRow;

                            var cellAddress = new CellAddressModel()
                            {
                                StartRow = startRow,
                                EndColumn = endColumn,
                                EndRow = startRow,
                                StartColumn = starColumn
                            };
                            listCellAddress.Add(cellAddress);
                        }

                    }

                    row++;

                    //thêm đoạn này để lúc render data vào bảng dữ liệu không bị chiếm mất dòng chữ ký dưới cùng
                    ws.InsertRow(row, 1, row);
                    ws.Rows[row].Height = ws.Rows[row - 1].Height;

                    //Tiến hành merge các ô theo range address mới khi insert thêm dòng
                    foreach (var cellAddress in listCellAddress)
                    {
                        ws.Cells[row, cellAddress.StartColumn, row, cellAddress.EndColumn].Merge = true;
                    }
                    //ws.Cells[row, n.Start.Column, row, n.Start.Column + 3].Merge = true;

                }

                //xóa dòng thừa từ đoạn InsertRow bên trên, đồng thời xóa cả dòng thừa xét biến trong file excel khi không có dữ liệu được render ra
                ws.DeleteRow(row, 1);

                // extend table formatting range to all rows
                foreach (var t in ws.Tables)
                {
                    var a = t.Address;
                    if (n.Start.Row.Between(a.Start.Row, a.End.Row) &&
                        n.Start.Column.Between(a.Start.Column, a.End.Column))
                    {
                        ExtendRows(t, dt.Rows.Count - 1);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy về dải địa chỉ merge cell
        /// </summary>
        /// <param name="excelRange"></param>
        /// <returns></returns>
        public static string GetMergedRangeAddress(ExcelRange excelRange)
        {
            if (excelRange.Merge)
            {
                var idx = excelRange.Worksheet.GetMergeCellId(excelRange.Start.Row, excelRange.Start.Column);
                return excelRange.Worksheet.MergedCells[idx - 1]; //the array is 0-indexed but the mergeId is 1-indexed...
            }
            else
            {
                return excelRange.Address;
            }
        }
        public static void ExtendRows(ExcelTable excelTable, int count)
        {

            var ad = new ExcelAddress(excelTable.Address.Start.Row,
                                      excelTable.Address.Start.Column,
                                      excelTable.Address.End.Row + count,
                                      excelTable.Address.End.Column);
            //Address = ad;
        }

        public static void FillReportGrid(string pathFileOutput, string templatefilename, DataSet data, string[] deliminator, int type = 0)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                //var pathFile = Path.Combine(Environment.CurrentDirectory, @"OutputExcel\" + filename);
                //if (File.Exists(pathFile))
                //    File.Delete(pathFile);

                using (var file = new FileStream(Path.Combine(pathFileOutput), FileMode.CreateNew))
                {
                    using (var temp = new FileStream(Path.Combine(Environment.CurrentDirectory, @"TemplateExcel\" + templatefilename), FileMode.Open))
                    {
                        using (var xls = new ExcelPackage(file, temp))
                        {


                            foreach (var n in xls.Workbook.Names)
                            {


                                FillWorksheetDataGrid(data, n.Worksheet, n, deliminator, type);
                            }

                            foreach (var ws in xls.Workbook.Worksheets)
                            {
                                foreach (var n in ws.Names)
                                {
                                    FillWorksheetDataGrid(data, ws, n, deliminator, type);
                                }
                            }

                            foreach (var ws in xls.Workbook.Worksheets)
                            {
                                foreach (var c in ws.Cells)
                                {
                                    var s = "" + c.Value;
                                    if (s.StartsWith(deliminator[0]) == false &&
                                        s.EndsWith(deliminator[1]) == false)
                                        continue;
                                    s = s.Replace(deliminator[0], "").Replace(deliminator[1], "");
                                    var ss = s.Split('.');
                                    try
                                    {
                                        c.Value = data.Tables[ss[0]]?.Rows[0][ss[1]];
                                    }
                                    catch (Exception ex) { throw ex; }
                                }
                            }

                            xls.Save();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void FillWorksheetDataGrid(DataSet data, ExcelWorksheet ws, ExcelNamedRange n, string[] deliminator, int type = 0)
        {
            try
            {
                if (data.Tables.Contains(n.Name) == false)
                    return;

                var dt = data.Tables[n.Name];

                int row = n.Start.Row;

                var cn = new string[n.Columns];
                var st = new int[n.Columns];
                for (int i = 0; i < n.Columns; i++)
                {
                    var data1 = n;
                    cn[i] = (data1.Value as object[,])[0, i]?.ToString()?.Replace(deliminator[0], "").Replace(deliminator[1], "");
                    if (cn[i] != null && cn[i].Contains("."))
                        cn[i] = cn[i].Split('.')[1];
                    st[i] = ws.Cells[row, n.Start.Column + i].StyleID;
                }

                List<CellAddressModel> listCellAddress = new List<CellAddressModel>();
                Guid departmentIdFirst = default(Guid);
                Guid productTypeIdFist = default(Guid);
                Guid employeeIdFist = default(Guid);
                int startRow = row;
                int endRow = row;

                foreach (DataRow r in dt.Rows)
                {

                    for (int col = 0; col < n.Columns; col++)
                    {
                        if (cn[col] != null && dt.Columns.Contains(cn[col]))
                        {
                            //format kiểu dữ liệu kiểu Date khi ghi vào file excel
                            switch (r[cn[col]].GetType().Name)
                            {
                                case nameof(DateTime):
                                    ws.Cells[row, n.Start.Column + col].Value = r[cn[col]] != null ? Convert.ToDateTime(r[cn[col]]).ToString("dd/MM/yyyy") : "";
                                    break;
                                default:
                                    ws.Cells[row, n.Start.Column + col].Value = r[cn[col]];
                                    break;
                            }
                        }

                       
                        ws.Cells[row, n.Start.Column + col].StyleID = st[col];
                    }

                    row++;

                    //thêm đoạn này để lúc render data vào bảng dữ liệu không bị chiếm mất dòng chữ ký dưới cùng
                    ws.InsertRow(row, 1, row);
                }

                //Tiến hành merge các ô theo range address mới khi insert thêm dòng
                foreach (var cellAddress in listCellAddress)
                {
                    ws.Cells[cellAddress.StartRow, cellAddress.StartColumn, cellAddress.EndRow, cellAddress.EndColumn].Merge = true;
                }

                //xóa dòng thừa từ đoạn InsertRow bên trên, đồng thời xóa cả dòng thừa xét biến trong file excel khi không có dữ liệu được render ra
                ws.DeleteRow(row, 1);

                // extend table formatting range to all rows
                foreach (var t in ws.Tables)
                {
                    var a = t.Address;
                    if (n.Start.Row.Between(a.Start.Row, a.End.Row) &&
                        n.Start.Column.Between(a.Start.Column, a.End.Column))
                    {
                        ExtendRows(t, dt.Rows.Count - 1);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void FillReportCustomDynamicTitle(string filename, string templatefilename, DataSet data, string[] deliminator, string[] columnTitleStrings = null, string[] listColumnParams = null)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            var pathFile = Path.Combine(Environment.CurrentDirectory, @"OutputExcel\" + filename);
            if (File.Exists(pathFile))
                File.Delete(pathFile);

            using (var file = new FileStream(Path.Combine(Environment.CurrentDirectory, @"OutputExcel\" + filename), FileMode.CreateNew))
            {
                using (var temp = new FileStream(Path.Combine(Environment.CurrentDirectory, @"TemplateExcel\" + templatefilename), FileMode.Open))
                {
                    using (var xls = new ExcelPackage(file, temp))
                    {
                        //xử lý tạo cột động và bind biến để map dữ liệu
                        if (columnTitleStrings != null && columnTitleStrings.Length > 0)
                        {
                            foreach (var ws in xls.Workbook.Worksheets)
                            {
                                foreach (var c in ws.Cells)
                                {
                                    //check vị trí bắt đầu render cột động
                                    if (c?.Value?.ToString() == "%DynamicColumn%")
                                    {
                                        var s = "" + c.Value;
                                        string[] titleColumns;
                                        string[] paramColumns = listColumnParams != null && listColumnParams.Length > 0 ? listColumnParams : null;
                                        int indxColumn = c.Start.Column;
                                        if (columnTitleStrings != null && columnTitleStrings.Length > 0)
                                        {
                                            titleColumns = columnTitleStrings;
                                            if (titleColumns.Length > 1)
                                            {
                                                //insert cột động
                                                ws.InsertColumn(indxColumn, titleColumns.Length - 1, indxColumn);
                                            }


                                            for (int i = 0; i < titleColumns.Length; i++)
                                            {
                                                //render tiêu để cột và đặt param theo mẫu dùng để map dữ liệu
                                                ws.Cells[c.Start.Row, c.Start.Column + i].Value = titleColumns[i];
                                                ws.Cells[c.Start.Row + 1, c.Start.Column + i].Value = "{" + $"{paramColumns[i]}" + "}";
                                            }
                                        }


                                    }
                                }
                            }

                        }


                        foreach (var n in xls.Workbook.Names)
                        {
                            FillWorksheetData(data, n.Worksheet, n, deliminator);

                        }

                        foreach (var ws in xls.Workbook.Worksheets)
                        {
                            foreach (var n in ws.Names)
                            {
                                FillWorksheetData(data, ws, n, deliminator);

                            }
                        }
                        foreach (var ws in xls.Workbook.Worksheets)
                        {
                            foreach (var c in ws.Cells)
                            {
                                var s = "" + c.Value;
                                if (s.StartsWith(deliminator[0]) == false &&
                                    s.EndsWith(deliminator[1]) == false)
                                    continue;
                                s = s.Replace(deliminator[0], "").Replace(deliminator[1], "");
                                var ss = s.Split('.');
                                try
                                {
                                    c.Value = data.Tables[ss[0]]?.Rows[0][ss[1]];
                                    //c.Value = data.Tables["Master"].Rows[0][ss[0]];
                                }
                                catch { }
                            }
                        }


                        xls.Save();
                    }
                }
            }
        }

    }

    public static class int_between
    {
        public static bool Between(this int v, int a, int b)
        {
            return v >= a && v <= b;
        }
    }

    public class CellAddressModel
    {
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
        public int StartRow { get; set; }
        public int EndRow { get; set; }
    }


}
