using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{
    public class BrachController : Controller
    {
     
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        
        public ActionResult ManageBrach(int? page)
        {
            List<Branch> branch = _db.Branch.ToList();
            ViewBag.MyData = branch;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = branch.ToPagedList(pageNumber, pageSize);

            return View();
        }

        [HttpPost]

        public ActionResult SaveBrach(Models.BrachModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.b_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Branch code = _db.Branch.Where(p => p.bcode == data.bcode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Branch.Add(new DAL.Branch
                        {
                            bcode = data.bcode,
                            bname1 = data.bname1,
                            bname12 = data.bname12,
                            bname2 = data.bname2,
                            bname22 = data.bname22,
                            baddress1 = data.baddress1,
                            baddress2 = data.baddress2,
                            bzip = data.bzip,
                            btel = data.btel,
                            bfax = data.bfax,
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
                if (data.b_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Branch code = _db.Branch.Where(p => p.bcode == data.bcode && p.b_id != data.b_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Branch edit = _db.Branch.Where(p => p.b_id == data.b_id).FirstOrDefault();
                        edit.bcode = data.bcode;
                        edit.bname1 = data.bname1;
                        edit.bname12 = data.bname12;
                        edit.bname2 = data.bname2;
                        edit.bname22 = data.bname22;
                        edit.baddress1 = data.baddress1;
                        edit.baddress2 = data.baddress2;
                        edit.bzip = data.bzip;
                        edit.btel = data.btel;
                        edit.bfax = data.bfax;
                        edit.ccode = data.ccode;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteBrach(int b_id)
        {
            if (b_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Branch delete = _db.Branch.Where(p => p.b_id == b_id).FirstOrDefault();

                _db.Branch.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableBrach(int id)
        {
            var Branch = _db.Branch.Where(p => p.b_id == id).FirstOrDefault();
            return Json(Branch, JsonRequestBehavior.AllowGet);
        }

    }
}
