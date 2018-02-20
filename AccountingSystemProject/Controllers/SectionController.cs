using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class SectionController : Controller
    {
        // GET: Section
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageSection(int? page)
        {
            List<Section> section = _db.Section.ToList();
            List<Depart> depart = _db.Depart.ToList();
            ViewBag.section = section;
            ViewBag.depart = depart;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.section = section.ToPagedList(pageNumber, pageSize);

            return View();
        }

        [HttpPost]

        public ActionResult SaveSection(Models.SectionModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.sec_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Section code = _db.Section.Where(p => p.secode == data.secode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Section.Add(new DAL.Section
                        {
                            secode = data.secode,
                            sename1 = data.sename1,
                            sename2 = data.sename2,
                            ccode = data.ccode,
                            dcode = data.dcode
                           
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.sec_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Section code = _db.Section.Where(p => p.secode == data.secode && p.sec_id != data.sec_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Section edit = _db.Section.Where(p => p.sec_id == data.sec_id).FirstOrDefault();
                        edit.secode = data.secode;
                        edit.sename1 = data.sename1;
                        edit.sename2 = data.sename2;
                        edit.ccode = data.ccode;
                        edit.dcode = data.dcode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteSection(int sec_id)
        {
            if (sec_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Section delete = _db.Section.Where(p => p.sec_id == sec_id).FirstOrDefault();

                _db.Section.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableSection(int id)
        {
            var section = _db.Section.Where(p => p.sec_id == id).FirstOrDefault();
            return Json(section, JsonRequestBehavior.AllowGet);
        }
    }
}