using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class SupplierModel
    {
        public int sup_id { get; set; } //รหัสผู้จำหน่าย 
        public string supcode { get; set; } //รหัส
        public string supname1 { get; set; } //ชื่อเต็มไทย
        public string supname11 { get; set; } //ชื่อย่อ
        public string supname2 { get; set; } //ชื่อเต็มอิ้ง
        public string supname21 { get; set; } //ชื่อย่ออิ้ง
        public string supaddress1 { get; set; }//ที่อยู่ไทย
        public string supaddress2 { get; set; } //ที่อยู่อิ้ง
        public string supzip { get; set; } //รหัสไปรษณีย์
        public string suptel { get; set; } //เบอร์
        public string supfax { get; set; } //แฟก
        public string supmobile { get; set; } //เบอร์มือถือ
        public Nullable<System.DateTime> dateinact { get; set; } //วันที่ยกเลิกกการติดต่อ
        public Nullable<bool> status { get; set; } //สถานะ
        public string p_id { get; set; } //เลขประจำตัว
        public string t_id { get; set; } //เลขที่ผู้เสียภาษี
        public string niti { get; set; } //เป็นนิติหรือไม่
        public string acc_code { get; set; } //รหัสบัญชี
        public Nullable<int> gsupid { get; set; } //รหัสลูกค้า
        public string contaddress1 { get; set; } //ที่อยุ่ผู้ใช้ไทย
        public string contaddress2 { get; set; } //ที่อยุ่ผู้ใช้อิ้ง
        public string contzip { get; set; } //รหัสไปษณีย์ผู้ใช้
        public string notebill { get; set; } //หมายเหตุสำหรับออกบิล
        public string noteth { get; set; } //reserved
        public string noteen { get; set; } //reserved
        public string credittermday { get; set; } //เครดิต
        public Nullable<int> creditmoney { get; set; } //วงเงินเครดิต
        public string contname { get; set; } //ชื่อผู้ติดต่อ
        public string ncostcode { get; set; } //
        public string ndiscountcode { get; set; } //นโยบายส่วนลด
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
    }

    public class Supview
    {
        public int AccID { get; set; } //รหัสบัญชี
        public string AccName { get; set; } //รหัส
        public int sup_id { get; set; } //รหัสผู้จำหน่าย 
        public string supcode { get; set; } //รหัส
        public string supname1 { get; set; } //ชื่อเต็มไทย
        public string supname11 { get; set; } //ชื่อย่อ
        public string supname2 { get; set; } //ชื่อเต็มอิ้ง
        public string supname21 { get; set; } //ชื่อย่ออิ้ง
        public string supaddress1 { get; set; }//ที่อยู่ไทย
        public string supaddress2 { get; set; } //ที่อยู่อิ้ง
        public string supzip { get; set; } //รหัสไปรษณีย์
        public string suptel { get; set; } //เบอร์
        public string supfax { get; set; } //แฟก
        public string supmobile { get; set; } //เบอร์มือถือ
        public Nullable<System.DateTime> dateinact { get; set; } //วันที่ยกเลิกกการติดต่อ
        public Nullable<bool> status { get; set; } //สถานะ
        public string p_id { get; set; } //เลขประจำตัว
        public string t_id { get; set; } //เลขที่ผู้เสียภาษี
        public string niti { get; set; } //เป็นนิติหรือไม่
        public string acc_code { get; set; } //รหัสบัญชี
        public Nullable<int> gsupid { get; set; } //รหัสลูกค้า
        public string contaddress1 { get; set; } //ที่อยุ่ผู้ใช้ไทย
        public string contaddress2 { get; set; } //ที่อยุ่ผู้ใช้อิ้ง
        public string contzip { get; set; } //รหัสไปษณีย์ผู้ใช้
        public string notebill { get; set; } //หมายเหตุสำหรับออกบิล
        public string noteth { get; set; } //reserved
        public string noteen { get; set; } //reserved
        public string credittermday { get; set; } //เครดิต
        public Nullable<int> creditmoney { get; set; } //วงเงินเครดิต
        public string contname { get; set; } //ชื่อผู้ติดต่อ
        public string ncostcode { get; set; } //
        public string ndiscountcode { get; set; } //นโยบายส่วนลด
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
    }
}