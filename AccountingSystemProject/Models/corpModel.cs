using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class corpModel
    {
        public int corp_id { get; set; }
        public string ccode { get; set; }
        public string cname1 { get; set; }
        public string cname11 { get; set; }
        public string cname2 { get; set; }
        public string cname21 { get; set; }
        public string caddress1 { get; set; }
        public string caddress2 { get; set; }
        public string czip { get; set; }
        public string ctel { get; set; }
        public string cfax { get; set; }
        public Nullable<System.DateTime> cdatestart { get; set; }
        public string taxid { get; set; }
        public Nullable<int> number1 { get; set; }
        public Nullable<int> number2 { get; set; }
        public Nullable<int> number3 { get; set; }
        public Nullable<int> number4 { get; set; }
        public Nullable<int> number5 { get; set; }
        public Nullable<int> number6 { get; set; }
        public Nullable<int> number7 { get; set; }
        public Nullable<int> number8 { get; set; }
        public Nullable<int> decimal1 { get; set; }
        public Nullable<int> decimal2 { get; set; }
        public Nullable<int> decimal3 { get; set; }
        public Nullable<int> decimal4 { get; set; }
        public Nullable<int> decimal5 { get; set; }
        public Nullable<int> decimal6 { get; set; }
        public Nullable<int> decimal7 { get; set; }
        public Nullable<int> decimal8 { get; set; }
        public Nullable<int> stockcount { get; set; }
        public Nullable<int> WLN_SO { get; set; }
        public byte[] file_img { get; set; }
        public string ref_tr { get; set; }
        public string winstatus { get; set; }
        public string wintrauto { get; set; }
        public Nullable<int> wintrautonum { get; set; }
    }
}