using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class ReceivePlaceModel
    {

        public int DropShipID { get; set; }
        public string DropShipCode { get; set; }
        public string DropShipName { get; set; }
        public string Addr { get; set; }
        public string District { get; set; }
        public string Amphur { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Contact { get; set; }
        public string Remark { get; set; }
        public string ccode { get; set; }
        public string bcode { get; set; }
        public class EmployeeView
        {
            public int eid { get; set; }
            public int DropShipID { get; set; }
            public string ecode { get; set; }
            public string DropShipCode { get; set; }
            public string DropShipName { get; set; }
            public string ename1 { get; set; }
            public string District { get; set; }
            public string Amphur { get; set; }
            public string Province { get; set; }
            public string ename2 { get; set; }
            public string Contact { get; set; }
            public string PostCode { get; set; }
            public string Tel { get; set; }
            public string Fax { get; set; }
            
            public string Remark { get; set; }
            public string ccode { get; set; }
            public string bcode { get; set; }
            public string address2 { get; set; }
            public string zip { get; set; }
            public string Addr { get; set; }
            public string tel { get; set; }
            public string mobile { get; set; }
            public string fax { get; set; }
            public Nullable<System.DateTime> startdate { get; set; }
            public Nullable<decimal> commission { get; set; }
            public Nullable<bool> issale { get; set; }
            public Nullable<int> saleteam { get; set; }
            public Nullable<bool> isusr { get; set; }
    
            public string secode { get; set; }
            public Nullable<int> coststatus { get; set; }
        }
    }

}