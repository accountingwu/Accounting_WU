using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class Side
    {
        public int SideID { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is required.")]
        public string SideCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string SideName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string SideNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }    
}