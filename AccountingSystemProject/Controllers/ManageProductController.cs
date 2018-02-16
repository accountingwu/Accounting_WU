using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingSystemProject.DAL;
using PagedList;
using AccountingSystemProject.Models;

namespace AccountingSystemProject.Controllers
{
    public class ManageProductController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        // GET: ManageProduct
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageProduct_IC(int? page, string sortOrder)
        {
            ViewBag.pcodeSortParm = String.IsNullOrEmpty(sortOrder) ? "pcode" : "";
            ViewBag.pname1SortParm = String.IsNullOrEmpty(sortOrder) ? "pname1" : "";
            ViewBag.pname11SortParm = String.IsNullOrEmpty(sortOrder) ? "pname11" : "";
            ViewBag.ptypeSortParm = String.IsNullOrEmpty(sortOrder) ? "ptype" : "";
            ViewBag.pstatusSortParm = String.IsNullOrEmpty(sortOrder) ? "pstatus" : "";
            ViewBag.prod_idSortParm = String.IsNullOrEmpty(sortOrder) ? "prod_id" : "";


            int pageSize = 5;
            int pageNumber = (page ?? 1);

            List<Products> product = _db.Products.ToList();
            //ViewBag.getptype = product;
            List<Typeproduct> ptype = _db.Typeproduct.ToList();
            ViewBag.getptype = ptype;
            List<Warehouse> wcode = _db.Warehouse.ToList();
            ViewBag.getwcode = wcode;
            List<Groupproduct> pgroup = _db.Groupproduct.ToList();
            ViewBag.getpgroup = pgroup;
            List<Unit> unit = _db.Unit.ToList();
            ViewBag.getunit = unit;

            switch (sortOrder)
            {
                case "pcode":
                    product = _db.Products.OrderBy(s => s.pcode).ToList();
                    break;
                case "pname1":
                    product = _db.Products.OrderBy(s => s.pname1).ToList();
                    break;
                case "pname11":
                    product = _db.Products.OrderBy(s => s.pname11).ToList();
                    break;
                case "ptype":
                    product = _db.Products.OrderBy(s => s.ptype).ToList();
                    break;
                case "pstatus":
                    product = _db.Products.OrderBy(s => s.pstatus).ToList();
                    break;
                case "prod_id":
                    product = _db.Products.OrderBy(s => s.prod_id).ToList();
                    break;
                default:
                    product = product.OrderByDescending(s => s.prod_id).ToList();
                    break;
            }
            ViewBag.MyData = product.ToPagedList(pageNumber, pageSize);
            ViewBag.sortOrder = sortOrder;
            return View();
        }

