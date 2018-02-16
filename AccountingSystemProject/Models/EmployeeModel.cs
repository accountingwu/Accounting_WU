using System;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class EmployeeModel
    {
        public int EmpID { get; set; }
        public Nullable<int> EmpHead { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string EmpTitle { get; set; }
        public string EmpNameEng { get; set; }
        public string EmpType { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> EmpStartDate { get; set; }
        public Nullable<System.DateTime> EmpPromoteDate { get; set; }
        public Nullable<System.DateTime> EmpResignDate { get; set; }
        public string EmpAddr1 { get; set; }
        public string District { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string EmpStatus { get; set; }
        public string EmpTitleEng { get; set; }
        public string EmpSignature { get; set; }
        public string Username { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> EmpGroupID { get; set; }
        public Nullable<int> PostID { get; set; }
        public string TaxID { get; set; }
        public string IDCard { get; set; }
        public string Remark { get; set; }
        public string ccode { get; set; }
    }
}
