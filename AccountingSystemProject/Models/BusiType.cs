using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class BusiType
    {
        public int BusiTypeID { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is reqired.")]
        public string BusiTypeCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string BusiTypeName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string BusiTypeNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }

    public class BusiType2
    {
        public string BusiTypeCode { get; set; }
        public string BusiTypeName { get; set; }
        public string BusiTypeNameEng { get; set; }
        public string Remark { get; set; }
    }
}