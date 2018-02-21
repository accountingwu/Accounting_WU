using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class ProductModel
    {
        public int prod_id { get; set; } //Primary Key
        public string pcode { get; set; } //รหัสสินค้า
        public string pname1 { get; set; } //ชื่อเต็มสินค้าภาษาไทย
        public string pname11 { get; set; } //ชื่อย่อสินค้าภาษาไทย
        public string pname2 { get; set; } //ชื่อเต็มสินค้าภาษาอังกฤษ
        public string pname21 { get; set; } //ชื่อย่อสินค้าภาษาอังกฤษ
        public string ptype { get; set; } //ประเภทของสินค้า
        public decimal pqty { get; set; } //ปริมาณสินค้าคงเหลือรวมทั้งสาขา
        public decimal pbook { get; set; } //ปริมาณสินค้าที่ถูกจอง
        public decimal pcost { get; set; } //ต้นทุนมาตรฐานของสินค้า
        public string grpcode { get; set; } //Foreigner Key กับ Table Groupproduct
        public string wcode { get; set; } //Foreigner Key กับ Table Warehouse เพื่อระบุคลัง
        public string pstatus { get; set; } //สถานะของสูตร A = Actine , I = Inactive
        public DateTime pinactive { get; set; } //วันที่สินค้า Inactive
        public bool psvat { get; set; } //ราคาขายสินค้าเป็น 1 แยกนอก , 0 รวมใน
        public bool ppvat { get; set; } //ราคาซื้อสินค้าเป็น 1 แยกนอก , 0 รวมใน
        public int pcst { get; set; } //การนับยอดสต็อก
        public bool prpt { get; set; } //การแสดงราคาที่เอกสารจัดซื้อ 1 ไม่ระบุ , 0 ราคาทุนมาตรฐาน , 2 ราคาซื้อล่าสุด
        public int ctype { get; set; } //
        public int stduid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยมาตรฐาน
        public int buid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยซื้อส่วนใหญ่
        public int suid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยขายส่วนใหญ่
        public int stuid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยคุมสต็อกส่วนใหญ่
        public int stbuid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยคุมสต็อกซื้อส่วนใหญ่
        public int stsuid { get; set; } //Foreigner Key กับ Table Unit แสดงหน่วยคุมสต็อกขายส่วนใหญ่
        public decimal bnum { get; set; } //อัตราแปลงหน่วยซื้อส่วนใหญ่
        public decimal snum { get; set; } //อัตราแปลงหน่วยขายส่วนใหญ่
        public decimal stnum { get; set; } //อัตราแปลงหน่วยคุมสต็อก
        public decimal stbnum { get; set; } //อัตราแปลงหน่วยคุมสต็อกซื้อ
        public decimal stsnum { get; set; } //อัตราแปลงหน่วยคุมสต็อกขาย
        public string u0s { get; set; } //หน่วยซื้อส่วนใหญ่
        public string u1s { get; set; } //หน่วยขายส่วนใหญ่
        public string u2s { get; set; } //หน่วยคุมสต็อก
        public string u3s { get; set; } //หน่วยคุมสต็อกซื้อส่วนใหญ่
        public string u4s { get; set; } //หน่วยคุมสต็อกขายส่วนใหญ่
        public decimal s1 { get; set; } //หน่วยราคาขายมาตรฐานตามหน่วยนับ
        public decimal s2 { get; set; } //หน่วยราคาขายแยกตามหน่วยนับบรรทัด 1
        public decimal s3 { get; set; } //หน่วยราคาขายแยกตามหน่วยนับบรรทัด 2
        public decimal s4 { get; set; } //หน่วยราคาขายแยกตามหน่วยนับบรรทัด 3
        public decimal s5 { get; set; } //หน่วยราคาขายแยกตามหน่วยนับบรรทัด 4 
        public decimal s6 { get; set; } //หน่วยราคาขายต่ำสุด
        public decimal ss1 { get; set; } // ราคาขายแยกตามหน่วยนับรรทัด 1
        public decimal ss2 { get; set; } //ราคาขายแยกตามหน่วยนับรรทัด 2
        public decimal ss3 { get; set; } //ราคาขายแยกตามหน่วยนับรรทัด 3
        public decimal ss4 { get; set; } //ราคาขายแยกตามหน่วยนับรรทัด 4
        public decimal stddiscount { get; set; } //ส่วนลดมาตรฐาน
        public decimal xprice { get; set; } //ราคาขายตามบรรจุภัณฑ์
        public string xname { get; set; } //ชื่อผู้ผลิต
        public decimal a1 { get; set; } //ราคาขายสำหรับลูกค้าเกรด A1
        public decimal a2 { get; set; } //ราคาขายสำหรับลูกค้าเกรด A2
        public decimal a3 { get; set; } //ราคาขายสำหรับลูกค้าเกรด A3
        public decimal a4 { get; set; } //ราคาขายสำหรับลูกค้าเกรด A4
        public decimal a5 { get; set; } //ราคาขายสำหรับลูกค้าเกรด A5
        public decimal b1 { get; set; } //ราคาขายสำหรับลูกค้าเกรด B1
        public decimal b2 { get; set; } //ราคาขายสำหรับลูกค้าเกรด B2
        public decimal b3 { get; set; } //ราคาขายสำหรับลูกค้าเกรด B3
        public decimal b4 { get; set; } //ราคาขายสำหรับลูกค้าเกรด B4
        public decimal b5 { get; set; } //ราคาขายสำหรับลูกค้าเกรด B5
        public decimal c1 { get; set; } //
        public decimal c2 { get; set; } //
        public decimal c3 { get; set; } //
        public decimal c4 { get; set; } //
        public decimal c5 { get; set; } //
        public decimal d1 { get; set; }
        public decimal d2 { get; set; }
        public decimal d3 { get; set; }
        public decimal d4 { get; set; }
        public decimal d5 { get; set; }
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
        public string imgpath { get; set; } //บันทึกรูปภาพ
        public string ccode { get; set; }
        public int mstatus { get; set; }
        public int ltsale { get; set; }
        public int ltsend { get; set; }
        public string barcodeid { get; set; }
        public string AmountSet { get; set; }
        public byte[] file_img { get; set; }
        public string file_type { get; set; }
        public int dayupSent { get; set; }
        public int moq { get; set; }
        public int st2uid { get; set; }
        public decimal st2num { get; set; }
        public string LotSerialExpireFlag { get; set; }
        public string grpcode2 { get; set; }
        public string grpcode3 { get; set; }
        public string grpcode4 { get; set; }
        public string grpcode5 { get; set; }
    }
}