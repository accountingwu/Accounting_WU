using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class CustomerPriority
    {
        public int PriorityID { get; set; }
        public string PriorityCode { get; set; }
        public string Remark { get; set; }       
    }
}