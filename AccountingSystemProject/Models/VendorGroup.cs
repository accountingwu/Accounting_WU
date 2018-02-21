using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class VendorGroup
    {
        public int VendorGroupID { get; set; }
        public string VendorGroupCode { get; set; }
        public string VendorGroupName { get; set; }
        public string VendorGroupNameEng { get; set; }
        public string Remark { get; set; }

    }
}