using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class CustomerModel
    {
        public int cust_id { get; set; }
        public string cuscode { get; set; }
        public string cusname1 { get; set; }
        public string cusname11 { get; set; }
        public string cusname2 { get; set; }
        public string cusname21 { get; set; }
        public string cusaddress1 { get; set; }
        public string cusaddress2 { get; set; }
        public string cuszip { get; set; }
        public string custel { get; set; }
        public string cusfax { get; set; }
        public string cusmobile { get; set; }
        public Nullable<System.DateTime> datecontact { get; set; }
        public Nullable<System.DateTime> dateinact { get; set; }
        public Nullable<bool> status { get; set; }
        public string p_id { get; set; }
        public string t_id { get; set; }
        public string niti { get; set; }
        public string acc_code { get; set; }
        public Nullable<int> gcusid { get; set; }
        public string contaddress1 { get; set; }
        public string contaddress2 { get; set; }
        public string contzip { get; set; }
        public string notebill { get; set; }
        public string noteth { get; set; }
        public string noteen { get; set; }
        public Nullable<int> cuszid { get; set; }
        public Nullable<int> credittermtype { get; set; }
        public Nullable<int> credittermday { get; set; }
        public Nullable<decimal> creditmoney { get; set; }
        public Nullable<int> saleid { get; set; }
        public string contname { get; set; }
        public string blacklist { get; set; }
        public string reason { get; set; }
        public string grade { get; set; }
        public string conname { get; set; }
        public string cusidinvoice { get; set; }
        public string cusidbill { get; set; }
        public string cusidsend { get; set; }
        public string sendid { get; set; }
        public string ncostcode { get; set; }
        public string ndiscountcode { get; set; }
        public Nullable<decimal> discountlist { get; set; }
        public Nullable<decimal> discountbill { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public string ccode { get; set; }
        public Nullable<int> ShippingDate { get; set; }
    }
    public class CustView
    {
        public int cust_id { get; set; }
        public string cuscode { get; set; }
        public string cusname1 { get; set; }
        public string cusname11 { get; set; }
        public string cusname2 { get; set; }
        public string cusname21 { get; set; }
        public string cusaddress1 { get; set; }
        public string cusaddress2 { get; set; }
        public string cuszip { get; set; }
        public string custel { get; set; }
        public string cusfax { get; set; }
        public string cusmobile { get; set; }
        public Nullable<System.DateTime> datecontact { get; set; }
        public Nullable<System.DateTime> dateinact { get; set; }
        public Nullable<bool> status { get; set; }
        public string p_id { get; set; }
        public string t_id { get; set; }
        public string niti { get; set; }
        public string acc_code { get; set; }
        public Nullable<int> gcusid { get; set; }
        public string contaddress1 { get; set; }
        public string contaddress2 { get; set; }
        public string contzip { get; set; }
        public string notebill { get; set; }
        public string noteth { get; set; }
        public string noteen { get; set; }
        public Nullable<int> cuszid { get; set; }
        public Nullable<int> credittermtype { get; set; }
        public Nullable<int> credittermday { get; set; }
        public Nullable<decimal> creditmoney { get; set; }
        public Nullable<int> saleid { get; set; }
        public string contname { get; set; }
        public string blacklist { get; set; }
        public string reason { get; set; }
        public string grade { get; set; }
        public string conname { get; set; }
        public string cusidinvoice { get; set; }
        public string cusidbill { get; set; }
        public string cusidsend { get; set; }
        public string sendid { get; set; }
        public string ncostcode { get; set; }
        public string ndiscountcode { get; set; }
        public Nullable<decimal> discountlist { get; set; }
        public Nullable<decimal> discountbill { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public string ccode { get; set; }
        public Nullable<int> ShippingDate { get; set; }
        public int eid { get; set; }
        public string ecode { get; set; }
        public string ename1 { get; set; }
    }
}