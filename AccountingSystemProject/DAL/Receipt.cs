//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSystemProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipt
    {
        public int bciid { get; set; }
        public Nullable<int> cusid { get; set; }
        public Nullable<int> eid { get; set; }
        public string doc_no { get; set; }
        public string doc_ref { get; set; }
        public Nullable<System.DateTime> dateno { get; set; }
        public Nullable<System.DateTime> dateref { get; set; }
        public string status { get; set; }
        public string bcode { get; set; }
        public string ccode { get; set; }
    }
}
