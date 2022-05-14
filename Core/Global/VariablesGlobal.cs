using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Global
{
    //class lưu biến global khi runtime
    public sealed class VariablesGlobal
    {
        private static readonly Lazy<VariablesGlobal> Lazy =
            new Lazy<VariablesGlobal>(() => new VariablesGlobal());

        /// <summary>
        /// Access point to methods and properties
        /// </summary>
        public static VariablesGlobal Instance => Lazy.Value;
        public char[] ChartArray { get; set; }
        public DangNhap UserLoginCurrent { get; set; }
    }
}
