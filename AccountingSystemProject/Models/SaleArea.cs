using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class SaleArea
    {
        public int SaleAreaID { get; set; }
        public string SaleAreaCode { get; set; }
        public string SaleAreaName { get; set; }
        public string SaleAreaNameEng { get; set; }
        public string Remark { get; set; }
    }
}