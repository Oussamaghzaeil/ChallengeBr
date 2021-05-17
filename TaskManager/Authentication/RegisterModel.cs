using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Authentication
{
    public class RegisterModel 
    {
        [Required (ErrorMessage = "Complete User Name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "User BirthDate is required")]
        public string BirthDate { get; set; }
        [Required(ErrorMessage = "User Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "User Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "User Mobile Phone is required")]
        public string MobilePhone { get; set; }
        [Required(ErrorMessage = "User Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "User Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "User Photo is required")]
        public string Photo { get; set; }
        
        public string Manager { get; set; }
        [Required(ErrorMessage = "User Manager Type is required")]
        public string ManagerType { get; set; }

    }
}
