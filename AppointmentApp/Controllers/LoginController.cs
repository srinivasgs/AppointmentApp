using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Business;
namespace AppointmentApp.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Index(PatientInfo patient)
        {
            var patientProfileList = new List<PatientInfo>();
            string emailId = patient.emailId;
            string password = patient.password;

            patientProfileList = PatientProfile.getPatientProfile(emailId, password);

            if(patientProfileList != null && patientProfileList.Count > 0) {
                return View("Success");
            } else {
                return View("Failure");
            }
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }
    }
}
