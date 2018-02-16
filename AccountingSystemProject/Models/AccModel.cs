using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class AccModel
    {
        public int AccID { get; set; }
        public Nullable<int> AccTypeID { get; set; }
        public Nullable<int> AccCashID { get; set; }
        public Nullable<int> AccFinanID { get; set; }
        public Nullable<int> AccStrucID { get; set; }
        public string AccCode { get; set; }
        public Nullable<int> AccControlID { get; set; }
        public string AccName { get; set; }
        public string AccNameEng { get; set; }
        public string AccGroup { get; set; }
        public string AccLevel { get; set; }
        public string AccControlFlag { get; set; }
        public string AccBalnDrCr { get; set; }
        public string AccHaveAlloc { get; set; }
        public string AccHaveQty { get; set; }
        public string AccStrucCode { get; set; }
        public string AccHaveDept { get; set; }
        public string AccHaveJob { get; set; }
        public string CloseAcc { get; set; }
        public string ccode { get; set; }
    }

    public class AccViw
    {
        public int AccID { get; set; }
        public string AccName { get; set; }
        public string AccNameEng { get; set; }
        public string AccCode { get; set; }
        public string AccTypeName { get; set; }

    }
}