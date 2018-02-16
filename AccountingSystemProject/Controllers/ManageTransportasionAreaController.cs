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
    public class ManageTransportasionAreaController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageTransportasionArea
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageTransportasionArea(int? page, string sortOrder)
        {
            ViewBag.TranspAreaCode = String.IsNullOrEmpty(sortOrder) ? "TranspAreaCode" : "";
            ViewBag.TranspAreaName = String.IsNullOrEmpty(sortOrder) ? "TranspAreaName" : "";
            ViewBag.TranspAreaNameEng = String.IsNullOrEmpty(sortOrder) ? "TranspAreaNameEng" : "";

            List <MDTranspArea> TranspArea = _db.MDTranspArea.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "TranspAreaCode":
                    TranspArea = _db.MDTranspArea.OrderBy(s => s.TranspAreaCode).ToList();
                    break;
                case "TranspAreaName":
                    TranspArea = _db.MDTranspArea.OrderBy(s => s.TranspAreaName).ToList();
                    break;
                case "TranspAreaNameEng":
                    TranspArea = _db.MDTranspArea.OrderBy(s => s.TranspAreaNameEng).ToList();
                    break;
                default:
                    TranspArea = _db.MDTranspArea.OrderByDescending(s => s.TranspAreaID).ToList();
                    break;
            }
            ViewBag.MyData = TranspArea.ToPagedList(pageNumber, pageSize);
            ViewBag.sortOrder = sortOrder;
            return View();
        }

        [HttpPost]

        public ActionResult SaveTranspArea(Models.TransportasionAreaModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.TranspAreaID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDTranspArea code = _db.MDTranspArea.Where(p => p.TranspAreaCode == data.TranspAreaCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDTranspArea.Add(new DAL.MDTranspArea
                        {
                            TranspAreaCode = data.TranspAreaCode,
                            TranspAreaName = data.TranspAreaName,
                            TranspAreaNameEng = data.TranspAreaNameEng,
                            Remark = data.Remark,
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
                if (data.TranspAreaID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDTranspArea code = _db.MDTranspArea.Where(p => p.TranspAreaCode == data.TranspAreaCode && p.TranspAreaID != data.TranspAreaID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDTranspArea edit = _db.MDTranspArea.Where(p => p.TranspAreaID == data.TranspAreaID).FirstOrDefault();
                        edit.TranspAreaCode = data.TranspAreaCode;
                        edit.TranspAreaName = data.TranspAreaName;
                        edit.TranspAreaNameEng = data.TranspAreaNameEng;
                        edit.Remark = data.Remark;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteTranspArea(int TranspAreaID)
        {
            if (TranspAreaID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDTranspArea delete = _db.MDTranspArea.Where(p => p.TranspAreaID == TranspAreaID).FirstOrDefault();

                _db.MDTranspArea.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableTranspArea(int id)
        {
            var TranspArea = _db.MDTranspArea.Where(p => p.TranspAreaID == id).FirstOrDefault();
            return Json(TranspArea, JsonRequestBehavior.AllowGet);
        }


    }
}