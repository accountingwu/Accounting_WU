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
    public class ManageCustomerController : Controller
    {
        public QSoft_WUEntities _db = new QSoft_WUEntities();
        // GET: ManageCustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageCustomer(int? page, string sortOrder)
        {
            ViewBag.cuscode = String.IsNullOrEmpty(sortOrder) ? "cuscode" : "";
            ViewBag.cusname1 = String.IsNullOrEmpty(sortOrder) ? "cusname1" : "";
            ViewBag.cusname11 = String.IsNullOrEmpty(sortOrder) ? "cusname11" : "";
            ViewBag.status = String.IsNullOrEmpty(sortOrder) ? "status" : "";

            List<Groupcustomer> groupcustomer = _db.Groupcustomer.ToList();
            ViewBag.getgroupcustomer = groupcustomer;
            List<CustomerZone> customerzone = _db.CustomerZone.ToList();
            ViewBag.getcustomerzone = customerzone;
            List<CreditTermType> credittermtype = _db.CreditTermType.ToList();
            ViewBag.getcredittermtype = credittermtype;
            List<Customer> customerinvoice = _db.Customer.ToList();
            ViewBag.getcustomerinvoice = customerinvoice;
            List<Customer> Cusbill = _db.Customer.ToList();
            ViewBag.getCusbill = Cusbill;
            List<Customer> Customersend = _db.Customer.ToList();
            ViewBag.getCustomersend = Customersend;
            List<Employee> employee = _db.Employee.ToList();
            ViewBag.getemployee = employee;



            List<Customer> customer = _db.Customer.ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "cuscode":
                    customer = _db.Customer.OrderBy(s => s.cuscode).ToList();
                    break;
                case "cusname1":
                    customer = _db.Customer.OrderBy(s => s.cusname1).ToList();
                    break;
                case "cusname11":
                    customer = _db.Customer.OrderBy(s => s.cusname11).ToList();
                    break;
                case "status":
                    customer = _db.Customer.OrderBy(s => s.status).ToList();
                    break;
                default:
                    customer = _db.Customer.OrderByDescending(s => s.cust_id).ToList();
                    break;
            }
            ViewBag.MyData = customer.ToPagedList(pageNumber, pageSize);
            ViewBag.sortOrder = sortOrder;
            return View();
        }
        public ActionResult ShowTableCustomer(int id)
        {
            var customer = _db.Customer.Where(p => p.cust_id == id).FirstOrDefault();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult ShowTableCustomer(int id, int eid)
        //{
        //    _db = new QSoft_WUEntities();
        //    var customer = (from data in _db.Customer
        //                    join d in _db.Employee on data.saleid equals d.eid
        //                    select new CustView
        //                    {
        //                        cust_id = data.cust_id,
        //                        cuscode = data.cuscode,
        //                        cusname1 = data.cusname1,
        //                        cusname11 = data.cusname11,
        //                        cusname2 = data.cusname2,
        //                        cusname21 = data.cusname21,
        //                        cusaddress1 = data.cusaddress1,
        //                        cusaddress2 = data.cusaddress2,
        //                        cuszip = data.cuszip,
        //                        custel = data.custel,
        //                        cusfax = data.cusfax,
        //                        cusmobile = data.cusmobile,
        //                        datecontact = data.datecontact,
        //                        dateinact = data.dateinact,
        //                        status = data.status,
        //                        p_id = data.p_id,
        //                        t_id = data.t_id,
        //                        niti = data.niti,
        //                        acc_code = data.acc_code,
        //                        gcusid = data.gcusid,
        //                        contaddress1 = data.contaddress1,
        //                        contaddress2 = data.contaddress2,
        //                        contzip = data.contzip,
        //                        notebill = data.notebill,
        //                        noteth = data.noteth,
        //                        noteen = data.noteen,
        //                        cuszid = data.cuszid,
        //                        credittermtype = data.credittermtype,
        //                        credittermday = data.credittermday,
        //                        creditmoney = data.creditmoney,
        //                        saleid = data.saleid,
        //                        contname = data.contname,
        //                        blacklist = data.blacklist,
        //                        reason = data.reason,
        //                        grade = data.grade,
        //                        conname = data.conname,
        //                        cusidinvoice = data.cusidinvoice,
        //                        cusidbill = data.cusidbill,
        //                        cusidsend = data.cusidsend,
        //                        sendid = data.sendid,
        //                        ncostcode = data.ncostcode,
        //                        ndiscountcode = data.ndiscountcode,
        //                        discountlist = data.discountlist,
        //                        discountbill = data.discountbill,
        //                        note1 = data.note1,
        //                        note2 = data.note2,
        //                        note3 = data.note3,
        //                        note4 = data.note4,
        //                        note5 = data.note5,
        //                        note6 = data.note6,
        //                        note7 = data.note7,
        //                        note8 = data.note8,
        //                        note9 = data.note9,
        //                        note10 = data.note10,
        //                        ccode = data.ccode,
        //                        ShippingDate = data.ShippingDate,
        //                        eid = d.eid,
        //                        ecode = d.ecode,
        //                        ename1 = d.ename1,
        //                    }).Where(CustView => CustView.cust_id == id).FirstOrDefault();
        //    return Json(customer, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult FindPopCustomerInvoice(int id)
        {
            var customer = _db.Customer.Where(p => p.cust_id == id).FirstOrDefault();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FindPopCusbill(int id)
        {
            var customer = _db.Customer.Where(p => p.cust_id == id).FirstOrDefault();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FindPopCustomersend(int id)
        {
            var customer = _db.Customer.Where(p => p.cust_id == id).FirstOrDefault();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        public ActionResult FindPopEmployee(int id)
        {
            var employee = _db.Employee.Where(p => p.eid == id).FirstOrDefault();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveCustomer(Models.CustomerModel data)
        {
            if (!ModelState.IsValid)
            {
                if (data.cust_id == 0)
                {

                    _db = new QSoft_WUEntities();
                    DAL.Customer code = _db.Customer.Where(p => p.cuscode == data.cuscode).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {

                        System.Web.HttpContext.Current.Application.Lock();
                        _db = new QSoft_WUEntities();
                        _db.Customer.Add(new DAL.Customer
                        {
                            cust_id = data.cust_id,
                            cuscode = data.cuscode,
                            cusname1 = data.cusname1,
                            cusname11 = data.cusname11,
                            cusname2 = data.cusname2,
                            cusname21 = data.cusname21,
                            cusaddress1 = data.cusaddress1,
                            cusaddress2 = data.cusaddress2,
                            cuszip = data.cuszip,
                            custel = data.custel,
                            cusfax = data.cusfax,
                            cusmobile = data.cusmobile,
                            datecontact = data.datecontact,
                            dateinact = data.dateinact,
                            status = data.status,
                            p_id = data.p_id,
                            t_id = data.t_id,
                            niti = data.niti,
                            acc_code = data.acc_code,
                            gcusid = data.gcusid,
                            contaddress1 = data.contaddress1,
                            contaddress2 = data.contaddress2,
                            contzip = data.contzip,
                            notebill = data.notebill,
                            noteth = data.noteth,
                            noteen = data.noteen,
                            cuszid = data.cuszid,
                            credittermtype = data.credittermtype,
                            credittermday = data.credittermday,
                            creditmoney = data.creditmoney,
                            saleid = data.saleid,
                            contname = data.contname,
                            blacklist = data.blacklist,
                            reason = data.reason,
                            grade = data.grade,
                            conname = data.conname,
                            cusidinvoice = data.cusidinvoice,
                            cusidbill = data.cusidbill,
                            cusidsend = data.cusidsend,
                            sendid = data.sendid,
                            ncostcode = data.ncostcode,
                            ndiscountcode = data.ndiscountcode,
                            discountlist = data.discountlist,
                            discountbill = data.discountbill,
                            note1 = data.note1,
                            note2 = data.note2,
                            note3 = data.note3,
                            note4 = data.note4,
                            note5 = data.note5,
                            note6 = data.note6,
                            note7 = data.note7,
                            note8 = data.note8,
                            note9 = data.note9,
                            note10 = data.note10,
                            ccode = data.ccode,
                            ShippingDate = data.ShippingDate
                        });
                        _db.SaveChanges();
                        System.Web.HttpContext.Current.Application.UnLock();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                if (data.cust_id != 0)
                {
                    _db = new QSoft_WUEntities();
                    DAL.Customer code = _db.Customer.Where(p => p.cuscode == data.cuscode && p.cust_id != data.cust_id).FirstOrDefault();
                    if (code != null)
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        DAL.Customer edit = _db.Customer.Where(p => p.cust_id == data.cust_id).FirstOrDefault();

                        edit.cuscode = data.cuscode;
                        edit.cusname1 = data.cusname1;
                        edit.cusname11 = data.cusname11;
                        edit.cusname2 = data.cusname2;
                        edit.cusname21 = data.cusname21;
                        edit.cusaddress1 = data.cusaddress1;
                        edit.cusaddress2 = data.cusaddress2;
                        edit.cuszip = data.cuszip;
                        edit.custel = data.custel;
                        edit.cusfax = data.cusfax;
                        edit.cusmobile = data.cusmobile;
                        edit.datecontact = data.datecontact;
                        edit.dateinact = data.dateinact;
                        edit.status = data.status;
                        edit.p_id = data.p_id;
                        edit.t_id = data.t_id;
                        edit.niti = data.niti;
                        edit.acc_code = data.acc_code;
                        edit.gcusid = data.gcusid;
                        edit.contaddress1 = data.contaddress1;
                        edit.contaddress2 = data.contaddress2;
                        edit.contzip = data.contzip;
                        edit.notebill = data.notebill;
                        edit.noteth = data.noteth;
                        edit.noteen = data.noteen;
                        edit.cuszid = data.cuszid;
                        edit.credittermtype = data.credittermtype;
                        edit.credittermday = data.credittermday;
                        edit.creditmoney = data.creditmoney;
                        edit.saleid = data.saleid;
                        edit.contname = data.contname;
                        edit.blacklist = data.blacklist;
                        edit.reason = data.reason;
                        edit.grade = data.grade;
                        edit.conname = data.conname;
                        edit.cusidinvoice = data.cusidinvoice;
                        edit.cusidbill = data.cusidbill;
                        edit.cusidsend = data.cusidsend;
                        edit.sendid = data.sendid;
                        edit.ncostcode = data.ncostcode;
                        edit.ndiscountcode = data.ndiscountcode;
                        edit.discountlist = data.discountlist;
                        edit.discountbill = data.discountbill;
                        edit.note1 = data.note1;
                        edit.note2 = data.note2;
                        edit.note3 = data.note3;
                        edit.note4 = data.note4;
                        edit.note5 = data.note5;
                        edit.note6 = data.note6;
                        edit.note7 = data.note7;
                        edit.note8 = data.note8;
                        edit.note9 = data.note9;
                        edit.note10 = data.note10;
                        edit.ccode = data.ccode;
                        edit.ShippingDate = data.ShippingDate;
                        _db.SaveChanges();
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                }
            }

            return View(data);
        }

        public ActionResult DeleteCustomer(int cust_id)
        {
            if (cust_id != 0)
            {
                System.Web.HttpContext.Current.Application.Lock();

                DAL.Customer delete = _db.Customer.Where(p => p.cust_id == cust_id).FirstOrDefault();

                _db.Customer.Remove(delete);
                _db.SaveChanges();

                System.Web.HttpContext.Current.Application.UnLock();

                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }

    }
}