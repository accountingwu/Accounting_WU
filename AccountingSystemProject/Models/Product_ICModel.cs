﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class Product_ICModel
    {
        public int prod_id { get; set; }
        public string pcode { get; set; }
        public string pname1 { get; set; }
        public string pname11 { get; set; }
        public string pname2 { get; set; }
        public string pname21 { get; set; }
        public string ptype { get; set; }
        public Nullable<decimal> pqty { get; set; }
        public Nullable<decimal> pbook { get; set; }
        public Nullable<decimal> pcost { get; set; }
        public string grpcode { get; set; }
        public string wcode { get; set; }
        public string pstatus { get; set; }
        public Nullable<System.DateTime> pinactive { get; set; }
        public Nullable<bool> psvat { get; set; }
        public Nullable<bool> ppvat { get; set; }
        public Nullable<int> pcst { get; set; }
        public Nullable<bool> prpt { get; set; }
        public Nullable<int> ctype { get; set; }
        public Nullable<int> stduid { get; set; }
        public Nullable<int> buid { get; set; }
        public Nullable<int> suid { get; set; }
        public Nullable<int> stuid { get; set; }
        public Nullable<int> stbuid { get; set; }
        public Nullable<int> stsuid { get; set; }
        public Nullable<decimal> bnum { get; set; }
        public Nullable<decimal> snum { get; set; }
        public Nullable<decimal> stnum { get; set; }
        public Nullable<decimal> stbnum { get; set; }
        public Nullable<decimal> stsnum { get; set; }
        public string u0s { get; set; }
        public string u1s { get; set; }
        public string u2s { get; set; }
        public string u3s { get; set; }
        public string u4s { get; set; }
        public Nullable<decimal> s1 { get; set; }
        public Nullable<decimal> s2 { get; set; }
        public Nullable<decimal> s3 { get; set; }
        public Nullable<decimal> s4 { get; set; }
        public Nullable<decimal> s5 { get; set; }
        public Nullable<decimal> s6 { get; set; }
        public Nullable<decimal> ss1 { get; set; }
        public Nullable<decimal> ss2 { get; set; }
        public Nullable<decimal> ss3 { get; set; }
        public Nullable<decimal> ss4 { get; set; }
        public Nullable<decimal> stddiscount { get; set; }
        public Nullable<decimal> xprice { get; set; }
        public string xname { get; set; }
        public Nullable<decimal> a1 { get; set; }
        public Nullable<decimal> a2 { get; set; }
        public Nullable<decimal> a3 { get; set; }
        public Nullable<decimal> a4 { get; set; }
        public Nullable<decimal> a5 { get; set; }
        public Nullable<decimal> b1 { get; set; }
        public Nullable<decimal> b2 { get; set; }
        public Nullable<decimal> b3 { get; set; }
        public Nullable<decimal> b4 { get; set; }
        public Nullable<decimal> b5 { get; set; }
        public Nullable<decimal> c1 { get; set; }
        public Nullable<decimal> c2 { get; set; }
        public Nullable<decimal> c3 { get; set; }
        public Nullable<decimal> c4 { get; set; }
        public Nullable<decimal> c5 { get; set; }
        public Nullable<decimal> d1 { get; set; }
        public Nullable<decimal> d2 { get; set; }
        public Nullable<decimal> d3 { get; set; }
        public Nullable<decimal> d4 { get; set; }
        public Nullable<decimal> d5 { get; set; }
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
        public string imgpath { get; set; }
        public string ccode { get; set; }
        public int mstatus { get; set; }
        public Nullable<int> ltsale { get; set; }
        public Nullable<int> ltsend { get; set; }
        public string barcodeid { get; set; }
        public string AmountSet { get; set; }
        public byte[] file_img { get; set; }
        public string file_type { get; set; }
        public Nullable<int> dayupSent { get; set; }
        public Nullable<int> moq { get; set; }
        public Nullable<int> st2uid { get; set; }
        public Nullable<decimal> st2num { get; set; }
        public string LotSerialExpireFlag { get; set; }
        public string grpcode2 { get; set; }
        public string grpcode3 { get; set; }
        public string grpcode4 { get; set; }
        public string grpcode5 { get; set; }
    }
}