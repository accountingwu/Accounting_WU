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
    public class ManageBusinessTypeController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageBusinessType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageBusinessType(int? page)
        {
            List<MDBusiType> BusinessType = _db.MDBusiType.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = BusinessType.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]

        public ActionResult SaveBusinessType(Models.BusiType data)
        {


            if (!ModelState.IsValid)
            {
                if (data.BusiTypeID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDBusiType code = _db.MDBusiType.Where(p => p.BusiTypeCode == data.BusiTypeCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDBusiType.Add(new DAL.MDBusiType
                        {
                            BusiTypeCode = data.BusiTypeCode,
                            BusiTypeName = data.BusiTypeName,
                            BusiTypeNameEng = data.BusiTypeNameEng,
                            Remark = data.Remark
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.BusiTypeID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDBusiType code = _db.MDBusiType.Where(p => p.BusiTypeCode == data.BusiTypeCode && p.BusiTypeID != data.BusiTypeID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDBusiType edit = _db.MDBusiType.Where(p => p.BusiTypeID == data.BusiTypeID).FirstOrDefault();
                        edit.BusiTypeCode = data.BusiTypeCode;
                        edit.BusiTypeName = data.BusiTypeName;
                        edit.BusiTypeNameEng = data.BusiTypeNameEng;
                        edit.Remark = data.Remark;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteBusinessType(int BusiTypeID)
        {
            if (BusiTypeID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDBusiType delete = _db.MDBusiType.Where(p => p.BusiTypeID == BusiTypeID).FirstOrDefault();

                _db.MDBusiType.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableBinessType(int id)
        {
            var BusinessType = _db.MDBusiType.Where(p => p.BusiTypeID == id).FirstOrDefault();
            return Json(BusinessType, JsonRequestBehavior.AllowGet);
        }
    }
}