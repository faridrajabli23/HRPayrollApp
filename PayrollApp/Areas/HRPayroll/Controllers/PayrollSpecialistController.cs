using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HRPayroll.Models;
using PayrollApp.Areas.HRPayroll.Models.ViewModels;
using PayrollApp.Areas.HRPayroll.Models.ViewModels.PayrollSpecialist;

namespace PayrollApp.Areas.HRPayroll.Controllers
{
    [Area("HRPayroll")]
    [Authorize(Roles ="PayrollSpecialist")]
    public class PayrollSpecialistController : Controller
    {
        private readonly PayrollAppDbContext _context;
        public PayrollSpecialistController(PayrollAppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> EmployeeIndex()
        {
            Add add = new Add()
            {
                EmployeePays = await _context.EmployeePays
                                                               .Include(p => p.Position)
                                                                 .ThenInclude(c => c.Company)
                                                                    .ThenInclude(d => d.Department)
                                                                            .ToListAsync()
            };

            return View(add);
        }

        [HttpPost]
        public ActionResult EmployeeIndex(string id)
        {
            return View(id);
        }

        [HttpGet]
        public async Task<IActionResult> EmployeePayment(string id)
        {

            string[] arr = id.Split(",");

            List<EmployeePay> checkedEmployeePays = new List<EmployeePay>();

            foreach (var item in arr)
            {
                checkedEmployeePays.Add(await _context.EmployeePays
                                                        .Include(e => e.Position)
                                                            .ThenInclude(c => c.Company)
                                                                .ThenInclude(d => d.Department)
                                                                    .Where(a => a.Id == Convert.ToInt32(item))
                                                                       .FirstOrDefaultAsync());
            }
            SalaryCalculater salaryCalculater = new SalaryCalculater(_context);
            CalcViewModel last = new CalcViewModel();

            
            CalcViewModel model = new CalcViewModel()
            {
                CalculatedEmployeePays = salaryCalculater.Calculator(checkedEmployeePays)
            };
            
            return View(model);
        }


        public async Task<IActionResult> EmployeePaymentPay(string employeeId, string employeePayId)
        {
            string[] employeeIds = employeeId.Split(",");
            string[] employeePayIds = employeePayId.Split(",");
            foreach (var employee in employeeIds)
            {
                if(employee != " "&& employee != "")
                {
                    Employee emp = await _context.Employees.FindAsync(Convert.ToInt32(employee));
                    emp.WorkDate = Convert.ToString(DateTime.Now);
                    _context.Employees.Update(emp);
                }
            }
            foreach (var empPay in employeePayIds)
            {
                if(empPay != " " && empPay != "")
                {
                    EmployeePay employeePay = await _context.EmployeePays.FindAsync(Convert.ToInt32(empPay));
                    _context.EmployeePays.Remove(employeePay);
                }
            }
            await _context.SaveChangesAsync();
            return Redirect("/hrpayroll/payrollspecialist/employeeindex");
        }

        public async Task<IActionResult> EmployeeIndexInfo()
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