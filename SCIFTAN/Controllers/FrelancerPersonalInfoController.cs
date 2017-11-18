using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using SCIFTAN.BLL.IService;
using SCIFTAN.BLL.Service;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using SCIFTAN.DAL.Repository;
using SCIFTAN.BLL.Models;

namespace SCIFTAN.Controllers
{
    public class FreelancerPersonalInfoController : Controller
    {

        private readonly IFreelancerPersonalInfoService _iFreelancerPersonalInfoService;

        public FreelancerPersonalInfoController(IFreelancerPersonalInfoService iFreelancerPersonalInfoService)
        {
            _iFreelancerPersonalInfoService = iFreelancerPersonalInfoService;
        }
        public ActionResult Index()
        {
            FREELANCER_PERSONAL_INFO_Model personalInfo=null;
            if (User.Identity.GetUserId() != null)
            {
                personalInfo = _iFreelancerPersonalInfoService.GetFreelancerPersonalInfoById(User.Identity.GetUserId());
            }
            return View(personalInfo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Freelancer_Id,FirstName,LastName,FatherName,MotherName,DOB,Gender,Religion,MaritalStatus,Nationality,NID,PresentAddress,PermanentAddress,Mobile1,Mobile2,Email")] FREELANCER_PERSONAL_INFO_Model freelancer_personal_info_model)
        {
            if (ModelState.IsValid)
            {
                freelancer_personal_info_model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerPersonalInfoService.InsertFreelancerPersonalInfo(freelancer_personal_info_model)) ;
                {
                    return RedirectToAction("Index");
                }
            }

            return View(freelancer_personal_info_model);
        }


        public ActionResult Edit()
        {
            if (User.Identity.GetUserId() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FREELANCER_PERSONAL_INFO_Model freelancer_personal_info_model = _iFreelancerPersonalInfoService.GetFreelancerPersonalInfoById(User.Identity.GetUserId());
            if (freelancer_personal_info_model == null)
            {
                return HttpNotFound();
            }
            return View(freelancer_personal_info_model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Freelancer_Id,FirstName,LastName,FatherName,MotherName,DOB,Gender,Religion,MaritalStatus,Nationality,NID,PresentAddress,PermanentAddress,Mobile1,Mobile2,Email")] FREELANCER_PERSONAL_INFO_Model freelancer_personal_info_model)
        {
            if (ModelState.IsValid)
            {
                if (_iFreelancerPersonalInfoService.UpdateFreelancerPersonalInfo(freelancer_personal_info_model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(freelancer_personal_info_model);
        }


    }
}
