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
    public class ManageCauseOfReductionDebtController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageCauseOfReductionDebt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageCauseOfReductionDebt(int? page)
        {
            List<MDCNRemarkType> CauseOfReductionDebt = _db.MDCNRemarkType.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = CauseOfReductionDebt.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]

        public ActionResult SaveCauseOfReductionDebt(Models.CauseOfReductionDebtModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.CNRemarkTypeID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDCNRemarkType code = _db.MDCNRemarkType.Where(p => p.CNRemarkTypeCode == data.CNRemarkTypeCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDCNRemarkType.Add(new DAL.MDCNRemarkType
                        {
                            CNRemarkTypeCode = data.CNRemarkTypeCode,
                            CNRemarkTypeName1 = data.CNRemarkTypeName1,
                            CNRemarkTypeName2 = data.CNRemarkTypeName2,
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
                if (data.CNRemarkTypeID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDCNRemarkType code = _db.MDCNRemarkType.Where(p => p.CNRemarkTypeCode == data.CNRemarkTypeCode && p.CNRemarkTypeID != data.CNRemarkTypeID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDCNRemarkType edit = _db.MDCNRemarkType.Where(p => p.CNRemarkTypeID == data.CNRemarkTypeID).FirstOrDefault();
                        edit.CNRemarkTypeCode = data.CNRemarkTypeCode;
                        edit.CNRemarkTypeName1 = data.CNRemarkTypeName1;
                        edit.CNRemarkTypeName2 = data.CNRemarkTypeName2;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteCauseOfReductionDebt(int CNRemarkTypeID)
        {
            if (CNRemarkTypeID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDCNRemarkType delete = _db.MDCNRemarkType.Where(p => p.CNRemarkTypeID == CNRemarkTypeID).FirstOrDefault();

                _db.MDCNRemarkType.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableCauseOfReductionDebt(int id)
        {
            var CauseOfReductionDebt = _db.MDCNRemarkType.Where(p => p.CNRemarkTypeID == id).FirstOrDefault();
            return Json(CauseOfReductionDebt, JsonRequestBehavior.AllowGet);
        }

    }
}
