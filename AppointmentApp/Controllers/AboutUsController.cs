using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Models;
namespace AppointmentApp.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            var test = PatientProfile.getPatientProfile("jack@gmail.com","jack1234");

            return View ();
        }

        [HttpPost]
        public ActionResult Index(PatientInfo patient)
        {

            string emailId = patient.emailId;
            string password = patient.password;

            var test = PatientProfile.getPatientProfile(emailId, password);

            return View();
        }
    }
}
