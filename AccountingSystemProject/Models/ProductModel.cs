using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class ProductModel
    {
        public int prod_id { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is required.")]
        public string pcode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string pname1 { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string pname11 { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
    }
}