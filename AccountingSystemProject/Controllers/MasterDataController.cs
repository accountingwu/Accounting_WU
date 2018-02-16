//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Mvc;
//using AccountingSystemProject.DAL;
//using PagedList;
//using AccountingSystemProject.Models;

//namespace AccountingSystemProject.Controllers
//{
//    public class MasterDataController : Controller
//    {
//        public dbWINS_demoEntities _db = new dbWINS_demoEntities();
//        // GET: MasterData
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult ManageCusID()
//        {
//            return View();
//        }

//        public ActionResult ManageBusinessType()
//        {
//            List<EMBusiType> busi = _db.EMBusiType.ToList();
//            return View(busi);
//        }


//        public ActionResult ManageSideCode()
//        {
//            List<EMSide> side = _db.EMSide.ToList();
//            return View(side);
//        }

//        //เพิ่ม/แก้ไขรหัสแหล่งข้อมูลลูกค้า
//        public ActionResult ManageCustMedia()
//        {
//            List<EMCustMedia> media = _db.EMCustMedia.ToList();
//            ViewBag.MyData = media;
//            return View();
//        }

//        //เพิ่ม/แก้ไขรหัสกลุ่มวางบิล
//        public ActionResult ManageBillGrp()
//        {
//            List<EMBillGroup> bill = _db.EMBillGroup.ToList();
//            return View(bill);
//        }



//        [HttpPost]

//        public ActionResult insertBus(Models.BusiType2 data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();
//                _db = new dbWINS_demoEntities();
//                _db.EMBusiType.Add(new DAL.EMBusiType
//                {
//                    BusiTypeCode = data.BusiTypeCode,
//                    BusiTypeName = data.BusiTypeName,
//                    BusiTypeNameEng = data.BusiTypeNameEng,
//                    Remark = data.Remark
//                });
//                _db.SaveChanges();
//                //System.Web.HttpContext.Current.Application.UnLock();

//                return RedirectToAction("ManageBusinessType");
//            }

//            return View(data);
//        }

//        [HttpPost]
//        public ActionResult EditBus(Models.BusiType data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMBusiType edit = _db.EMBusiType.Where(p => p.BusiTypeID == data.BusiTypeID).FirstOrDefault();

//                edit.BusiTypeCode = data.BusiTypeCode;
//                edit.BusiTypeName = data.BusiTypeName;
//                edit.BusiTypeNameEng = data.BusiTypeNameEng;
//                edit.Remark = data.Remark;

//                _db.SaveChanges();

//                return RedirectToAction("ManageBusinessType");
//            }

//            return View(data);
//        }

//        [HttpPost]

//        public ActionResult DeleteBus(int? BusiTypeID)
//        {
//            if (BusiTypeID != 0)
//            {
//                System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMBusiType delete = _db.EMBusiType.Where(p => p.BusiTypeID == BusiTypeID).FirstOrDefault();

//                _db.EMBusiType.Remove(delete);
//                _db.SaveChanges();

//                //_db.Entry(edit).State = EntityState.Modified;
//                //_db.SaveChanges();

//                System.Web.HttpContext.Current.Application.UnLock();

//                return RedirectToAction("ManageBusinessType");
//            }

//            return RedirectToAction("ManageBusinessType");
//        }

//        public ActionResult test(int id)
//        {
//            var busi = _db.EMBusiType.Where(p => p.BusiTypeID == id).FirstOrDefault();
//            return Json(busi, JsonRequestBehavior.AllowGet);
//        }



//        // ---------------------- Start General - Side ----------------------------// 
//        public ActionResult insertSide(Models.InsertSide data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();
//                _db = new dbWINS_demoEntities();
//                _db.EMSide.Add(new DAL.EMSide
//                {
//                    SideCode = data.SideCode,
//                    SideName = data.SideName,
//                    SideNameEng = data.SideNameEng,
//                    Remark = data.Remark
//                });
//                _db.SaveChanges();
//                //System.Web.HttpContext.Current.Application.UnLock();

//                return RedirectToAction("ManageSideCode");
//            }

//            return View(data);
//        }

//        [HttpPost]
//        public ActionResult EditSide(Models.Side data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMSide edit = _db.EMSide.Where(p => p.SideID == data.SideID).FirstOrDefault();

//                edit.SideCode = data.SideCode;
//                edit.SideName = data.SideName;
//                edit.SideNameEng = data.SideNameEng;
//                edit.Remark = data.Remark;

//                _db.SaveChanges();

//                return RedirectToAction("ManageSideCode");
//            }

//            return View(data);
//        }

//        [HttpPost]

//        public ActionResult DeleteSide(int? SideID)
//        {
//            if (SideID != 0)
//            {
//                System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMSide delete = _db.EMSide.Where(p => p.SideID == SideID).FirstOrDefault();

//                _db.EMSide.Remove(delete);
//                _db.SaveChanges();

//                //_db.Entry(edit).State = EntityState.Modified;
//                //_db.SaveChanges();

//                System.Web.HttpContext.Current.Application.UnLock();

//                return RedirectToAction("ManageSideCode");
//            }

//            return RedirectToAction("ManageSideCode");
//        }

//        public ActionResult ShowTableSide(int id)
//        {
//            var side = _db.EMSide.Where(p => p.SideID == id).FirstOrDefault();
//            return Json(side, JsonRequestBehavior.AllowGet);
//        }



