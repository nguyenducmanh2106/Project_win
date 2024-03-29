﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class CustomConvert
    {
        public static DataTable ToDataTable<T>(List<T> items)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                if (items == null) return dataTable;
                //Get all the properties
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name, propType);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                //put a breakpoint here and check datatable
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Convert image into byte array
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if(imageIn == null) return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Convert byte array into image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Position = 0; // this is important
            return Image.FromStream(ms, true);
        }

        public static Bitmap Convert2Bitmap(byte[] DATA, int width, int height)
        {
            //Bitmap Bm = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            //var b = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            //ColorPalette ncp = b.Palette;
            //for (int i = 0; i < 256; i++)
            //    ncp.Entries[i] = Color.FromArgb(255, i, i, i);
            //b.Palette = ncp;
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        int Value = DATA[x + (y * width)];
            //        Color C = ncp.Entries[Value];
            //        Bm.SetPixel(x, y, C);
            //    }
            //}
            //return Bm;

            var b = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            ColorPalette ncp = b.Palette;
            for (int i = 0; i < 256; i++)
                ncp.Entries[i] = Color.FromArgb(255, i, i, i);
            b.Palette = ncp;

            var BoundsRect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = b.LockBits(BoundsRect,
                                            ImageLockMode.WriteOnly,
                                            b.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = bmpData.Stride * b.Height;
            var rgbValues = new byte[bytes];

            // fill in rgbValues, e.g. with a for loop over an input array

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            b.UnlockBits(bmpData);
            return b;
        }

    }
}
