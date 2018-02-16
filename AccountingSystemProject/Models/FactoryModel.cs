using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class FactoryModel
    {
        public int fac_id { get; set; }
        public string fcode { get; set; }
        public string fname1 { get; set; }
        public string fname2 { get; set; }
        public Nullable<decimal> fcap { get; set; }
        public string bcode { get; set; }
        public string ccode { get; set; }
        
    }
}