//        // ---------------------- Start General - Media ----------------------------//            
//        [HttpPost]
//        public ActionResult SaveMedia(Models.Media data)
//        {
//            if (!ModelState.IsValid)
//            {
//                if (data.CustMediaID == 0)
//                {
//                    _db = new dbWINS_demoEntities();
//                    DAL.EMCustMedia code = _db.EMCustMedia.Where(p => p.CustMediaCode == data.CustMediaCode).FirstOrDefault();
//                    if (code != null)
//                    {
//                        return Json(false, JsonRequestBehavior.AllowGet);
//                    }
//                    else
//                    {
//                        System.Web.HttpContext.Current.Application.Lock();
//                        _db = new dbWINS_demoEntities();
//                        _db.EMCustMedia.Add(new DAL.EMCustMedia
//                        {
//                            CustMediaID = data.CustMediaID,
//                            CustMediaCode = data.CustMediaCode,
//                            CustMediaName = data.CustMediaName,
//                            CustMediaNameEng = data.CustMediaNameEng,
//                            Remark = data.Remark
//                        });
//                        _db.SaveChanges();
//                        System.Web.HttpContext.Current.Application.UnLock();
//                        return Json(true, JsonRequestBehavior.AllowGet);
//                    }
//                }

//            }
//            if (ModelState.IsValid)
//            {
//                if (data.CustMediaID != 0)
//                {
//                    _db = new dbWINS_demoEntities();
//                    DAL.EMCustMedia code = _db.EMCustMedia.Where(p => p.CustMediaCode == data.CustMediaCode && p.CustMediaID != data.CustMediaID).FirstOrDefault();
//                    if (code != null)
//                    {
//                        return Json(false, JsonRequestBehavior.AllowGet);
//                    }
//                    else
//                    {
//                        DAL.EMCustMedia edit = _db.EMCustMedia.Where(p => p.CustMediaID == data.CustMediaID).FirstOrDefault();

//                        edit.CustMediaCode = data.CustMediaCode;
//                        edit.CustMediaName = data.CustMediaName;
//                        edit.CustMediaNameEng = data.CustMediaNameEng;
//                        edit.Remark = data.Remark;

//                        _db.SaveChanges();

//                        return Json(true, JsonRequestBehavior.AllowGet);
//                    }
//                }
//            }
//            return View(data);
//        }

//        [HttpPost]

//        public ActionResult DeleteMedia(int? CustMediaID)
//        {
//            if (CustMediaID != 0)
//            {
//                System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMCustMedia delete = _db.EMCustMedia.Where(p => p.CustMediaID == CustMediaID).FirstOrDefault();

//                _db.EMCustMedia.Remove(delete);
//                _db.SaveChanges();

//                //_db.Entry(edit).State = EntityState.Modified;
//                //_db.SaveChanges();

//                System.Web.HttpContext.Current.Application.UnLock();

//                return Json(true, JsonRequestBehavior.AllowGet);
//            }

//            return Json(false, JsonRequestBehavior.AllowGet);
//        }

//        public ActionResult ShowTableMedia(int id)
//        {
//            var media = _db.EMCustMedia.Where(p => p.CustMediaID == id).FirstOrDefault();
//            return Json(media, JsonRequestBehavior.AllowGet);
//        }



//        // ---------------------- Start General - BillGrp ----------------------------// 
//        public ActionResult InsertBillGrp(Models.InsertBillGrp data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();
//                _db = new dbWINS_demoEntities();
//                _db.EMBillGroup.Add(new DAL.EMBillGroup
//                {
//                    BillGroupCode = data.BillGroupCode,
//                    BillGroupName = data.BillGroupName,
//                    BillGroupNameEng = data.BillGroupNameEng,
//                    Remark = data.Remark
//                });
//                _db.SaveChanges();
//                //System.Web.HttpContext.Current.Application.UnLock();               
//                return RedirectToAction("ManageBillGrp");
//            }

//            return View(data);
//        }

//        [HttpPost]
//        public ActionResult EditBillGrp(Models.BillGrp data)
//        {
//            if (ModelState.IsValid)
//            {
//                //System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMBillGroup edit = _db.EMBillGroup.Where(p => p.BillGroupID == data.BillGroupID).FirstOrDefault();

//                edit.BillGroupCode = data.BillGroupCode;
//                edit.BillGroupName = data.BillGroupName;
//                edit.BillGroupNameEng = data.BillGroupNameEng;
//                edit.Remark = data.Remark;

//                _db.SaveChanges();

//                return RedirectToAction("ManageBillGrp");
//            }

//            return View(data);
//        }

//        [HttpPost]

//        public ActionResult DeleteBillGrp(int? BillGroupID)
//        {
//            if (BillGroupID != 0)
//            {
//                System.Web.HttpContext.Current.Application.Lock();

//                DAL.EMBillGroup delete = _db.EMBillGroup.Where(p => p.BillGroupID == BillGroupID).FirstOrDefault();

//                _db.EMBillGroup.Remove(delete);
//                _db.SaveChanges();

//                //_db.Entry(edit).State = EntityState.Modified;
//                //_db.SaveChanges();

//                System.Web.HttpContext.Current.Application.UnLock();

//                return RedirectToAction("ManageBillGrp");
//            }

//            return RedirectToAction("ManageBillGrp");
//        }

//        public ActionResult ShowTableBillGrp(int id)
//        {
//            var billGrp = _db.EMBillGroup.Where(p => p.BillGroupID == id).FirstOrDefault();
//            return Json(billGrp, JsonRequestBehavior.AllowGet);
//        }

//    }
//}


