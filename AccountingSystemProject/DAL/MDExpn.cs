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
    
    public partial class MDExpn
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
}
