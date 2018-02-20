using AccountingSystemProject.DAL;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingSystemProject.Controllers
{

    public class BankBrachController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: BankBrach
        public ActionResult ManageBankBrach(int? page)
        {
            List<MDBankBrch> book = _db.MDBankBrch.ToList();


            ViewBag.MyData = book;

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = book.ToPagedList(pageNumber, pageSize);
            return View();
            
        }
        public ActionResult DeleteBankBrach(int BankBrchID)
        {
            if (BankBrchID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDBankBrch delete = _db.MDBankBrch.Where(p => p.BankBrchID == BankBrchID).FirstOrDefault();

                _db.MDBankBrch.Remove(delete);
                _db.SaveChanges();

                //_db.Entry(edit).State = EntityState.Modified;
                //_db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SaveBankBrach(Models.BankBrach data)
        {
            if (!ModelState.IsValid)
            {
                if (data.BankBrchID == 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDBankBrch code = _db.MDBankBrch.Where(p => p.BankBrchCode == data.BankBrchCode && p.BankBrchID != data.BankBrchID ).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDBankBrch.Add(new DAL.MDBankBrch
                        {
                            BankBrchID = data.BankBrchID,
                            BankBrchCode = data.BankBrchCode,
                            BankBrchName = data.BankBrchName,
                            BankBrchNameEng = data.BankBrchNameEng,
                            BankBrchAddr1 = data.BankBrchAddr1,
                            BankBrchAddr2 = data.BankBrchAddr2,
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
                if (data.BankBrchID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDBankBrch code = _db.MDBankBrch.Where(p => p.BankBrchCode == data.BankBrchCode && p.BankBrchID != data.BankBrchID ).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        //System.Web.HttpContext.Current.Application.Lock();

                        DAL.MDBankBrch edit = _db.MDBankBrch.Where(p => p.BankBrchID == data.BankBrchID).FirstOrDefault();

                        edit.BankBrchCode = data.BankBrchCode;
                        edit.BankBrchName = data.BankBrchName;
                        edit.BankBrchNameEng = data.BankBrchNameEng;
                        edit.BankBrchAddr1 = data.BankBrchAddr1;
                        edit.BankBrchAddr2 = data.BankBrchAddr2;
                        edit.Remark = data.Remark;

                        _db.SaveChanges();

                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }
        public ActionResult ShowTableBankBrach(int id)
        {
            var Brach = _db.MDBankBrch.Where(p => p.BankBrchID == id).FirstOrDefault();
            return Json(Brach, JsonRequestBehavior.AllowGet);
        }


    }
}