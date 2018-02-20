using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class VATGroupModel
    {
        public int VATGroupID { get; set; }
        public string VATGroupCode { get; set; }
        public string AccCode { get; set; }
        public Nullable<double> VatRate { get; set; }
        public string VatType { get; set; }
        public string Remark { get; set; }
        public string ReportName { get; set; }
        public string ccode { get; set; }
    }
    public class Vatview
    {
        public int VATGroupID { get; set; }
        public string VATGroupCode { get; set; }
        public string AccCode { get; set; }
        public string AccName { get; set; }
        public Nullable<double> VatRate { get; set; }
        public string VatType { get; set; }
        public string Remark { get; set; }
        public string ReportName { get; set; }
        public string ccode { get; set; }
    }
}