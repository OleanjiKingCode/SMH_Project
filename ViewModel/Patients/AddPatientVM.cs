using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SMH_Project.Models;

namespace SMH_Project.ViewModel
{
    public class AddPatientVM
    {
        [Required (ErrorMessage = "Patient First and Last Name are Required")]
        [MaxLength (50,ErrorMessage ="Name should not be more than 50 Characters")]
        public string PatientName { get; set; }
        [Required(ErrorMessage = "Missing Date of Birth")]
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Missing Age")]
        
        public int Age { get; set; }
        [Required (ErrorMessage ="Phone Number Missing")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Missing")]
        
        public string Email { get; set; }
        [Required (ErrorMessage ="Please Select A Gender")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Address of Patient Missing")]
        public string Address { get; set; }

        public IFormFile Photo { get; set; }
    }
}
