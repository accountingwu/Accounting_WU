using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class ExpnModel
    {
        public int ExpnID { get; set; }
        public Nullable<int> AccID { get; set; }
        public string ExpnCode { get; set; }
        public string ExpnName { get; set; }
        public string ExpnNameEng { get; set; }
        public string Remark { get; set; }
        public string ExpnType { get; set; }
        public string ccode { get; set; }
    }
    public class Expnview
    {
        public int ExpnID { get; set; }
        public Nullable<int> AccID { get; set; }
        public string ExpnCode { get; set; }
        public string ExpnName { get; set; }
        public string ExpnNameEng { get; set; }
        public string Remark { get; set; }
        public string ExpnType { get; set; }
        public string ccode { get; set; }
        public string AccCode { get; set; }
        public string AccName { get; set; }
    }
}