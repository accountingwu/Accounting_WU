using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class PR_MemberModel
    {
        public int pr_id { get; set; }
        public string pcode { get; set; }
        public string pname1 { get; set; }
        public Nullable<decimal> num1 { get; set; }
        public Nullable<decimal> num2 { get; set; }
        public Nullable<decimal> price { get; set; }
        public string discount { get; set; }
        public Nullable<decimal> cost { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public Nullable<System.DateTime> pr_date2 { get; set; }
        public Nullable<int> sunitid { get; set; }
        public Nullable<decimal> avaliable_stock { get; set; }
        public Nullable<decimal> sumBook { get; set; }
    }
}