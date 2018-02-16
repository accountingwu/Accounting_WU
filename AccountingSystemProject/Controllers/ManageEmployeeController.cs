using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountingSystemProject.DAL;
using PagedList;

namespace AccountingSystemProject.Controllers
{
    public class ManageEmployeeController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageEmployee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageEmployee(int? page)
        {
            List<MDEmployee> emp = _db.MDEmployee.ToList();
            List<Section> section = _db.Section.ToList();
            List<MDPosition> position = _db.MDPosition.ToList();
            List<MDEmpGroup> empGrp = _db.MDEmpGroup.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.MyData = emp.ToPagedList(pageNumber, pageSize);
            ViewBag.MyDataSec = section.ToPagedList(pageNumber, pageSize);
            ViewBag.MyDataPos = position.ToPagedList(pageNumber, pageSize);
            ViewBag.MyDataEmpGrp = empGrp.ToPagedList(pageNumber, pageSize);
            return View();
        }

        [HttpPost]
        public ActionResult SaveEmployee(Models.EmployeeModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.EmpID == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.MDEmployee code = _db.MDEmployee.Where(p => p.EmpCode == data.EmpCode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.MDEmployee.Add(new DAL.MDEmployee
                        {
                            EmpID = data.EmpID,
                            EmpCode = data.EmpCode,
                            EmpHead = data.EmpHead,
                            EmpTitle = data.EmpTitle,
                            EmpNameEng = data.EmpNameEng,
                            EmpName = data.EmpName,
                            EmpType = data.EmpType,
                            Tel = data.Tel,
                            Email = data.Email,
                            EmpStartDate = data.EmpStartDate,
                            EmpPromoteDate = data.EmpPromoteDate,
                            EmpResignDate = data.EmpResignDate,
                            EmpAddr1 = data.EmpAddr1,
                            District = data.District,
                            Amphur = data.Amphur,
                            Province = data.Province,
                            PostCode = data.PostCode,
                            EmpStatus = data.EmpStatus,
                            EmpTitleEng = data.EmpTitleEng,
                            EmpSignature = data.EmpSignature,
                            Username = data.Username,
                            DeptID = data.DeptID,
                            EmpGroupID = data.EmpGroupID,
                            PostID = data.PostID,
                            TaxID = data.TaxID,
                            IDCard = data.IDCard,
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
                if (data.EmpID != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.MDEmployee code = _db.MDEmployee.Where(p => p.EmpCode == data.EmpCode && p.EmpID != data.EmpID).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.MDEmployee edit = _db.MDEmployee.Where(p => p.EmpID == data.EmpID).FirstOrDefault();

                        edit.EmpID = data.EmpID;
                        edit.EmpCode = data.EmpCode;
                        edit.EmpHead = data.EmpHead;
                        edit.EmpTitle = data.EmpTitle;
                        edit.EmpNameEng = data.EmpNameEng;
                        edit.EmpName = data.EmpName;
                        edit.EmpType = data.EmpType;
                        edit.Tel = data.Tel;
                        edit.Email = data.Email;
                        edit.EmpStartDate = data.EmpStartDate;
                        edit.EmpPromoteDate = data.EmpPromoteDate;
                        edit.EmpResignDate = data.EmpResignDate;
                        edit.EmpAddr1 = data.EmpAddr1;
                        edit.District = data.District;
                        edit.Amphur = data.Amphur;
                        edit.Province = data.Province;
                        edit.PostCode = data.PostCode;
                        edit.EmpStatus = data.EmpStatus;
                        edit.EmpTitleEng = data.EmpTitleEng;
                        edit.EmpSignature = data.EmpSignature;
                        edit.Username = data.Username;
                        edit.DeptID = data.DeptID;
                        edit.EmpGroupID = data.EmpGroupID;
                        edit.PostID = data.PostID;
                        edit.TaxID = data.TaxID;
                        edit.IDCard = data.IDCard;
                        edit.Remark = data.Remark;
                        edit.ccode = data.ccode;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteEmployee(int? EmpID)
        {
            if (EmpID != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.MDEmployee delete = _db.MDEmployee.Where(p => p.EmpID == EmpID).FirstOrDefault();

                _db.MDEmployee.Remove(delete);
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

        public ActionResult ShowTablePosition(int id)
        {
            var position = _db.MDPosition.Where(p => p.PostID == id).FirstOrDefault();
            return Json(position, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowTableEmpGrp(int id)
        {
            var empGrp = _db.MDEmpGroup.Where(p => p.EmpGroupID == id).FirstOrDefault();
            return Json(empGrp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowTableEmpHead(int id)
        {
            var emp = _db.MDEmployee.Where(p => p.EmpID == id).FirstOrDefault();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowTableEmployee(int id)
        {
            var emp = _db.MDEmployee.Where(p => p.EmpID == id).FirstOrDefault();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
    }
}