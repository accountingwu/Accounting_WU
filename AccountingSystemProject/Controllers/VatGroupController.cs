using AccountingSystemProject.DAL;
using AccountingSystemProject.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class VatGroupController : Controller
    {
        // GET: VatGroup
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        public ActionResult ManageVATGroup(int? page)
        {
            var Acc = (from c in _db.MDAcc
                       select new AccViw
                       {
                           AccID = c.AccID,
                           AccCode = c.AccCode,
                           AccName = c.AccName,
                           AccNameEng = c.AccNameEng,
                       }).ToList();
            List<MDVATGroup> Vat = _db.MDVATGroup.ToList();
            ViewBag.MyData = Vat;
            ViewBag.MyData1 = Acc;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = Vat.ToPagedList(pageNumber, pageSize);

            return View();
        }
        public ActionResult Save(Models.VATGroupModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.VATGroupID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDVATGroup code = _db.MDVATGroup.Where(p => p.VATGroupCode == data.VATGroupCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDVATGroup.Add(new DAL.MDVATGroup
                        {
                            VATGroupID = data.VATGroupID,
                            VATGroupCode = data.VATGroupCode,
                            AccCode = data.AccCode,
                            VatRate = data.VatRate,
                            VatType = data.VatType, 
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
                if (data.VATGroupID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDVATGroup code = _db.MDVATGroup.Where(p => p.VATGroupCode == data.VATGroupCode && p.VATGroupID != data.VATGroupID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDVATGroup edit = _db.MDVATGroup.Where(p => p.VATGroupID == data.VATGroupID).FirstOrDefault();

                        edit.VATGroupID = data.VATGroupID;
                        edit.VATGroupCode = data.VATGroupCode;
                        edit.AccCode = data.AccCode;
                        edit.VatRate = data.VatRate;
                        edit.VatType = data.VatType;
                            
                        edit.ccode = data.ccode;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }
        public ActionResult FinditemPopupSup(int id)
        {
            var Acc = _db.MDAcc.Where(p => p.AccID == id).FirstOrDefault();
            return Json(Acc, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowTableVat(int id)
        {
            _db = new QSoft_WUEntities();
            var Sup = (from data in _db.MDVATGroup
                       join d in _db.MDAcc on data.AccCode equals d.AccCode
                       select new Vatview
                       {

                           AccCode = d.AccCode,
                           AccName = d.AccName,
                           VATGroupID = data.VATGroupID,
                           VATGroupCode = data.VATGroupCode,
                           VatRate = data.VatRate,
                           VatType = data.VatType,
                           ccode = data.ccode

                       }).Where(Vatview => Vatview.VATGroupID == id).FirstOrDefault();
            return Json(Sup, JsonRequestBehavior.AllowGet);

        }


        public ActionResult DeleteVat(int VATGroupID)
        {
            if (VATGroupID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDVATGroup delete = _db.MDVATGroup.Where(p => p.VATGroupID == VATGroupID).FirstOrDefault();

                _db.MDVATGroup.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}