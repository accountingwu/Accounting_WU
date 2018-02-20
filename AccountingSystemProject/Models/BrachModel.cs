using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class BrachModel
    {

        public int b_id { get; set; }
        public string ccode { get; set; }
        public string bcode { get; set; }
        public string bname1 { get; set; }
        public string bname12 { get; set; }
        public string bname2 { get; set; }
        public string bname22 { get; set; }
        public string baddress1 { get; set; }
        public string baddress2 { get; set; }
        public string bzip { get; set; }
        public string btel { get; set; }
        public string bfax { get; set; }
        public string wcode { get; set; }
        public Nullable<int> postformat { get; set; }
        public Nullable<int> sp_num { get; set; }
    }
}