using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Business;

namespace AppointmentApp.Controllers
{
    public class SignUpController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Index(PatientInfo patient)
        {
            string firstName = patient.firstName;
            string lastName = patient.lastName;
            string emailId = patient.emailId;
            string password = patient.password;

            var test = PatientProfile.createPatientProfile(firstName, lastName, emailId , password);

            return View();
        }
    }
}
