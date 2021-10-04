using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMH_Project.Models
{
    public class Patient : BaseEntity
    {

        public int PatientId { get; set; }
        [Required]
        public string   PatientName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Address { get; set; }

        public DateTime LastVisit { get; set; }

        public string Status { get; set; }

        public string PhotoPath { get; set; }




    }
}
