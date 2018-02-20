using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class CompanyController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: Company
        public ActionResult ManageCompany(int? page)
        {
            List<Corp> com = _db.Corp.ToList();
            ViewBag.MyData = com;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = com.ToPagedList(pageNumber, pageSize);
            return View();
          
        }
        public ActionResult Save(Models.CompanyModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.corp_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Corp code = _db.Corp.Where(p => p.ccode == data.ccode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Corp.Add(new DAL.Corp
                        {
                            corp_id = data.corp_id,
                            ccode = data.ccode,
                            cname1 = data.cname1,
                            cname11 = data.cname11,
                            cname2 = data.cname2,
                            cname21 = data.cname21,
                            caddress1 = data.caddress1,
                            caddress2 = data.caddress2,
                            czip = data.czip,
                            ctel = data.ctel,
                            cfax = data.cfax,
                            taxid = data.taxid,
                            number1 = data.number1,
                            number2 = data.number2,
                            number3 = data.number3,
                            number4 = data.number4,
                            number5 = data.number5,
                            number6 = data.number6,
                            number7 = data.number7,
                            number8 = data.number8,
                            decimal1 = data.decimal1,
                            decimal2 = data.decimal2,
                            decimal3 = data.decimal3,
                            decimal4 = data.decimal4,
                            decimal5 = data.decimal5,
                            decimal6 = data.decimal6,
                            decimal7 = data.decimal7,
                            decimal8 = data.decimal8,
                            stockcount = data.stockcount
                            
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
           
                if (data.corp_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Corp code = _db.Corp.Where(p => p.ccode == data.ccode && p.corp_id != data.corp_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Corp edit = _db.Corp.Where(p => p.corp_id == data.corp_id).FirstOrDefault();

                        edit.corp_id = data.corp_id;
                        edit.ccode = data.ccode;
                        edit.cname1 = data.cname1;
                        edit.cname11 = data.cname11;
                        edit.cname2 = data.cname2;
                        edit.cname21 = data.cname21;
                        edit.caddress1 = data.caddress1;
                        edit.caddress2 = data.caddress2;
                        edit.czip = data.czip;
                        edit.ctel = data.ctel;
                        edit.cfax = data.cfax;
                        edit.taxid = data.taxid;
                        edit.number1 = data.number1;
                        edit.number2 = data.number2;
                        edit.number3 = data.number3;
                        edit.number4 = data.number4;
                        edit.number5 = data.number5;
                        edit.number6 = data.number6;
                        edit.number7 = data.number7;
                        edit.number8 = data.number8;
                        edit.decimal1 = data.decimal1;
                        edit.decimal2 = data.decimal2;
                        edit.decimal3 = data.decimal3;
                        edit.decimal4 = data.decimal4;
                        edit.decimal5 = data.decimal5;
                        edit.decimal6 = data.decimal6;
                        edit.decimal7 = data.decimal7;
                        edit.decimal8 = data.decimal8;
                        edit.stockcount = data.stockcount;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
           

            return View(data);
        }
        public ActionResult ShowTableCompany(int id)
        {
            var com = _db.Corp.Where(p => p.corp_id == id).FirstOrDefault();
            return Json(com, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteCompany(int corp_id)
        {
            if (corp_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Corp delete = _db.Corp.Where(p => p.corp_id == corp_id).FirstOrDefault();

                _db.Corp.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}