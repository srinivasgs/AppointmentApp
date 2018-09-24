using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;

namespace Business
{
    public class PatientProfile
    {
        public static Boolean createPatientProfile(String firstName, String lastName, String emailId, String password)
        {
            DataSet patientProfilResult = new DataSet();
            Boolean isCreated;
            var patientProfileList = new List<PatientInfo>();
            Random random = new Random();
            Guid guid = Guid.NewGuid();
            string uniqueId = guid.ToString();
            isCreated = DAPatientInformation.CreatePatientProfile(uniqueId, firstName, lastName, emailId, password);

            if (patientProfilResult.Tables.Count > 0)
            {
                patientProfileList = patientProfilResult.Tables[0].AsEnumerable().Select(mn => new PatientInfo
                {
                    firstName = Convert.ToString(mn["first_name"]),
                    lastName = Convert.ToString(mn["last_name"]),
                    emailId = Convert.ToString(mn["email"])

                }).ToList();
            }
            return isCreated;
        }

        public static List<PatientInfo> getPatientProfile(String emailId, String password) {
            DataSet patientProfilResult = new DataSet();

            var patientProfileList = new List<PatientInfo>();

            patientProfilResult = DAPatientInformation.getPatientProfile(emailId,password);

            if (patientProfilResult.Tables.Count > 0)
            {
                patientProfileList = patientProfilResult.Tables[0].AsEnumerable().Select( mn => new PatientInfo
                {
                    firstName = Convert.ToString(mn["first_name"]),
                    lastName = Convert.ToString(mn["last_name"]),
                    emailId = Convert.ToString(mn["email"])

                }).ToList();
            }
            return patientProfileList;
        }
    }
}
