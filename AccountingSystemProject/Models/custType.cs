using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class custType
    {
        public int CustTypeID { get; set; }
        public string CustTypeCode { get; set; }
        public string CustTypeName { get; set; }
        public string CustTypeNameEng { get; set; }
        public string Remark { get; set; }

    }
    
}