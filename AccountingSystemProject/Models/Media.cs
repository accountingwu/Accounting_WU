using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class Media
    {
        public int CustMediaID { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is required.")]
        public string CustMediaCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string CustMediaName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string CustMediaNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }    

}