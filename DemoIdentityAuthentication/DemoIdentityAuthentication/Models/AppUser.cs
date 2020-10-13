using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DemoIdentityAuthentication.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Password { get; set; }
    }
}