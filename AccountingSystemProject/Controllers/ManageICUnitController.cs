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
    public class ManageICUnitController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageUnit
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageICUnit(int? page, string sortOrder)
        {
            ViewBag.ucode = String.IsNullOrEmpty(sortOrder) ? "ucode" : "";
            ViewBag.uname1 = String.IsNullOrEmpty(sortOrder) ? "uname1" : "";
            ViewBag.uname2 = String.IsNullOrEmpty(sortOrder) ? "uname2" : "";

            List<Unit> unit = _db.Unit.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "ucode":
                    unit = _db.Unit.OrderBy(s => s.ucode).ToList();
                    break;
                case "uname1":
                    unit = _db.Unit.OrderBy(s => s.uname1).ToList();
                    break;
                case "uname2":
                    unit = _db.Unit.OrderBy(s => s.uname2).ToList();
                    break;
                default:
                    unit = _db.Unit.OrderByDescending(s => s.uid).ToList();
                    break;
            }
            ViewBag.MyData = unit.ToPagedList(pageNumber, pageSize);
            ViewBag.sortOrder = sortOrder;
            return View();
        }

        [HttpPost]

        public ActionResult SaveUnit(Models.UnitModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.uid == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Unit code = _db.Unit.Where(p => p.ucode == data.ucode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Unit.Add(new DAL.Unit
                        {
                            ucode = data.ucode,
                            uname1 = data.uname1,
                            uname2 = data.uname2,
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
                if (data.uid != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Unit code = _db.Unit.Where(p => p.ucode == data.ucode && p.uid != data.uid).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Unit edit = _db.Unit.Where(p => p.uid == data.uid).FirstOrDefault();
                        edit.ucode = data.ucode;
                        edit.uname1 = data.uname1;
                        edit.uname2 = data.uname2;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteUnit(int uid)
        {
            if (uid != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Unit delete = _db.Unit.Where(p => p.uid == uid).FirstOrDefault();

                _db.Unit.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableUnit(int id)
        {
            var unit = _db.Unit.Where(p => p.uid == id).FirstOrDefault();
            return Json(unit, JsonRequestBehavior.AllowGet);
        }

    }
}