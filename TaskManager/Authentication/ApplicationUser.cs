using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Authentication
{
    public class ApplicationUser:IdentityUser
    {
        public string BirthDate { get; set; }

        public string Password { get; set; }

        public string MobilePhone { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Photo { get; set; }

        public string Manager { get; set; }

        public string ManagerType { get; set; }
    }
}
