﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class doModel
    {
        public int doID { get; set; }
        public string DOdoc { get; set; }
        public string docID { get; set; }
        public Nullable<System.DateTime> doDate { get; set; }
        public Nullable<int> soID { get; set; }
        public string cusID { get; set; }
        public string vatID { get; set; }
        public string vatInclude { get; set; }
        public string remark { get; set; }
        public string ccID { get; set; }
        public string ccChange { get; set; }
        public string cf { get; set; }
        public Nullable<decimal> total { get; set; }
        public string discount { get; set; }
        public Nullable<decimal> discount2 { get; set; }
        public Nullable<decimal> befVat { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> aftVat { get; set; }
        public string saleID { get; set; }
        public string credit { get; set; }
        public Nullable<System.DateTime> expire { get; set; }
        public Nullable<System.DateTime> expect { get; set; }
        public string dcusID { get; set; }
        public string remark1 { get; set; }
        public string remark2 { get; set; }
        public string remark3 { get; set; }
        public string remark4 { get; set; }
        public string remark5 { get; set; }
        public string remark6 { get; set; }
        public string remark7 { get; set; }
        public string remark8 { get; set; }
        public string remark9 { get; set; }
        public string remark10 { get; set; }
        public string did { get; set; }
        public string pid { get; set; }
        public string refID { get; set; }
        public string closed { get; set; }
        public string cancel { get; set; }
        public string bcode { get; set; }
        public string @lock { get; set; }
        public string ccode { get; set; }
        public Nullable<int> pro_id { get; set; }
    }
}