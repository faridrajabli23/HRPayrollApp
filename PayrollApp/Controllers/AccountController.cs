using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HRPayroll.Models;
using PayrollApp.Models;

namespace PayrollApp.Controllers
{
    [Authorize(Roles ="pay")]
    public class AccountController : Controller
    {
        private readonly PayrollAppDbContext _context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(PayrollAppDbContext context, UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            _context = context;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public ActionResult Index()
        {
            return View(userManager.Users);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.UserName = registerModel.UserName;
                appUser.Email = registerModel.Email;
                var result = await userManager.CreateAsync(appUser,registerModel.Password);

                if (result.Succeeded)
                {
                    return Redirect("/hrpayroll/departmenthead/employeeindex");

                }
                else
                {
                    ModelState.AddModelError("","Olmadi be gulum");
                }
            }
            return View(registerModel);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(loginModel.Email);
                if (user != null)
                {

                    bool isDepartmentHead = await userManager.IsInRoleAsync(user, "DepartmentHead");
                    bool isAdmin = await userManager.IsInRoleAsync(user, "Admin");
                    bool isHR = await userManager.IsInRoleAsync(user, "HR");
                    bool isPayrollSpecialist = await userManager.IsInRoleAsync(user, "PayrollSpecialist");
                    if (isDepartmentHead)
                    {
                        var signInResult = await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            Department department = await _context.Departments.FindAsync(user.DepartmentId);
                            UserDepartmentId userDepartmentId = new UserDepartmentId()
                            {
                                DeparmentId = department.Id
                            };
                            _context.userDepartmentIds.Add(userDepartmentId);
                            await _context.SaveChangesAsync();
                            return Redirect($"/hrpayroll/departmenthead/employeeindex");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or password is incorrect");
                            return View();
                        }
                    }
                    else if (isHR)
                    {
                        var signInResult = await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            return Redirect($"/hrpayroll/Employee/Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or password is incorrect");
                            return View();
                        }
                    }
                    else if (isPayrollSpecialist)
                    {
                        var signInResult = await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            return Redirect($"/hrpayroll/PayrollSpecialist/EmployeeIndex");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or password is incorrect");
                            return View();
                        }
                    }
                    else if (isAdmin)
                    {
                        var signInResult = await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                        if (signInResult.Succeeded)
                        {
                            return Redirect($"/hrpayroll/Admin/UserIndex");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Email or password is incorrect");
                            return View();
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or password is incorrect");
                        return View(loginModel);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is incorrect");
                    return View(loginModel);
                }
            }
            else
            {
                return View(loginModel);
            }
        }

        public async Task<IActionResult> SignOut()
        {
            List<UserDepartmentId> userDepartmentIds = await _context.userDepartmentIds.ToListAsync();
            if (userDepartmentIds.Any())
            {
                foreach (var item in userDepartmentIds)
                {
                    _context.Remove(item);
                }
            }
            await _context.SaveChangesAsync();
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}