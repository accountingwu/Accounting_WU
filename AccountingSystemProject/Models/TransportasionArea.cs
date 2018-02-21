using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class TransportasionArea
    {
        public int TranspAreaID { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is required.")]
        public string TranspAreaCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string TranspAreaName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string TranspAreaNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }
}