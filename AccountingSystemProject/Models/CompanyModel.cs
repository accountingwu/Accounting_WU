using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class CompanyModel
    {
        public int corp_id { get; set; } //Primary Key
        public string ccode { get; set; }//รหัสบริษัท
        public string cname1 { get; set; }//ชื่อจริงบริษัท
        public string cname11 { get; set; }//ชื่อย่อบริษัท
        public string cname2 { get; set; } //ชื่อจริงบริษัทภาษาอังกฤษ
        public string cname21 { get; set; } //ชื่อย่อบริษัทภาษาอังกฤษ
        public string caddress1 { get; set; } //ที่อยู่บริษัทภาษาไทย
        public string caddress2 { get; set; } //ที่อยู่บริษัทภาษาอังกฤษ
        public string czip { get; set; } //รหัสไปรษณีย์บริษัท
        public string ctel { get; set; } //เบอร์โทรศัพท์บริษัท
        public string cfax { get; set; } //เบอร์แฟกซ์บริษัท
        public Nullable<System.DateTime> cdatestart { get; set; } //วันที่เริ่มระบบ
        public string taxid { get; set; } //เลขประจำตัวผู้เสียภาษี
        public Nullable<int> number1 { get; set; } //จำนวนหลักของจำนวนสินค้า (บันทึก)
        public Nullable<int> number2 { get; set; } //จำนวนหลักของราคาสินค้า (บันทึก)
        public Nullable<int> number3 { get; set; } //จำนวนหลักของจำนวนเงิน (บันทึก)
        public Nullable<int> number4 { get; set; } //จำนวนหลักของมูลค่าภาษี (บันทึก)
        public Nullable<int> number5 { get; set; } //จำนวนหลักของจำนวนสินค้า (ออกรายงาน)
        public Nullable<int> number6 { get; set; } //จำนวนหลักของราคาสินค้า (ออกรายงาน)
        public Nullable<int> number7 { get; set; }// จำนวนหลักของจำนวนเงิน (ออกรายงาน)
        public Nullable<int> number8 { get; set; } //จำนวนหลักของมูลค่าภาษี (ออกรายงาน)
        public Nullable<int> decimal1 { get; set; } //จำนวนทศนิยมของจำนวนสินค้า (บันทึก)
        public Nullable<int> decimal2 { get; set; } //จำนวนทศนิยมของราคาสินค้า (บันทึก)
        public Nullable<int> decimal3 { get; set; } //จำนวนทศนิยมของจำนวนเงิน (บันทึก)
        public Nullable<int> decimal4 { get; set; } //จำนวนทศนิยมของมูลค่าภาษี (บันทึก)
        public Nullable<int> decimal5 { get; set; } //จำนวนทศนิยมของจำนวนสินค้า (ออกรายงาน)
        public Nullable<int> decimal6 { get; set; } //จำนวนทศนิยมของราคาสินค้า (ออกรายงาน)
        public Nullable<int> decimal7 { get; set; } //จำนวนทศนิยมของจำนวนเงิน (ออกรายงาน)
        public Nullable<int> decimal8 { get; set; } //จำนวนทศนิยมของมูลค่าภาษี (ออกรายงาน)
        public Nullable<int> stockcount { get; set; }//ประเภทการนับยอดสต๊อก
        public Nullable<int> WLN_SO { get; set; }
        public byte[] file_img { get; set; }
        public string ref_tr { get; set; }
        public string winstatus { get; set; }
        public string wintrauto { get; set; }
        public Nullable<int> wintrautonum { get; set; }
    }
}