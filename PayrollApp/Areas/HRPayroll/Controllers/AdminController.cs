using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HRPayroll.Models;
using PayrollApp.Areas.HRPayroll.Models.ViewModels;

namespace PayrollApp.Areas.HRPayroll.Controllers
{
    [Area("HRPayroll")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly PayrollAppDbContext _context;
        private UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IPasswordHasher<AppUser> passwordHasher;
        public AdminController(PayrollAppDbContext context, 
                                                    UserManager<AppUser> _userManager, 
                                                        SignInManager<AppUser> _signInManager, 
                                                            IPasswordHasher<AppUser> _passwordHash)
        {
            _context = context;
            userManager = _userManager;
            signInManager = _signInManager;
            passwordHasher = _passwordHash;
        }
        
        [HttpGet]
        public async Task<IActionResult> RegisterUser()
        {
            UserRegisterModel model = new UserRegisterModel()
            {
                Departments = await _context.Departments.ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(UserRegisterModel userRegisterModel)
        {
            string passw = userRegisterModel.Password;
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser existUser = await userManager.FindByEmailAsync(userRegisterModel.Email);
                    if (existUser != null)
                    {
                        userRegisterModel.Departments = await _context.Departments.ToListAsync();
                        userRegisterModel.Password = passw;
                        ModelState.AddModelError("Email", "This email already exist");
                        return View(userRegisterModel);
                    }
                    existUser = await userManager.FindByNameAsync(userRegisterModel.UserName);
                    if(existUser != null)
                    {
                        userRegisterModel.Departments = await _context.Departments.ToListAsync();
                        userRegisterModel.Password = passw;
                        ModelState.AddModelError("UserName", "This username already exist");
                        return View(userRegisterModel);
                    }

                    string uniqueFileName = null;
                    if (userRegisterModel.Photo != null)
                    {
                        string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + userRegisterModel.Photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await userRegisterModel.Photo.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        userRegisterModel.Departments = await _context.Departments.ToListAsync();
                        userRegisterModel.Password = passw;
                        ModelState.AddModelError("Photo", "Please upload photo");
                        return View(userRegisterModel);
                    }

                    AppUser appUser = new AppUser()
                    {
                        Name = userRegisterModel.Name,
                        Surname = userRegisterModel.Surname,
                        Email = userRegisterModel.Email,
                        PhoneNumber = Convert.ToString(userRegisterModel.PhoneNumber),
                        PhotoPath = uniqueFileName,
                        UserName = userRegisterModel.UserName,
                        DepartmentId = userRegisterModel.DepartmentId
                    };

                    var result = await userManager.CreateAsync(appUser, userRegisterModel.Password);


                    if (result.Succeeded)
                    {
                        return Redirect("/hrpayroll/admin/userindex");
                    }
                    else
                    {
                        userRegisterModel.Password = passw;
                        userRegisterModel.Departments = await _context.Departments.ToListAsync();
                        return View(userRegisterModel);
                    }
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/userindex");
                }
            }
            else
            {
                userRegisterModel.Password = passw;
                userRegisterModel.Departments = await _context.Departments.ToListAsync();
                return View(userRegisterModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> UserIndex()
        {
            List<AppUser> users = await _context.Users.ToListAsync();
            return View(users);
        }


        [HttpGet]
        public async Task<IActionResult> UserEdit(string id)
        {
            AppUser appUser = await userManager.FindByIdAsync(id);
            UserEditModel userEditModel = new UserEditModel()
            {
                Id = appUser.Id,
                Name = appUser.Name,
                Surname = appUser.Surname,
                UserName = appUser.UserName,
                Email = appUser.Email,
                PhotoPath = appUser.PhotoPath,
                PhoneNumber = appUser.PhoneNumber,
                Departments = await _context.Departments.ToListAsync(),
                ExistUserName = appUser.UserName,
                ExistEmail = appUser.Email,
                DepartmentId = appUser.DepartmentId
            };

            return View(userEditModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserEdit( UserEditModel userEditModel)
        {
            if (ModelState.IsValid)
            {
                string passwordEdit = userEditModel.Password;

                AppUser existUser = await userManager.FindByEmailAsync(userEditModel.Email);
                if (userEditModel.Email != userEditModel.ExistEmail && existUser != null)
                {
                    userEditModel.Departments = await _context.Departments.ToListAsync();
                    userEditModel.Password = passwordEdit;
                    ModelState.AddModelError("Email", "This email already exist");
                    return View(userEditModel);
                }
                existUser = await userManager.FindByNameAsync(userEditModel.UserName);

                if (userEditModel.UserName != userEditModel.ExistUserName && existUser != null)
                {
                    userEditModel.Password = passwordEdit;
                    userEditModel.Departments = await _context.Departments.ToListAsync();
                    ModelState.AddModelError("UserName", "This username already exist");
                    return View(userEditModel);
                }

                string uniqueFileName = null;
                if (userEditModel.Photo != null)
                {
                    string fileName = userEditModel.PhotoPath;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads", fileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    else
                    {
                        return RedirectToAction(nameof(UserIndex));
                    }

                    string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + userEditModel.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await userEditModel.Photo.CopyToAsync(fileStream);
                    }
                }

                if (uniqueFileName == null)
                {
                    uniqueFileName = userEditModel.PhotoPath;
                }

                AppUser appUser = await userManager.FindByIdAsync(userEditModel.Id);
                appUser.PasswordHash = passwordHasher.HashPassword(appUser, userEditModel.Password);
                appUser.Name = userEditModel.Name;
                appUser.Surname = userEditModel.Surname;
                appUser.Email = userEditModel.Email;
                appUser.PhoneNumber = Convert.ToString(userEditModel.PhoneNumber);
                appUser.PhotoPath = uniqueFileName;
                appUser.UserName = userEditModel.UserName;
                appUser.DepartmentId = userEditModel.DepartmentId;
                

                var result = await userManager.UpdateAsync(appUser);


                if (result.Succeeded)
                {
                    return Redirect("/hrpayroll/admin/userindex");
                }
                else
                {
                    return Redirect("/hrpayroll/admin/userindex");
                }
            }
            else
            {

                userEditModel.Departments = await _context.Departments.ToListAsync();
                string passw = userEditModel.Password;
                userEditModel.Password = passw;
                return View(userEditModel);
            }
        }

        public async Task<IActionResult> UserDelete(string id)
        {
            try
            {
                AppUser appUser = await userManager.FindByIdAsync(id);
                if (appUser == null)
                {
                    return RedirectToAction(nameof(UserIndex));
                }
                var fileName = appUser.PhotoPath;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                else
                {
                    return RedirectToAction(nameof(UserIndex));
                }

                var result = await userManager.DeleteAsync(appUser);


                if (result.Succeeded)
                {
                    return Redirect("/hrpayroll/admin/userindex");
                }
                else
                {
                    return RedirectToAction(nameof(UserIndex));
                }
            }
            catch
            {
                return Redirect("/hrpayroll/admin/userindex");
            }
        }

        public async Task<IActionResult> EmployeeIndex()
        {
            List<Employee> employees = await _context.Employees.ToListAsync();
            return View(employees);
        }
        
        public async Task<IActionResult> EmployeeDetails(string id)
        {
            if (id == "0")
            {
                return Redirect("/hrpayroll/employee/index");
            }
            int Id = Convert.ToInt32(id);
            try
            {
                var work = await _context.WorkPlaces.Where(w => w.EmployeeId == Id).FirstOrDefaultAsync();
                WorkPlace workPlace = await _context
                                                    .WorkPlaces
                                                     .Where(w => w.EmployeeId == Id && w.PositionId == work.PositionId)
                                                       .Include(e => e.Employee)
                                                         .Include(p => p.Position)
                                                           .ThenInclude(c => c.Company)
                                                            .ThenInclude(d => d.Department)
                                                              .FirstOrDefaultAsync();
                WorkPlaceDetails workPlaceDetail = new WorkPlaceDetails()
                {
                    Photo = workPlace.Employee.Photo,
                    Department = workPlace.Position.Company.Department.Name,
                    Company = workPlace.Position.Company.Name,
                    Position = workPlace.Position.Name,
                    Salary = workPlace.Position.Salary,
                    Name = workPlace.Employee.Name,
                    Surname = workPlace.Employee.Surname,
                    Address = workPlace.Employee.Address,
                    Birthday = workPlace.Employee.Birthday,
                    Education = workPlace.Employee.Education,
                    Gender = workPlace.Employee.Gender,
                    MaritalStatus = workPlace.Employee.MaritalStatus,
                    OldWorkPlaces = await _context.OldWorkPlaces.Where(e => e.EmployeeId == work.EmployeeId).ToListAsync()
                };

                return View(workPlaceDetail);
            }
            catch
            {
                try
                {
                    Employee employee = await _context.Employees.FindAsync(Id);
                    WorkPlaceDetails workPlaceDetail = new WorkPlaceDetails()
                    {
                        Photo = employee.Photo,
                        Department = "",
                        Company = "",
                        Position = "",
                        Salary = 0,
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Address = employee.Address,
                        Birthday = employee.Birthday,
                        Education = employee.Education,
                        Gender = employee.Gender,
                        MaritalStatus = employee.MaritalStatus,
                        OldWorkPlaces = await _context.OldWorkPlaces.Where(e => e.EmployeeId == Id).ToListAsync()
                    };

                    return View(workPlaceDetail);
                }
                catch
                {
                    Employee employee = await _context.Employees.FindAsync(Id);
                    WorkPlaceDetails workPlaceDetail = new WorkPlaceDetails()
                    {
                        Photo = employee.Photo,
                        Department = "",
                        Company = "",
                        Position = "",
                        Salary = 0,
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Address = employee.Address,
                        Birthday = employee.Birthday,
                        Education = employee.Education,
                        Gender = employee.Gender,
                        MaritalStatus = employee.MaritalStatus,
                        OldWorkPlaces = await _context.OldWorkPlaces.Where(e => e.EmployeeId == Id).ToListAsync()

                    };
                    return View(workPlaceDetail);
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> Department()
        {
            Holding holding = await _context.Holdings.FirstOrDefaultAsync();
            DepartmentAdd department = new DepartmentAdd()
            {
                Departments = await _context.Departments.ToListAsync(),
                HoldingId = holding.Id
            };
            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Department(DepartmentAdd department)
        {
            if (ModelState.IsValid)
            {
                Department departmentToDb = new Department()
                {
                    HoldingId = department.HoldingId,
                    Name = department.Name
                };
                _context.Departments.Add(departmentToDb);
                await _context.SaveChangesAsync();
                department.HoldingId = department.HoldingId;
                department.Departments = await _context.Departments.ToListAsync();
                return View(department);
            }
            else
            {
                department.HoldingId = department.HoldingId;
                department.Departments = await _context.Departments.ToListAsync();
                
                return View(department);
            }
        }

        [HttpGet]
        public async Task<ActionResult> DepartmentNameEdit(int id)
        {
            Department department = await _context.Departments.FindAsync(id);

            DepartmentNameEdit departmentNameEditModel = new DepartmentNameEdit()
            {
                Name = department.Name,
                HoldingId = department.HoldingId,
                Id = department.Id
            };
            return View(departmentNameEditModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DepartmentNameEdit(DepartmentNameEdit departmentNameEditModel)
        {
            if (ModelState.IsValid)
            {
                Department department = new Department()
                {
                    Name = departmentNameEditModel.Name,
                    HoldingId = departmentNameEditModel.HoldingId,
                    Id = departmentNameEditModel.Id
                };
                _context.Departments.Update(department);
                await _context.SaveChangesAsync();
                return Redirect("/hrpayroll/admin/department");
            }
            else
            {
                return View(departmentNameEditModel);
            }
        }

        
        public async Task<IActionResult> DepartmentDelete(int id)
        {
            Department department = await _context.Departments.FindAsync(id);
            if(department != null)
            {
                try
                {
                    _context.Departments.Remove(department);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/department");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/department");
                }
            }
            else
            {
                return Redirect("/hrpayroll/admin/department");
            }
        }

        [HttpGet]
        public async Task<IActionResult> CompanyIndex()
        {
            CompanyDepartmentViewModel model = new CompanyDepartmentViewModel()
            {
                Companies = await _context.Companies.Include(d => d.Department).ToListAsync(),
                Departments = await _context.Departments.ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompanyIndex(CompanyDepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Company company = new Company()
                {
                    Name = model.CompanyAddModel.Name,
                    DepartmentId = model.CompanyAddModel.DepartmentId
                };

                try
                {
                    _context.Companies.Add(company);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/companyindex");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                model.Companies = await _context.Companies.Include(d => d.Department).ToListAsync();
                model.Departments = await _context.Departments.ToListAsync();
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> CompanyEdit(int id)
        {
            Company company = await _context.Companies.FindAsync(id);
            if(company == null)
            {
                return Redirect("/hrpayroll/admin/companyindex");
            }
            CompanyEditViewModel editModel = new CompanyEditViewModel()
            {
                Name = company.Name,
                Id = company.Id,
                DepartmentId = company.DepartmentId,
                Departments = await _context.Departments.ToListAsync()
            };
            return View(editModel);
        }

        public async Task<IActionResult> CompanyDelete(int id)
        {
            Company company = await _context.Companies.FindAsync(id);

            if(company == null)
            {
                return Redirect("/hrpayroll/admin/companyindex");
            }
            try
            {
                _context.Companies.Remove(company);
                await _context.SaveChangesAsync();
                return Redirect("/hrpayroll/admin/companyindex");
            }
            catch
            {
                return Redirect("/hrpayroll/admin/companyindex");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompanyEdit(CompanyEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Company company = new Company()
                {
                    Name = model.Name,
                    DepartmentId = model.DepartmentId,
                    Id = model.Id
                };
                try
                {
                    _context.Companies.Update(company);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/companyindex");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/companyindex");
                }
            }
            else
            {
                model.Departments = await _context.Departments.ToListAsync();
                return View(model);
            }
        }

        [HttpPost]
        public async Task<JsonResult> FillDepartment(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }

            Department department = await _context.Departments.Where(d => Convert.ToString(d.Id) == id).FirstOrDefaultAsync();


            return Json(new { data = department, status = 200 });
        }

        [HttpGet]
        public async Task<IActionResult> BranchIndex()
        {
            BranchViewModel branchViewModel = new BranchViewModel()
            {
                Branches = await _context.Branches.Include(c => c.Company).ToListAsync(),
                Companies = await _context.Companies.ToListAsync()
            };
            return View(branchViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> BranchIndex(BranchViewModel model)
        {
            if (ModelState.IsValid)
            {
                Branch branch = new Branch()
                {
                    Name = model.BranchAddModel.Name,
                    CompanyId = model.BranchAddModel.CompanyId
                };
                try
                {
                    _context.Branches.Add(branch);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/branchindex");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/branchindex");
                }
            }
            else
            {

                model.Companies = await _context.Companies.ToListAsync();
                model.Branches = await _context.Branches.Include(c => c.Company).ToListAsync();
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BranchEdit(int id)
        {
            Branch branch = await _context.Branches.FindAsync(id);
            if(branch == null)
            {
                return Redirect("/hrpayroll/admin/branchindex");
            }
            BranchEditModel editModel = new BranchEditModel()
            {
                Id = branch.Id,
                Name = branch.Name,
                CompanyId = branch.CompanyId,
                Companies = await _context.Companies.ToListAsync()
            };
            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> BranchEdit(BranchEditModel model)
        {
            if (ModelState.IsValid)
            {
                Branch branch = new Branch()
                {
                    Id = model.Id,
                    Name = model.Name,
                    CompanyId = model.CompanyId
                };
                try
                {
                    _context.Branches.Update(branch);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/branchindex");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/branchindex");
                }
            }
            else
            {
                model.Companies = await _context.Companies.ToListAsync();
                return View(model);
            }
        }

        public async Task<IActionResult> BranchDelete(int id)
        {
            Branch branch = await _context.Branches.FindAsync(id);
            if(branch == null)
            {
                return Redirect("hrpayroll/admin/branchindex");
            }

            try
            {
                _context.Remove(branch);
                await _context.SaveChangesAsync();
                return Redirect("/hrpayroll/admin/branchindex");
            }
            catch
            {
                return Redirect("hrpayroll/admin/branchindex");
            }
        }

        [HttpGet]
        public async Task<IActionResult> PositionIndex()
        {
            PositionViewModel model = new PositionViewModel()
            {
                Positions = await _context.Positions.Include(c=>c.Company)
                                                        .ThenInclude(d=>d.Department)
                                                            .ToListAsync(),
                Companies = await _context.Companies.ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PositionIndex(PositionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Position position = new Position()
                {
                    Name = model.PositionAddModel.Name,
                    Salary = model.PositionAddModel.Salary,
                    CompanyId = model.PositionAddModel.CompanyId
                };
                try
                {
                    _context.Positions.Add(position);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/positionindex");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/positionindex");
                }
            }
            else
            {
                model.Positions = await _context.Positions.Include(c => c.Company)
                                                        .ThenInclude(d => d.Department)
                                                            .ToListAsync();
                model.Companies = await _context.Companies.ToListAsync();
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> PositionEdit(int id)
        {
            Position position = await _context.Positions.FindAsync(id);
            if(position == null)
            {
                return Redirect("/hrpayroll/admin/positionindex");
            }
            PositionEditModel positionEditModel = new PositionEditModel()
            {
                Name = position.Name,
                Salary = position.Salary,
                Companies = await _context.Companies.ToListAsync(),
                Id = position.Id,
                CompanyId = position.CompanyId
            };
            return View(positionEditModel);
        }

        [HttpPost]
        public async Task<IActionResult> PositionEdit(PositionEditModel model)
        {
            if (ModelState.IsValid)
            {
                Position position = new Position()
                {
                    Name = model.Name,
                    Salary = model.Salary,
                    CompanyId = model.CompanyId,
                    Id = model.Id
                };
                try
                {
                    _context.Positions.Update(position);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/positionindex");
                }
                catch
                {
                    return Redirect("/hrpayroll/admin/positionindex");
                }
            }
            else
            {
                model.Companies = await _context.Companies.ToListAsync();
                return View(model);
            }
        }

        public async Task<IActionResult> PositionDelete(int id)
        {
            Position position = await _context.Positions.FindAsync(id);
            if(position == null)
            {
                return Redirect("/hrpayroll/admin/positionindex");
            }

            try
            {
                _context.Positions.Remove(position);
                await _context.SaveChangesAsync();
                return Redirect("/hrpayroll/admin/positionindex");
            }
            catch
            {
                return Redirect("/hrpayroll/admin/positionindex");
            }
        }
        
        public async Task<IActionResult> RoleIndex()
        {
            List<IdentityRole> identityRoles = await _context.Roles.ToListAsync();
            return View(identityRoles);
        }

        public async Task<IActionResult> RoleDetails(string id)
        {
            IdentityRole role = await _context.Roles.FindAsync(id);

            List<AppUser> appUsers = new List<AppUser>();
            List<AppUser> users = new List<AppUser>();
            foreach (AppUser user in _context.Users)
            {
                if(await userManager.GetRolesAsync(user) != null)
                {
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        appUsers.Add(user);
                    }
                    else
                    {
                        users.Add(user);
                    }
                }
            }
            
            RoleUserEditViewModel roleUserEditViewModel = new RoleUserEditViewModel()
            {
                IdentityRole = role,
                AppUsersInThisRole = appUsers,
                OtherAppUsers = users
            };
            return View(roleUserEditViewModel);
        }

        public async Task<IActionResult> RoleAdd(string id, string roleId)
        {
            AppUser appUser = await _context.Users.FindAsync(id);
            IdentityRole identityRole = await _context.Roles.FindAsync(roleId);
            IList<string> userRoles = await userManager.GetRolesAsync(appUser);
            if (userRoles != null)
            {
                IdentityResult result = await userManager.RemoveFromRolesAsync(appUser, userRoles);
                if (result.Succeeded)
                {
                    IdentityResult identityResult = await userManager.AddToRoleAsync(appUser, identityRole.Name);
                    if (identityResult.Succeeded)
                    {
                        return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
                    }
                    else
                    {
                        return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
                    }
                }
                else
                {
                    return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
                }
            }
            else
            {
                IdentityResult identityResult = await userManager.AddToRoleAsync(appUser, identityRole.Name);
                if (identityResult.Succeeded)
                {
                    return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
                }
                else
                {
                    return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
                }
            }
        }
        public async Task<IActionResult> RoleDelete(string id, string roleId)
        {
            AppUser appUser = await _context.Users.FindAsync(id);
            IdentityRole identityRole = await _context.Roles.FindAsync(roleId);
            IdentityResult result = await userManager.RemoveFromRoleAsync(appUser, identityRole.Name);
            if (result.Succeeded)
            {
                return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
            }
            else
            {
                return Redirect($"/hrpayroll/admin/roledetails?id={roleId}");
            }
        }

        public async Task<IActionResult> Holiday()
        {
            List<WorkPlace> workPlaces = await _context.WorkPlaces.Include(e => e.Employee).ToListAsync();
            
            return View(workPlaces);
        }

        [HttpGet]
        public async Task<IActionResult> HolidayAdd(int id)
        {
            Employee employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return Redirect("/hrpayroll/admin/holiday");
            }
            HolidayAddModel holidayAddModel = new HolidayAddModel()
            {
                Employee = employee,
                EmployeeId = employee.Id,
                Holidays = await _context.Holidays.Where(e=>e.EmployeeId ==  employee.Id).ToListAsync()
            };
            return View(holidayAddModel);
        }

        [HttpPost]
        public async Task<IActionResult> HolidayAdd(HolidayAddModel model)
        {
            if (ModelState.IsValid)
            {
                List<Absent> absents = await _context.Absents.Where(e => e.EmployeeId == model.EmployeeId).ToListAsync();
                List<Holiday> holidays = await _context.Holidays.Where(e => e.EmployeeId == model.EmployeeId).ToListAsync();
                Employee employee = await _context.Employees.FindAsync(model.EmployeeId);
                DateTime startDate = Convert.ToDateTime(model.StartDate);
                DateTime endDate = Convert.ToDateTime(model.EndDate);
                TimeSpan span = endDate.Subtract(startDate);
                if(startDate < Convert.ToDateTime(employee.WorkDate) && endDate < Convert.ToDateTime(employee.WorkDate))
                {
                    model.Employee = employee;
                    model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                    ModelState.AddModelError("StartDate", "Date is not valid");
                    ModelState.AddModelError("EndDate", "Date is not valid");
                    return View(model);
                }
                else if(span.TotalDays > 30)
                {
                    model.Employee = employee;
                    model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                    ModelState.AddModelError("EndDate", "Holiday cannot be long from 30 days");
                    return View(model);
                }
                else if (startDate > endDate)
                {
                    model.Employee = employee;
                    model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                    ModelState.AddModelError("StartDate", "Day is not valid");
                    return View(model);
                }
                foreach (var item in absents)
                {
                    DateTime absentStart = Convert.ToDateTime(item.StartDate);
                    DateTime absentEnd = Convert.ToDateTime(item.EndDate);
                    if (startDate<=absentEnd && startDate>= absentStart)
                    {
                        model.Employee = employee;
                        model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                        ModelState.AddModelError("StartDate", "This date employee has absent");
                        return View(model);
                    }
                    else if (endDate <= absentEnd && endDate >= absentStart)
                    {
                        model.Employee = employee;
                        model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                        ModelState.AddModelError("EndDate", "This date employee has absent");
                        return View(model);
                    }
                }
                foreach (var item in holidays)
                {
                    DateTime holidayStart = Convert.ToDateTime(item.StartDate);
                    DateTime holidayEnd = Convert.ToDateTime(item.EndDate);
                    if (startDate<=holidayEnd && startDate>=holidayStart)
                    {
                        model.Employee = employee;
                        model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                        ModelState.AddModelError("StartDate", "This date employee has holiday");
                        return View(model);
                    }
                    else if (endDate <= holidayEnd && endDate >= holidayStart)
                    {
                        model.Employee = employee;
                        model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                        ModelState.AddModelError("EndDate", "This date employee has holiday");
                        return View(model);
                    }
                }
                Holiday holiday = new Holiday()
                {
                    StartDate = Convert.ToString(model.StartDate),
                    EndDate = Convert.ToString(model.EndDate),
                    EmployeeId = model.EmployeeId
                };
                try
                {
                    _context.Holidays.Add(holiday);
                    await _context.SaveChangesAsync();
                    return Redirect($"/hrpayroll/admin/holidayadd?id={model.EmployeeId}");
                }
                catch
                {
                    model.Employee = employee;
                    model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == employee.Id).ToListAsync();
                    return View(model);
                }
            }
            else
            {
                model.Employee = await _context.Employees.FindAsync(model.EmployeeId);
                model.Holidays = await _context.Holidays.Where(e => e.EmployeeId == model.EmployeeId).ToListAsync();
                return View(model);
            }
        }

        public async Task<IActionResult> HolidayDelete(int id, int employeeId)
        {
            Holiday holiday = await _context.Holidays.FindAsync(id);
            if(holiday == null)
            {
                return Redirect($"/hrpayroll/admin/holidayadd?id={employeeId}");
            }
            try
            {
                _context.Holidays.Remove(holiday);
                await _context.SaveChangesAsync();
                return Redirect($"/hrpayroll/admin/holidayadd?id={employeeId}");
            }
            catch
            {
                return Redirect($"/hrpayroll/admin/holidayadd?id={employeeId}");
            }
        }


        public async Task<IActionResult> StipulationIndex()
        {
            List<Stipulation> stipulations = await _context.Stipulations.Include(a => a.Company).ToListAsync();
            return View(stipulations);
        }

        [HttpGet]
        public async Task<IActionResult> StipulationAdd()
        {
            StipulationAddModel stipulation = new StipulationAddModel()
            {
                Companies = await _context.Companies.ToListAsync()
            };
            return View(stipulation);
        }

        [HttpPost]
        public async Task<IActionResult> StipulationAdd(StipulationAddModel model)
        {
            if (ModelState.IsValid)
            {
                Stipulation stipulation = await _context.Stipulations.Where(e => e.CompanyId == model.CompanyId).FirstOrDefaultAsync();
                if(stipulation == null)
                {
                    Stipulation stipulationToDb = new Stipulation()
                    {
                        Limit = model.Limit,
                        Percent = model.Percent,
                        Amount = model.Amount,
                        CompanyId = model.CompanyId,
                        PercentOrAmount = model.PercentOrAmount
                    };
                    _context.Stipulations.Add(stipulationToDb);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/admin/stipulationindex");
                }
                else
                {
                    model.Companies = await _context.Companies.ToListAsync();
                    ModelState.AddModelError("CompanyId", "This company has stipulation");
                    return View(model);
                }
            }
            else
            {
                model.Companies = await _context.Companies.ToListAsync();
                return View(model);
            }
        }

        public async Task<IActionResult> StipulationDelete(int id)
        {
            Stipulation stipulation = await _context.Stipulations.FindAsync(id);
            _context.Stipulations.Remove(stipulation);
            await _context.SaveChangesAsync();
            return Redirect("/hrpayroll/admin/stipulationindex");
        }
        [HttpPost]
        public async Task<JsonResult> FindEmployee(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }
            Employee employee = new Employee();
            string[] data = id.Split(" ");
            string name = "";
            string surname = "";
            string fathername = "";
            if (data.Length == 2 && data[1] != "")
            {
                name = data[0].ToLower();
                surname = data[1].ToLower();

                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name && e.Surname == surname)
                                    .FirstOrDefaultAsync();
                if (employee == null)
                {
                    employee = await _context
                                         .Employees
                                           .Where(e => e.Name.ToLower() == surname && e.Surname == name)
                                             .FirstOrDefaultAsync();
                }
            }
            else if (data.Length == 2 && data[1] == "")
            {
                name = data[0].ToLower();
                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name)
                                    .FirstOrDefaultAsync();

                if (employee == null)
                {
                    employee = await _context
                                 .Employees
                                   .Where(e => e.Surname.ToLower() == name)
                                    .FirstOrDefaultAsync();
                }
            }
            else if (data.Length == 1)
            {
                name = data[0].ToLower();
                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name)
                                    .FirstOrDefaultAsync();
                if (employee == null)
                {
                    employee = await _context
                                         .Employees
                                           .Where(e => e.Name.ToLower() == surname)
                                             .FirstOrDefaultAsync();
                }
                if (employee == null)
                {
                    employee = await _context
                                 .Employees
                                   .Where(e => e.Surname.ToLower() == name)
                                    .FirstOrDefaultAsync();
                    if (employee == null)
                    {
                        employee = await _context
                                             .Employees
                                               .Where(e => e.Surname.ToLower() == surname)
                                                 .FirstOrDefaultAsync();
                    }
                }
            }
            else if (data.Length == 3)
            {
                name = data[0];
                surname = data[1];
                fathername = data[2];
                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name && e.Surname.ToLower() == surname && e.Fathername.ToLower() == fathername)
                                    .FirstOrDefaultAsync();
                if (employee == null)
                {
                    employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == surname && e.Surname.ToLower() == name && e.Fathername.ToLower() == fathername)
                                    .FirstOrDefaultAsync();
                }
            }



            return Json(new { data = Convert.ToString(employee.Id), status = 200 });
        }
    }
}