        public ActionResult GetTableFindItem(int id)
        {
            var item = _db.Products.Where(p => p.prod_id == id).FirstOrDefault();
            //if (item.stduid != null)
            //{
            //    _db = new QSoft_WUEntities();
            //    item = (from data in _db.Products
            //            join d in _db.Unit on data.stduid  equals d.uid
            //            select new ProductView
            //            {
            //                prod_id = data.prod_id,
            //                pcode = data.pcode,
            //                pname1 = data.pname1,
            //                pname11 = data.pname11,
            //                pname2 = data.pname2,
            //                pname21 = data.pname21,
            //                ptype = data.ptype,
            //                pqty = data.pqty,
            //                pbook = data.pbook,
            //                pcost = data.pcost,
            //                grpcode = data.grpcode,
            //                wcode = data.wcode,
            //                pstatus = data.pstatus,
            //                psvat = data.psvat,
            //                ppvat = data.ppvat,
            //                pcst = data.pcst,
            //                prpt = data.prpt,
            //                ctype = data.ctype,
            //                stduid = data.stduid,
            //                buid = data.buid,
            //                suid = data.suid,
            //                stuid = data.stuid,
            //                stbuid = data.stbuid,
            //                stsuid = data.stsuid,
            //                bnum = data.bnum,
            //                snum = data.snum,
            //                stnum = data.stnum,
            //                stbnum = data.stbnum,
            //                stsnum = data.stsnum,
            //                pinactive = data.pinactive,
            //                barcodeid = data.barcodeid,
            //                dayupSent = data.dayupSent,
            //                st2uid = data.st2uid,
            //                st2num = data.st2num,

            //                u0s = data.u0s,
            //                u1s = data.u1s,
            //                u2s = data.u2s,
            //                u3s = data.u3s,
            //                u4s = data.u4s,
            //                s1 = data.s1,
            //                s2 = data.s2,
            //                s3 = data.s3,
            //                s4 = data.s4,
            //                s5 = data.s5,
            //                s6 = data.s6,
            //                ss1 = data.ss1,
            //                ss2 = data.ss2,
            //                ss3 = data.ss3,
            //                ss4 = data.ss4,
            //                stddiscount = data.stddiscount,
            //                xprice = data.xprice,
            //                xname = data.xname,
            //                a1 = data.a1,
            //                stuid = data.stuid,
            //                stbuid = data.stbuid,
            //                stsuid = data.stsuid,
            //                bnum = data.bnum,
            //                snum = data.snum,
            //                stnum = data.stnum,
            //                stbnum = data.stbnum,
            //                stsnum = data.stsnum,
            //                pinactive = data.pinactive,
            //                barcodeid = data.barcodeid,
            //                dayupSent = data.dayupSent,
            //                st2uid = data.st2uid,
            //                st2num = data.st2num,



            //                uname1 = d.uname1,

            //            }).Where(ProductView => ProductView.prod_id == id).FirstOrDefault();
            //}
            //else { }
            return Json(item, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveProduct(Models.Product_ICModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.prod_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Products code = _db.Products.Where(p => p.pcode == data.pcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Products.Add(new DAL.Products
                        {
                            pcode = data.pcode,
                            pname1 = data.pname1,
                            pname11 = data.pname11,
                            pname2 = data.pname2,
                            pname21 = data.pname21,
                            ptype = data.ptype,
                            pqty = data.pqty,
                            pbook = data.pbook,
                            pcost = data.pcost,
                            grpcode = data.grpcode,
                            wcode = data.wcode,
                            pstatus = data.pstatus,
                            pinactive = data.pinactive,
                            psvat = data.psvat,
                            ppvat = data.ppvat,
                            pcst = data.pcst,
                            prpt = data.prpt,
                            ctype = data.ctype,
                            stduid = data.stduid,
                            buid = data.buid,
                            suid = data.suid,
                            stuid = data.stuid,
                            stbuid = data.stbuid,
                            stsuid = data.stsuid,
                            bnum = data.bnum,
                            snum = data.snum,
                            stnum = data.stnum,
                            stbnum = data.stbnum,
                            stsnum = data.stsnum,
                            u0s = data.u0s,
                            u1s = data.u1s,
                            u2s = data.u2s,
                            u3s = data.u3s,
                            u4s = data.u4s,
                            s1 = data.s1,
                            s2 = data.s2,
                            s3 = data.s3,
                            s4 = data.s4,
                            s5 = data.s5,
                            s6 = data.s6,
                            ss1 = data.ss1,
                            ss2 = data.ss2,
                            ss3 = data.ss3,
                            ss4 = data.ss4,
                            stddiscount = data.stddiscount,
                            xprice = data.xprice,
                            xname = data.xname,
                            a1 = data.a1,
                            a2 = data.a2,
                            a3 = data.a3,
                            a4 = data.a4,
                            a5 = data.a5,
                            b1 = data.b1,
                            b2 = data.b2,
                            b3 = data.b3,
                            b4 = data.b4,
                            b5 = data.b5,
                            c1 = data.c1,
                            c2 = data.c2,
                            c3 = data.c3,
                            c4 = data.c4,
                            c5 = data.c5,
                            d1 = data.d1,
                            d2 = data.d2,
                            d3 = data.d3,
                            d4 = data.d4,
                            d5 = data.d5,
                            note1 = data.note1,
                            note2 = data.note2,
                            note3 = data.note3,
                            note4 = data.note4,
                            note5 = data.note5,
                            note6 = data.note6,
                            note7 = data.note7,
                            note8 = data.note8,
                            note9 = data.note9,
                            note10 = data.note10,
                            imgpath = data.imgpath,
                            ccode = data.ccode,
                            mstatus = data.mstatus,
                            ltsale = data.ltsale,
                            ltsend = data.ltsend,
                            barcodeid = data.barcodeid,
                            AmountSet = data.AmountSet,
                            file_img = data.file_img,
                            file_type = data.file_type,
                            dayupSent = data.dayupSent,
                            moq = data.moq,
                            st2uid = data.st2uid,
                            st2num = data.st2num,
                            LotSerialExpireFlag = data.LotSerialExpireFlag,
                            grpcode2 = data.grpcode2,
                            grpcode3 = data.grpcode3,
                            grpcode4 = data.grpcode4,
                            grpcode5 = data.grpcode5
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.prod_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Products code = _db.Products.Where(p => p.pcode == data.pcode && p.prod_id != data.prod_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Products edit = _db.Products.Where(p => p.prod_id == data.prod_id).FirstOrDefault();

                        edit.pcode = data.pcode;
                        edit.pname1 = data.pname1;
                        edit.pname11 = data.pname11;
                        edit.pname2 = data.pname2;
                        edit.pname21 = data.pname21;
                        edit.ptype = data.ptype;
                        edit.pqty = data.pqty;
                        edit.pbook = data.pbook;
                        edit.pcost = data.pcost;
                        edit.grpcode = data.grpcode;
                        edit.wcode = data.wcode;
                        edit.pstatus = data.pstatus;
                        edit.pinactive = data.pinactive;
                        edit.psvat = data.psvat;
                        edit.ppvat = data.ppvat;
                        edit.pcst = data.pcst;
                        edit.prpt = data.prpt;
                        edit.ctype = data.ctype;
                        edit.stduid = data.stduid;
                        edit.buid = data.buid;
                        edit.suid = data.suid;
                        edit.stuid = data.stuid;
                        edit.stbuid = data.stbuid;
                        edit.stsuid = data.stsuid;
                        edit.bnum = data.bnum;
                        edit.snum = data.snum;
                        edit.stnum = data.stnum;
                        edit.stbnum = data.stbnum;
                        edit.stsnum = data.stsnum;
                        edit.u0s = data.u0s;
                        edit.u1s = data.u1s;
                        edit.u2s = data.u2s;
                        edit.u3s = data.u3s;
                        edit.u4s = data.u4s;
                        edit.s1 = data.s1;
                        edit.s2 = data.s2;
                        edit.s3 = data.s3;
                        edit.s4 = data.s4;
                        edit.s5 = data.s5;
                        edit.s6 = data.s6;
                        edit.ss1 = data.ss1;
                        edit.ss2 = data.ss2;
                        edit.ss3 = data.ss3;
                        edit.ss4 = data.ss4;
                        edit.stddiscount = data.stddiscount;
                        edit.xprice = data.xprice;
                        edit.xname = data.xname;
                        edit.a1 = data.a1;
                        edit.a2 = data.a2;
                        edit.a3 = data.a3;
                        edit.a4 = data.a4;
                        edit.a5 = data.a5;
                        edit.b1 = data.b1;
                        edit.b2 = data.b2;
                        edit.b3 = data.b3;
                        edit.b4 = data.b4;
                        edit.b5 = data.b5;
                        edit.c1 = data.c1;
                        edit.c2 = data.c2;
                        edit.c3 = data.c3;
                        edit.c4 = data.c4;
                        edit.c5 = data.c5;
                        edit.d1 = data.d1;
                        edit.d2 = data.d2;
                        edit.d3 = data.d3;
                        edit.d4 = data.d4;
                        edit.d5 = data.d5;
                        edit.note1 = data.note1;
                        edit.note2 = data.note2;
                        edit.note3 = data.note3;
                        edit.note4 = data.note4;
                        edit.note5 = data.note5;
                        edit.note6 = data.note6;
                        edit.note7 = data.note7;
                        edit.note8 = data.note8;
                        edit.note9 = data.note9;
                        edit.note10 = data.note10;
                        edit.imgpath = data.imgpath;
                        edit.ccode = data.ccode;
                        edit.mstatus = data.mstatus;
                        edit.ltsale = data.ltsale;
                        edit.ltsend = data.ltsend;
                        edit.barcodeid = data.barcodeid;
                        edit.AmountSet = data.AmountSet;
                        edit.file_img = data.file_img;
                        edit.file_type = data.file_type;
                        edit.dayupSent = data.dayupSent;
                        edit.moq = data.moq;
                        edit.st2uid = data.st2uid;
                        edit.st2num = data.st2num;
                        edit.LotSerialExpireFlag = data.LotSerialExpireFlag;
                        edit.grpcode2 = data.grpcode2;
                        edit.grpcode3 = data.grpcode3;
                        edit.grpcode4 = data.grpcode4;
                        edit.grpcode5 = data.grpcode5;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        public ActionResult FinditemPopupSup(int id)
        {
            var unit = _db.Unit.Where(p => p.uid == id).FirstOrDefault();
            return Json(unit, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]

        public ActionResult DeleteProducts(int? p_id)
        {
            if (p_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Products delete = _db.Products.Where(p => p.prod_id == p_id).FirstOrDefault();

                _db.Products.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


    }
}