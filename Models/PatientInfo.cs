using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class PatientInfo
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("First Name")]
        public string firstName { get; set; }

        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [DisplayName("emailId")]
        public string emailId { get; set; }

        [DisplayName("password")]
        public string password { get; set; }
    }
}
