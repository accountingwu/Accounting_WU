using AccountingSystemProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountingSystemProject.Models;
using System.Web.Mvc;
using PagedList;

namespace AccountingSystemProject.Controllers
{
    public class ExpnController : Controller
    {
        // GET: Expn //รหัสรายได้
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageExpn(int? page)
        {
            _db = new QSoft_WUEntities();

            var Acc = (from c in _db.MDAcc 
                       join d in _db.MDAccType on c.AccTypeID equals d.AccTypeID
                       select new AccViw
                       {
                           AccID = c.AccID,
                           AccCode = c.AccCode,
                           AccName = c.AccName,
                           AccNameEng = c.AccNameEng,
                           AccTypeName = d.AccTypeName
                       }).ToList();

            var Expn = (from c in _db.MDExpn
                        where c.ExpnType == "1"
                        join d in _db.MDAcc on c.AccID equals d.AccID
                       select new Expnview
                       {
                           AccID = d.AccID,
                           AccCode = d.AccCode,
                           AccName = d.AccName,
                           ExpnID = c.ExpnID,
                           ExpnCode = c.ExpnCode,
                           ExpnName = c.ExpnName,
                           ExpnNameEng = c.ExpnNameEng,
                           Remark = c.Remark
                       }).ToList();
            ViewBag.MyData = Expn;
            ViewBag.MyData1 = Acc;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = Expn.ToPagedList(pageNumber, pageSize);
            return View();
        }
    

        [HttpPost]

        public ActionResult SaveExpn(Models.ExpnModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.ExpnID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDExpn code = _db.MDExpn.Where(p => p.ExpnCode == data.ExpnCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDExpn.Add(new DAL.MDExpn
                        {
                            ExpnCode = data.ExpnCode,
                            ExpnName = data.ExpnName,
                            ExpnNameEng = data.ExpnNameEng,
                            Remark = data.Remark,
                            ExpnType = data.ExpnType,
                            AccID = data.AccID,
                            ccode = data.ccode
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.ExpnID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDExpn code = _db.MDExpn.Where(p => p.ExpnCode == data.ExpnCode && p.ExpnID != data.ExpnID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDExpn edit = _db.MDExpn.Where(p => p.ExpnID == data.ExpnID).FirstOrDefault();
                        edit.ExpnCode = data.ExpnCode;
                        edit.ExpnName = data.ExpnName;
                        edit.ExpnNameEng = data.ExpnNameEng;
                        edit.ccode = data.ccode;
                        edit.ExpnType = data.ExpnType;
                        edit.AccID = data.AccID;
                        edit.Remark = data.Remark;


                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteExpn(int ExpnID)
        {
            if (ExpnID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDExpn delete = _db.MDExpn.Where(p => p.ExpnID == ExpnID).FirstOrDefault();

                _db.MDExpn.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableExpn(int id)
        {
            _db = new QSoft_WUEntities();
            var Expn = (from c in _db.MDExpn
                        join d in _db.MDAcc on c.AccID equals d.AccID
                        select new Expnview
                        {
                            AccID = d.AccID,
                            AccCode = d.AccCode,
                            AccName = d.AccName,
                            ExpnID = c.ExpnID,
                            ExpnCode = c.ExpnCode,
                            ExpnName = c.ExpnName,
                            ExpnType = c.ExpnType,
                            ExpnNameEng = c.ExpnNameEng,
                            Remark = c.Remark
                        }).Where(Expnview => Expnview.ExpnID == id).FirstOrDefault();
            return Json(Expn, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FinditemPopupExp(int id)
        {
            var Acc = _db.MDAcc.Where(p => p.AccID == id).FirstOrDefault();
            return Json(Acc, JsonRequestBehavior.AllowGet);
        }

    }
}