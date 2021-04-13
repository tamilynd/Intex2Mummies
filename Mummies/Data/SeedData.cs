using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mummies.Data
{
    public class SeedData
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public SeedData(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async void EnsurePopulated(IApplicationBuilder application)
        {
            ApplicationDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        Id = "9e3ba0b1-be63-419e-bcdf-53ce33d49c22"
                    },
                    new IdentityRole
                    {
                        Name = "Researcher",
                        NormalizedName = "RESEARCHER",
                        Id = "26be9a25-2f0d-4391-8d67-a2054fc269cc"
                    }
                );
            }

            context.SaveChanges();


        }
    }
}
