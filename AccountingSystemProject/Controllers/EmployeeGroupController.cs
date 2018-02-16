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
    public class EmployeeGroupController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: EmployeeGroup
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageEmployeeGroup(int? page)
        {
            List<MDEmGroup> employeegroup = _db.MDEmGroup.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = employeegroup.ToPagedList(pageNumber, pageSize);
            return View();
        }
        [HttpPost]

        public ActionResult SaveEmployeeGroup(Models.EmployeeGroupModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.EmGroupID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDEmGroup code = _db.MDEmGroup.Where(p => p.EmCode == data.EmCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDEmGroup.Add(new DAL.MDEmGroup
                        {
                            EmCode = data.EmCode,
                            EmGroupName = data.EmGroupName,
                            EmGroupNameEng = data.EmGroupNameEng,
                            EmGroupNote = data.EmGroupNote,
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
                if (data.EmGroupID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDEmGroup code = _db.MDEmGroup.Where(p => p.EmCode == data.EmCode && p.EmGroupID != data.EmGroupID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDEmGroup edit = _db.MDEmGroup.Where(p => p.EmGroupID == data.EmGroupID).FirstOrDefault();
                        edit.EmCode = data.EmCode;
                        edit.EmGroupName = data.EmGroupName;
                        edit.EmGroupNameEng = data.EmGroupNameEng;
                        edit.EmGroupNote = data.EmGroupNote;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteEmployeeGroup(int EmGroupID)
        {
            if (EmGroupID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDEmGroup delete = _db.MDEmGroup.Where(p => p.EmGroupID == EmGroupID).FirstOrDefault();

                _db.MDEmGroup.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableEmployeeGroup(int id)
        {
            var employeegroup = _db.MDEmGroup.Where(p => p.EmGroupID == id).FirstOrDefault();
            return Json(employeegroup, JsonRequestBehavior.AllowGet);
        }

    }
}