using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Model
{
    public class NhaCungCap
    {
        public int ID { get; set; }
        public string MANCC { get; set; }
        public string TENNCC { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public bool NGUNGHOPTAC { get; set; }
    }
}
