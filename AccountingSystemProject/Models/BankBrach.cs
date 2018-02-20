using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class BankBrach
    {
        public int BankBrchID { get; set; }
        public string BankBrchCode { get; set; }
        public string BankBrchName { get; set; }
        public string BankBrchNameEng { get; set; }
        public string Remark { get; set; }
        public string BankBrchAddr1 { get; set; }
        public string BankBrchAddr2 { get; set; }
    }
}