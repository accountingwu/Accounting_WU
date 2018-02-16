using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class BillGrp
    {
        public int BillGroupID { get; set; }
        //[Required(ErrorMessage = "BusiTypeCode is required.")]
        public string BillGroupCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string BillGroupName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string BillGroupNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }

    public class InsertBillGrp
    {        
        public string BillGroupCode { get; set; }
        //[Required(ErrorMessage = "BusiTypeName is required.")]
        public string BillGroupName { get; set; }
        //[Required(ErrorMessage = "BusiTypeNameEng is required.")]
        public string BillGroupNameEng { get; set; }
        //[Required(ErrorMessage = "Remark is required.")]
        public string Remark { get; set; }
    }
}