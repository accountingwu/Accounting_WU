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
    
    public partial class pm_issue_componentcost
    {
        public int issue_id { get; set; }
        public string wcode { get; set; }
        public string lot_id { get; set; }
        public string ep_type_code { get; set; }
        public string eqsp_code { get; set; }
        public Nullable<decimal> eqsp_num { get; set; }
        public string eqsp_unit { get; set; }
        public Nullable<decimal> eqsp_price_unit { get; set; }
        public Nullable<decimal> eqsp_price_total { get; set; }
        public Nullable<int> issue_type { get; set; }
    }
}
