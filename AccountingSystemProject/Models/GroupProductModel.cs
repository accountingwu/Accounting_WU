using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class GroupProductModel
    {
        public int bciid { get; set; }
        public string grpcode { get; set; }
        public string grpname1 { get; set; }
        public string grpname2 { get; set; }
        public Nullable<int> grpcountstock { get; set; }
        public string ccode { get; set; }
    }
}