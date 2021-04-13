﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mummies.Models.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Admin()
        {
            //Returns Admin page must be an authenticated admin
            return View(/*Mummies list*/);
        }

        [HttpGet]
        public async Task<IActionResult> ListRolesAndUsers()
        {
            //This sends a list of current roles to the view 
            Dictionary<string, string> Admins = new Dictionary<string, string>();
            Dictionary<string, string> Researchers = new Dictionary<string, string>();

            ViewBag.admin = await roleManager.FindByNameAsync("Admin");
            ViewBag.researcher = await roleManager.FindByNameAsync("Researcher");

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, "Admin"))
                {
                    Admins.Add(user.Id, user.UserName);
                }
                if (await userManager.IsInRoleAsync(user, "Researcher"))
                {
                    Researchers.Add(user.Id, user.UserName);
                }
            }

            RoleUserListViewModel model = new RoleUserListViewModel
            {
                AdminUsers = Admins,
                ResearchUsers = Researchers,
            };
                return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string id)
        {
            //Grabs a list of all the users and their current role status and sends it to the view
            ViewBag.roleId = id;

            var role = await roleManager.FindByIdAsync(id);

            ViewBag.roleName = role.Name;

            if(role == null)
            {
                //Error
                return View();
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }
                model.Add(userRoleViewModel);
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string id)
        {
            //Checks for any changes to permissions, and adds/updates those changes in the user database
            var role = await roleManager.FindByIdAsync(id);

            foreach (var x in model)
            {
                var user = await userManager.FindByIdAsync(x.UserId);

                IdentityResult result = null;

                if (x.IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!x.IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
            }
            return RedirectToAction("ListRolesAndUsers", "Admin");
        }


        //I used these to create the roles because I was too lazy to do it the right way I guess
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (roleName != "")
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = roleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Admin");
                }

            }
            return View();
        }

    }
}
