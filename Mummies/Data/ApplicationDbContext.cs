using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mummies.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //Seeding a  'Administrator' role to AspNetRoles table
        //    modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "Admin".ToUpper() });


        //    //a hasher to hash the password before seeding the user to the db
        //    var hasher = new PasswordHasher<IdentityUser>();


        //    //Seeding the User to AspNetUsers table
        //    modelBuilder.Entity<IdentityUser>().HasData(
        //        new IdentityUser
        //        {
        //            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
        //            UserName = "TestUser",
        //            NormalizedUserName = "TESTUSER",
        //            Email = "test@test.com",
        //            EmailConfirmed = true,
        //            NormalizedEmail = "TEST@TEST.COM",
        //            PasswordHash = hasher.HashPassword(null, "Mummies4ever!")
        //        }
        //    );


        //    //Seeding the relation between our user and role to AspNetUserRoles table
        //    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
        //        new IdentityUserRole<string>
        //        {
        //            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
        //            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
        //        }
        //    );


        //}
    }
}
