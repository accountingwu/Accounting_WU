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
    
    public partial class pm_rodetail
    {
        public int ord_id { get; set; }
        public int ro_id { get; set; }
        public string tagid { get; set; }
        public string maccode { get; set; }
        public string macname { get; set; }
        public Nullable<int> sysmp_id { get; set; }
        public string sysmp_name { get; set; }
        public Nullable<int> case_id { get; set; }
        public string case_name { get; set; }
        public string remark { get; set; }
        public Nullable<int> status_gen { get; set; }
        public Nullable<int> wtc_id { get; set; }
    }
}
