using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class BankBookType
    {
        public int BookTypeID { get; set; }
        public string BookTypeCode { get; set; }
        public string BookTypeName { get; set; }
        public string BookTypeNameEng { get; set; }
        public string Remark { get; set; }
    }
}