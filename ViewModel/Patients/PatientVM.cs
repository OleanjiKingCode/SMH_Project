using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SMH_Project.Models;

namespace SMH_Project.ViewModel.Patients
{
    public class PatientVM:Patient
    {
        [DisplayName("Patient ID")]
        public int PatientId { get; set; }
        
        public string PatientName { get; set; }
        
        public DateTime DOB { get; set; }
 
        public int Age { get; set; }
    
        public int PhoneNumber { get; set; }
       
        public string Email { get; set; }
       
        public Gender Gender { get; set; }
       
        public string Address { get; set; }

        public DateTime LastVisit { get; set; }

        public string Status { get; set; }


    }
}
