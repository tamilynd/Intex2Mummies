using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ApplicationDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Users.Any())
            {
                var user = new IdentityUser
                {
                    Email = "test@test.com",
                    EmailConfirmed = true,
                    UserName = "TestUser",
                    NormalizedUserName = "TESTUSER"
                };
                var password = new PasswordHasher<IdentityUser>();
                var hashed = password.HashPassword(user, "Mummies4ever!");
                context.Users.AddRange(
                    user
                );
            }
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Name = "Researcher",
                        NormalizedName = "RESEARCHER"
                    }
                );
            }

            context.SaveChanges();
        }
    }
}
