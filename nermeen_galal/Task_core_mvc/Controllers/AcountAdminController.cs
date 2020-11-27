using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AcountAdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public AcountAdminController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View("AddAdmin");
        }

        [HttpPost]
        public async Task<IActionResult> saveAddAdmin(string Adminname, string email, string password)
        {
            var user = new IdentityUser
            {
                UserName = Adminname,
                Email = email,

            };

            var result = await userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {

                var Roleresult = await userManager.AddToRoleAsync(user, "Admin");
                if (Roleresult.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }

            return RedirectToAction("Index", "Admin");
        }


        [HttpGet]
        public IActionResult AddRole()
        {

            return View("AddRole");
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string RoleName)
        {
            if (ModelState.IsValid)
            {
                
                IdentityRole identityRole = new IdentityRole
                {
                    Name = RoleName
                };

                
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Admin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(RoleName);
        }
    }


}
