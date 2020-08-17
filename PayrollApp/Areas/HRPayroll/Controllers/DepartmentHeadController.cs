using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HRPayroll.Models;
using PayrollApp.Areas.HRPayroll.Models.ViewModels;
using PayrollApp.Areas.HRPayroll.Models.ViewModels.DepartmentHeadModels;

namespace PayrollApp.Areas.HRPayroll.Controllers
{
    [Area("HRPayroll")]
    [Authorize(Roles = "DepartmentHead")]
    public class DepartmentHeadController : Controller
    {
        private readonly PayrollAppDbContext _context;
        private UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IPasswordHasher<AppUser> passwordHasher;
        public DepartmentHeadController(PayrollAppDbContext context,
                                                    UserManager<AppUser> _userManager,
                                                        SignInManager<AppUser> _signInManager,
                                                            IPasswordHasher<AppUser> _passwordHash)
        {
            _context = context;
            userManager = _userManager;
            signInManager = _signInManager;
            passwordHasher = _passwordHash;
        }

        public async Task<IActionResult> EmployeeIndex()
        {
            UserDepartmentId userDepartmentId = await _context.userDepartmentIds.FirstOrDefaultAsync();
            WorkPlace work = await _context.WorkPlaces.Where(w => w.Position.Company.DepartmentId == userDepartmentId.DeparmentId).FirstOrDefaultAsync();
            List<WorkPlace> workPlaces = await _context
                                            .WorkPlaces
                                                .Where(w => w.EmployeeId == work.EmployeeId && w.PositionId == work.PositionId)
                                                 .Include(e => e.Employee)
                                                    .Include(p => p.Position)
                                                      .ThenInclude(c => c.Company)
                                                        .ThenInclude(d => d.Department)
                                                            .ToListAsync();
            return View(workPlaces);
        }



        public async Task<IActionResult> EmployeeDetails(int id)
        {
            WorkPlace work = await _context.WorkPlaces.Where(w => w.EmployeeId == id).FirstOrDefaultAsync();

            AdminEmployeeModel adminEmployeeModel = new AdminEmployeeModel()
            {
                WorkPlace =  _context
                                  .WorkPlaces
                                      .Where(w => w.EmployeeId ==  id && w.PositionId == work.PositionId)
                                         .Include(e => e.Employee)
                                           .Include(p => p.Position)
                                              .ThenInclude(c => c.Company)
                                                .ThenInclude(d => d.Department)
                                                  .FirstOrDefault(),
                OldWorkPlaces = await _context.OldWorkPlaces.Where(o => o.EmployeeId == id).ToListAsync()

            };
            return View(adminEmployeeModel);
        }

        [HttpGet]
        public async Task<IActionResult> BonusPenalty(int id)
        {
            Employee employee = await _context.Employees.FindAsync(id);

            BonusPenaltyAddModel bonusPenaltyAddModel = new BonusPenaltyAddModel()
            {
                Employee = employee,
                BonusPenalties = await _context.BonusPenalties.Where(e=>e.EmployeeId==id).ToListAsync()
            };
            return View(bonusPenaltyAddModel);
        }

        [HttpPost]
        public async Task<IActionResult> BonusPenalty(BonusPenaltyAddModel model)
        {
            if (ModelState.IsValid)
            {
                model.Employee = await _context.Employees.FindAsync(model.EmployeeId);
                if (Convert.ToDateTime(model.Date) > DateTime.Now)
                {
                    model.BonusPenalties = await _context
                                                   .BonusPenalties
                                                     .Where(e => e.EmployeeId == model.EmployeeId)
                                                       .ToListAsync();
                    model.Employee = await _context.Employees.FindAsync(model.EmployeeId);
                    ModelState.AddModelError("Date", "Date is not valid");
                    return View(model);
                }
                if (Convert.ToDateTime(model.Date) < Convert.ToDateTime(model.Employee.WorkDate))
                {
                    model.BonusPenalties = await _context
                                                   .BonusPenalties
                                                     .Where(e => e.EmployeeId == model.EmployeeId)
                                                       .ToListAsync();
                    model.Employee = await _context.Employees.FindAsync(model.EmployeeId);
                    ModelState.AddModelError("Date", "Date is not valid");
                    return View(model);
                }
                BonusPenalty bonusPenalty = new BonusPenalty()
                {
                    Amount = model.Amount,
                    BonusOrPenalty = model.BonusOrPenalty,
                    Date = Convert.ToString(model.Date),
                    EmployeeId = model.EmployeeId,
                    Reason = model.Reason
                };
                _context.BonusPenalties.Add(bonusPenalty);
                await _context.SaveChangesAsync();
                return Redirect($"/hrpayroll/departmenthead/bonuspenalty?id={model.EmployeeId}");
            }
            else
            {
                model.Employee = await _context.Employees.FindAsync(model.EmployeeId);
                return View(model);
            }
        }
        
        public async Task<IActionResult> BonusPenaltyDelete(int id)
        {
            BonusPenalty bonusPenalty = await _context.BonusPenalties.FindAsync(id);
            if(bonusPenalty == null)
            {
                return Redirect("/hrpayroll/departmenthead/companyindex");
            }
            try
            {
                _context.BonusPenalties.Remove(bonusPenalty);
                await _context.SaveChangesAsync();
                return Redirect("/hrpayroll/departmenthead/companyindex");
            }
            catch
            {
                return Redirect("/hrpayroll/departmenthead/companyindex");
            }
        }
    }
}