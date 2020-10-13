using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoIdentityAuthentication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoIdentityAuthentication.Data
{
    // IdentityDbContext contains all the user tables  
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
