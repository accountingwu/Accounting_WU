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
    
    public partial class Currency
    {
        public int cur_id { get; set; }
        public string curcode { get; set; }
        public string curname1 { get; set; }
        public string curname2 { get; set; }
        public string cursymbol { get; set; }
        public Nullable<decimal> curexchange { get; set; }
    }
}