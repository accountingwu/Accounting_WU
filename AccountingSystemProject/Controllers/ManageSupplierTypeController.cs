using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class ManageSupplierTypeController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageSupplierType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageSupplierType(int? page)
        {
            List<MDSupplierType> supType = _db.MDSupplierType.ToList();
            ViewBag.MyData = supType;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = supType.ToPagedList(pageNumber, pageSize);
            return View();
        }
        public ActionResult SaveSupplierType(Models.SupplierTypeModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.SupplierTypeID == 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDSupplierType code = _db.MDSupplierType.Where(p => p.SupplierTypeCode == data.SupplierTypeCode && p.SupplierTypeID != data.SupplierTypeID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDSupplierType.Add(new DAL.MDSupplierType
                        {
                            SupplierTypeID = data.SupplierTypeID,
                            SupplierTypeCode = data.SupplierTypeCode,
                            SupplierTypeName = data.SupplierTypeName,
                            SupplierTypeENG = data.SupplierTypeENG,
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
                if (data.SupplierTypeID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDSupplierType code = _db.MDSupplierType.Where(p => p.SupplierTypeCode == data.SupplierTypeCode && p.SupplierTypeID != data.SupplierTypeID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        //System.Web.HttpContext.Current.Application.Lock();

                        DAL.MDSupplierType edit = _db.MDSupplierType.Where(p => p.SupplierTypeID == data.SupplierTypeID).FirstOrDefault();

                        edit.SupplierTypeID = data.SupplierTypeID;
                        edit.SupplierTypeCode = data.SupplierTypeCode;
                        edit.SupplierTypeName = data.SupplierTypeName;
                        edit.SupplierTypeENG = data.SupplierTypeENG;
                        edit.ccode = data.ccode;
                        //edit.Remark = data.Remark;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }
        public ActionResult ShowTableGroupSupplier(int id)
        {
            var Brach = _db.MDSupplierType.Where(p => p.SupplierTypeID == id).FirstOrDefault();
            return Json(Brach, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DeleteSupplierType(int SupplierTypeID)
        {
            if (SupplierTypeID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDSupplierType delete = _db.MDSupplierType.Where(p => p.SupplierTypeID == SupplierTypeID).FirstOrDefault();

                _db.MDSupplierType.Remove(delete);
                _db.SaveChanges();

                //_db.Entry(edit).State = EntityState.Modified;
                //_db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}