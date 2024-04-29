using FastFood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Repository
{
    public class DBInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        // after initialization to creating Constructor select all
        // three private roles above right click and click generate Constructor 

        public DBInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

      

        public void Initialize()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }


            if (_context.Roles.Any(x => x.Name == "Manager")) return;
            _roleManager.CreateAsync(new IdentityRole("Manager"))
                .GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin"))
                .GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer"))
                .GetAwaiter().GetResult();

            var User = new ApplicationUser()
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "Admin",
                City = "Sangamner",
                Address = "chand pe",
                PostalCode = "12345",

            };

            _userManager.CreateAsync(User, "Admin@123").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(User, "Admin");


        }
    }
}

//Implements IDbInitializer interface.
//Initializes roles and a default admin user if they don't exist.
//Utilizes RoleManager and UserManager provided by ASP.NET Core Identity for managing roles and users.