using AccountingSystemProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountingSystemProject.Models;
using System.Web.Mvc;
using PagedList;
using static AccountingSystemProject.Models.ReceivePlaceModel;

namespace AccountingSystemProject.Controllers
{
    public class ReceivePlaceController : Controller
    {
        // GET: Expn //รหัสรายได้
        public QSoft_WUEntities _db = new QSoft_WUEntities();

        
        public ActionResult ManageReceivePlace(int? page)
        {
            _db = new QSoft_WUEntities();

            var Emm = (from c in _db.Employee 
                       select new EmpView
                       {
                           eid = c.eid,
                           ecode = c.ecode,
                           ename1 = c.ename1
                       }).ToList();

            var Expn = (from c in _db.MDReceivePlace
                     
                        join d in _db.Employee on c.Contact equals d.ecode
                       select new EmployeeView
                       {
                           DropShipID = c.DropShipID,
                           DropShipCode = c.DropShipCode,
                           DropShipName = c.DropShipName,
                           Contact = c.Contact,
                           ecode = d.ecode,
                           ename1 = d.ename1

                       }).ToList();
            ViewBag.MyData = Expn;
            ViewBag.MyData1 = Emm;
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = Expn.ToPagedList(pageNumber, pageSize);
            return View();
        }
    

        [HttpPost]

        public ActionResult SaveExpn(Models.ReceivePlaceModel data)
        {


            if (!ModelState.IsValid)
            {
                if (data.DropShipID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDReceivePlace code = _db.MDReceivePlace.Where(p => p.DropShipCode == data.DropShipCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDReceivePlace.Add(new DAL.MDReceivePlace
                        {
                            DropShipID = data.DropShipID,
                            DropShipCode = data.DropShipCode,
                            DropShipName = data.DropShipName,
                            Remark = data.Remark,
                            Addr = data.Addr,
                            District = data.District,
                            Amphur = data.Amphur,
                            Province = data.Province,
                            PostCode = data.PostCode,
                            Tel = data.Tel,
                            Fax = data.Fax,
                            Contact = data.Contact,
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
                if (data.DropShipID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDReceivePlace code = _db.MDReceivePlace.Where(p => p.DropShipCode == data.DropShipCode && p.DropShipID != data.DropShipID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDReceivePlace edit = _db.MDReceivePlace.Where(p => p.DropShipID == data.DropShipID).FirstOrDefault();
                        edit.DropShipID = data.DropShipID;
                            edit.DropShipCode = data.DropShipCode;
                        edit.DropShipName = data.DropShipName;
                        edit.Remark = data.Remark;
                        edit.Addr = data.Addr;
                        edit.District = data.District;
                        edit.Amphur = data.Amphur;
                        edit.Province = data.Province;
                        edit.PostCode = data.PostCode;
                        edit.Tel = data.Tel;
                        edit.Fax = data.Fax;
                        edit.Contact = data.Contact;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        [HttpPost]

        public ActionResult DeleteExpn(int DropShipID)
        {
            if (DropShipID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDReceivePlace delete = _db.MDReceivePlace.Where(p => p.DropShipID == DropShipID).FirstOrDefault();

                _db.MDReceivePlace.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ShowTableExpn(int id)
        {
            _db = new QSoft_WUEntities();
            var Expn = (from c in _db.MDReceivePlace

                        join d in _db.Employee on c.Contact equals d.ecode
                        select new EmployeeView
                        {
                            DropShipID = c.DropShipID,
                            DropShipCode = c.DropShipCode,
                            DropShipName = c.DropShipName,
                            Contact = c.Contact,

                            Addr = c.Addr,
                            District = c.District,
                            Amphur = c.Amphur,
                            Province = c.Province,

                            PostCode = c.PostCode,
                            Tel = c.Tel,
                            Fax = c.Fax,
                            Remark = c.Remark,

                            ecode = d.ecode,
                            ename1 = d.ename1

                        }).Where(Expnview => Expnview.DropShipID == id).FirstOrDefault();
            return Json(Expn, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FinditemPopupExp(int id)
        {
            var Acc = _db.Employee.Where(p => p.eid == id).FirstOrDefault();
            return Json(Acc, JsonRequestBehavior.AllowGet);
        }

    }
}