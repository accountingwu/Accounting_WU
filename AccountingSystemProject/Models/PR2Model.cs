using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class PR2Model
    {
        public int pr_id { get; set; }
        public string ccode { get; set; }
        public string bcode { get; set; }
        public string pcode { get; set; }
        public string pname1 { get; set; }
        public Nullable<decimal> num1 { get; set; }
        public Nullable<decimal> price { get; set; }
        public string discount { get; set; }
        public string pr { get; set; }
        public string pr_no { get; set; }
        public string ref_no { get; set; }
        public Nullable<System.DateTime> pr_date { get; set; }
        public Nullable<int> sup_id { get; set; }
        public string secode { get; set; }
        public string curcode { get; set; }
        public Nullable<decimal> curexchange { get; set; }
        public Nullable<decimal> vattype { get; set; }
        public string vat { get; set; }
        public Nullable<bool> verify { get; set; }
        public Nullable<System.DateTime> verify_date { get; set; }
        public Nullable<int> PRstate { get; set; }
        public string statusPR { get; set; }
        public Nullable<decimal> total_qty { get; set; }
        public Nullable<decimal> total_discount_p { get; set; }
        public Nullable<decimal> total_discount_c { get; set; }
        public Nullable<decimal> total_b_vat { get; set; }
        public Nullable<decimal> total_vat { get; set; }
        public Nullable<decimal> total_net { get; set; }
        public string bname1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public string PR_Num { get; set; }
        public string status_ref { get; set; }
    }
}