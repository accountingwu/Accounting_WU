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
    public class ManageICProductGroupController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageICProductGroup
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ManageICProductGroup(int? page, string sortOrder)
        {
            ViewBag.grpcodeSortParm = String.IsNullOrEmpty(sortOrder) ? "grpcode" : "";
            ViewBag.grpname1SortParm = String.IsNullOrEmpty(sortOrder) ? "grpname1" : "";
            ViewBag.grpname2SortParm = String.IsNullOrEmpty(sortOrder) ? "grpname2" : "";

            List<Groupproduct> groupproduct = _db.Groupproduct.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "grpcode":
                    groupproduct = _db.Groupproduct.OrderBy(s => s.grpcode).ToList();
                    break;
                case "grpname1":
                    groupproduct = _db.Groupproduct.OrderBy(s => s.grpname1).ToList();
                    break;
                case "grpname2":
                    groupproduct = _db.Groupproduct.OrderBy(s => s.grpname2).ToList();
                    break;               
                default:
                    groupproduct = groupproduct.OrderByDescending(s => s.bciid).ToList();
                    break;
            }
            ViewBag.MyData = groupproduct.ToPagedList(pageNumber, pageSize);
            ViewBag.sortOrder = sortOrder;
            return View();
        }
        [HttpPost]

        public ActionResult SaveProductGroup(Models.GroupProductModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.bciid == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Groupproduct code = _db.Groupproduct.Where(p => p.grpcode == data.grpcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Groupproduct.Add(new DAL.Groupproduct
                        {
                            grpcode = data.grpcode,
                            grpname1 = data.grpname1,
                            grpname2 = data.grpname2,
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
                if (data.bciid != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Groupproduct code = _db.Groupproduct.Where(p => p.grpcode == data.grpcode && p.bciid != data.bciid).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Groupproduct edit = _db.Groupproduct.Where(p => p.bciid == data.bciid).FirstOrDefault();
                        edit.grpcode = data.grpcode;
                        edit.grpname1 = data.grpname1;
                        edit.grpname2 = data.grpname2;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteProductGroup(int bciid)
        {
            if (bciid != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Groupproduct delete = _db.Groupproduct.Where(p => p.bciid == bciid).FirstOrDefault();

                _db.Groupproduct.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableProductGroup(int id)
        {
            var productgroup = _db.Groupproduct.Where(p => p.bciid == id).FirstOrDefault();
            return Json(productgroup, JsonRequestBehavior.AllowGet);
        }
    }
}