using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Areas.HRPayroll.Models;
using PayrollApp.Areas.HRPayroll.Models.ViewModels;

namespace PayrollApp.Areas.HRPayroll.Controllers
{
    [Area("HRPayroll")]
    [Authorize(Roles = "HR")]
    public class EmployeeController : Controller
    {
        private readonly PayrollAppDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EmployeeController(PayrollAppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }


        //--Start-- Employe Add, Edit, Delete, Index 
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = new List<Employee>();
            employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(EmployeeAddModel employee)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(employee.Photo != null)
                {
                    try
                    {
                        string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await employee.Photo.CopyToAsync(fileStream);
                        }
                    }
                    catch
                    {
                        return Redirect("/hrpayroll/employee/index");
                    }
                }

                Employee employeeToDb = new Employee()
                {
                    Name = employee.Name,
                    Surname = employee.Surname,
                    Fathername = employee.Fathername,
                    Address = employee.Address,
                    Birthday = Convert.ToString(employee.Birthday),
                    RegisterAddress = employee.RegisterAddress,
                    Education = employee.Education,
                    PassportExpDate = Convert.ToString(employee.PassportExpDate),
                    Gender = employee.Gender,
                    MaritalStatus = employee.MaritalStatus,
                    PassportId = employee.PassportId,
                    Photo = uniqueFileName
                };

                try
                {
                    _context.Employees.Add(employeeToDb);
                    await _context.SaveChangesAsync();
                    return Redirect("/hrpayroll/employee/index");
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/index");
                }
            }
            else
            {
                return View(employee);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/hrpayroll/employee/index");
            }

            try
            {
                Employee editEmployee = await _context.Employees.FindAsync(id);

                if (editEmployee == null)
                {
                    return Redirect("/hrpayroll/employee/index");
                }
                EmployeeEditModel employeeEditModel = new EmployeeEditModel()
                {
                    Id = editEmployee.Id,
                    Name = editEmployee.Name,
                    Surname = editEmployee.Surname,
                    Fathername = editEmployee.Fathername,
                    Address = editEmployee.Address,
                    Birthday = Convert.ToString(editEmployee.Birthday),
                    RegisterAddress = editEmployee.RegisterAddress,
                    Education = editEmployee.Education,
                    PassportExpDate = Convert.ToString(editEmployee.PassportExpDate),
                    Gender = editEmployee.Gender,
                    MaritalStatus = editEmployee.MaritalStatus,
                    PassportId = editEmployee.PassportId,
                    PhotoPath = editEmployee.Photo
                };
                return View(employeeEditModel);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id , EmployeeEditModel employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = null;
                    if (employee.Photo != null)
                    {
                        string fileName = employee.PhotoPath;
                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads", fileName);
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        else
                        {
                            return RedirectToAction(nameof(Index));
                        }

                        string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.Photo.FileName;
                        string filePath = Path.Combine(uploadFolder, uniqueFileName);
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await employee.Photo.CopyToAsync(fileStream);
                        }
                    }

                    if (uniqueFileName == null)
                    {
                        uniqueFileName = employee.PhotoPath;
                    }
                    Employee employeeDb = new Employee()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Fathername = employee.Fathername,
                        Address = employee.Address,
                        Birthday = Convert.ToString(employee.Birthday),
                        RegisterAddress = employee.RegisterAddress,
                        Education = employee.Education,
                        PassportExpDate = Convert.ToString(employee.PassportExpDate),
                        Gender = employee.Gender,
                        MaritalStatus = employee.MaritalStatus,
                        PassportId = employee.PassportId,
                        Photo = uniqueFileName
                    };
                    if (id != employeeDb.Id)
                    {
                        return NotFound();
                    }
                    _context.Update(employeeDb);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/index");
                }
            }
            else
            {
                return View(employee);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                var fileName = employee.Photo;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "uploads", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }


                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Redirect("/hrpayroll/employee/index");
            }
        }

        public async Task<IActionResult> Details(string id)
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
        //--End-- Employee Add, Edit, Delete




        //--Start-- Old work place Add, Edit, Delete, Index

        [HttpGet]
        public async Task<IActionResult> OldWorkIndex()
        {
            List<Employee> employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> OldWorkAdd(int? id)
        {
            if(id == null)
            {
                return Redirect("hrpayroll/employee/oldworkindex");
            }
            try
            {
                OldWorkAddModel oldWorkAddModel = new OldWorkAddModel()
                {
                    Employee = await _context.Employees.FindAsync(id),
                    OldWorkPlaces = await _context.OldWorkPlaces.Where(w => w.EmployeeId == id).ToListAsync()
                };
                return View(oldWorkAddModel);
            }
            catch
            {
                return Redirect("hrpayroll/employee/oldworkindex");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OldWorkAdd(OldWorkAddModel oldWorkPlace)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    OldWorkPlace oldWork = new OldWorkPlace()
                    {
                        Name = oldWorkPlace.Name,
                        EntryDate = Convert.ToString(oldWorkPlace.EntryDate),
                        EndDate = Convert.ToString(oldWorkPlace.EndDate),
                        EndReason = oldWorkPlace.EndReason,
                        EmployeeId = oldWorkPlace.EmployeeId
                    };
                    DateTime start = Convert.ToDateTime(oldWorkPlace.EntryDate);
                    DateTime end = Convert.ToDateTime(oldWorkPlace.EndDate);
                    if (start > end)
                    {
                        oldWorkPlace.OldWorkPlaces = await _context.OldWorkPlaces
                                                .Where(w => w.EmployeeId == oldWorkPlace.EmployeeId)
                                                    .ToListAsync();
                        oldWorkPlace.Employee = await _context.Employees.FindAsync(oldWorkPlace.EmployeeId);
                        ModelState.AddModelError("EntryDate", "Entry date cannot be after from end date");
                        return View(oldWorkPlace);
                    }

                    _context.OldWorkPlaces.Add(oldWork);
                    await _context.SaveChangesAsync();

                    return Redirect($"/hrpayroll/employee/oldworkdetails?id={oldWorkPlace.EmployeeId}");
                }
                catch
                {
                    return Redirect($"/hrpayroll/employee/oldworkdetails?id={oldWorkPlace.EmployeeId}");
                }
            }
            else
            {
                oldWorkPlace.OldWorkPlaces = await _context.OldWorkPlaces
                                                .Where(w => w.EmployeeId == oldWorkPlace.EmployeeId)
                                                    .ToListAsync();
                oldWorkPlace.Employee = await _context.Employees.FindAsync(oldWorkPlace.EmployeeId);
                return View(oldWorkPlace);
            }
        }

        [HttpGet]
        public async Task<IActionResult> OldWorkDetails(int? id)
        {
            if (id == null)
            {
                return Redirect("/hrpayroll/employee/oldworkindex");
            }

            try
            {
                OldWorkDetailModel oldWorkDetailModel = new OldWorkDetailModel()
                {
                    OldWorkPlaces = await _context.OldWorkPlaces.Where(w => w.EmployeeId == id).ToListAsync(),
                    Employee = await _context.Employees.FindAsync(id)
                };
                return View(oldWorkDetailModel);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/oldworkindex");
            }
        }

        [HttpGet]
        public async Task<IActionResult> OldWorkEdit(int? id)
        {
            if(id == null)
            {
                return Redirect("/hrpayroll/employee/oldworkindex");
            }
            try
            {
                OldWorkPlace oldWorkPlace = await _context.OldWorkPlaces.FindAsync(id);


                OldWorkEditModel oldWorkEditModel = new OldWorkEditModel()
                {
                    Id = oldWorkPlace.Id,
                    Name = oldWorkPlace.Name,
                    EntryDate = oldWorkPlace.EntryDate,
                    EndDate = oldWorkPlace.EndDate,
                    EndReason = oldWorkPlace.EndReason,
                    EmployeeId = oldWorkPlace.EmployeeId
                };
                return View(oldWorkEditModel);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/oldworkindex");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OldWorkEdit(OldWorkEditModel oldWorkEditModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    DateTime start = Convert.ToDateTime(oldWorkEditModel.EntryDate);
                    DateTime end = Convert.ToDateTime(oldWorkEditModel.EndDate);
                    if (start > end)
                    {
                        ModelState.AddModelError("EntryDate", "Entry date cannot be after from end date");
                        return View(oldWorkEditModel);
                    }

                    OldWorkPlace oldWorkPlace = new OldWorkPlace()
                    {
                        Id = oldWorkEditModel.Id,
                        Name = oldWorkEditModel.Name,
                        EntryDate = Convert.ToString(oldWorkEditModel.EntryDate),
                        EndDate = Convert.ToString(oldWorkEditModel.EndDate),
                        EmployeeId = oldWorkEditModel.EmployeeId,
                        EndReason = oldWorkEditModel.EndReason
                    };
                    _context.Update(oldWorkPlace);
                    await _context.SaveChangesAsync();
                    return Redirect($"/hrpayroll/employee/oldworkdetails?id={oldWorkEditModel.EmployeeId}");
                }
                catch
                {
                    return Redirect($"/hrpayroll/employee/oldworkdetails?id={oldWorkEditModel.EmployeeId}");
                }
            }
            else
            {
                return View(oldWorkEditModel);
            }
        }

        public async Task<IActionResult> OldWorkDelete(int? id)
        {
            try
            {
                OldWorkPlace oldWorkPlace = await _context.OldWorkPlaces.FindAsync(id);
                int empId = oldWorkPlace.EmployeeId;
                if (oldWorkPlace == null)
                {
                    return Redirect($"/hrpayroll/employee/oldworkindex");
                }
                _context.OldWorkPlaces.Remove(oldWorkPlace);
                await _context.SaveChangesAsync();
                return Redirect($"/hrpayroll/employee/oldworkdetails?id={empId}");
            }
            catch
            {
                return Redirect("/hrpayroll/employee/oldworkindex");
            }
        }
        //--End-- Old work place Add, Edit, Delete, Index



        //--Start--Work Place Add, Edit, Delete, Index

        [HttpGet]
        public async Task<IActionResult> WorkPlaceIndex()
        {
            List<Employee> employee = await _context.Employees.ToListAsync();
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> WorkPlaceAdd(int id)
        {
            try
            {
                WorkPlace model = await _context.WorkPlaces.Where(e => e.EmployeeId == id).FirstOrDefaultAsync();
                if(model != null)
                {
                    return Redirect($"/hrpayroll/employee/workplaceedit?id={id}");
                }
                WorkPlaceAddModel workPlaceAddModel = new WorkPlaceAddModel()
                {
                    Departments = await _context.Departments.ToListAsync(),
                    EmployeeId = id
                };
                return View(workPlaceAddModel);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/workplaceindex");
            }
        }

        [HttpPost]
        public async Task<IActionResult> WorkPlaceAdd(WorkPlaceAddModel workPlace)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Convert.ToDateTime(workPlace.StartDate) > DateTime.Now)
                    {
                        ModelState.AddModelError("StartDate", "Date is not valid");
                    }
                    WorkPlace work = new WorkPlace()
                    {
                        StartDate = Convert.ToString(workPlace.StartDate),
                        EmployeeId = Convert.ToInt32(workPlace.EmployeeId),
                        PositionId = Convert.ToInt32(workPlace.PositionId)
                    };
                    Employee employee = await _context.Employees.FindAsync(workPlace.EmployeeId);
                    employee.WorkDate = Convert.ToString(workPlace.StartDate);
                    _context.Employees.Update(employee);

                    EmployeePay employeePay = new EmployeePay()
                    {
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Fathername = employee.Fathername,
                        EmployeeId = employee.Id,
                        Gender = employee.Gender,
                        WorkDate = workPlace.StartDate,
                        PassportId = employee.PassportId,
                        PositionId = workPlace.PositionId
                    };
                    _context.EmployeePays.Add(employeePay);

                    _context.WorkPlaces.Add(work);
                    await _context.SaveChangesAsync();

                    return Redirect($"/hrpayroll/employee/workplacedetails?id={workPlace.EmployeeId}");
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/workplaceindex");
                }
            }
            else
            {
                return View(workPlace);
            }
        }

        [HttpGet]
        public async Task<IActionResult> WorkPlaceEdit(int id)
        {
            try
            {
                WorkPlace model = await _context.WorkPlaces.Where(e => e.EmployeeId == id).FirstOrDefaultAsync();
                if (model == null)
                {
                    return Redirect($"/hrpayroll/employee/workplaceindex");
                }
                WorkPlaceEdit workPlaceEdit = new WorkPlaceEdit()
                {
                    Id = model.Id,
                    Departments = await _context.Departments.ToListAsync(),
                    PositionId = model.PositionId,
                    Position = await _context.Positions.FindAsync(model.PositionId),
                    StartDate = model.StartDate,
                    EmployeeId = id
                };
                return View(workPlaceEdit);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/workplaceindex");
            }
        }

        [HttpPost]
        public async Task<IActionResult> WorkPlaceEdit(WorkPlaceEdit workPlace)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Convert.ToDateTime(workPlace.StartDate) > DateTime.Now)
                    {
                        workPlace.Departments = await _context.Departments.ToListAsync();
                        ModelState.AddModelError("StartDate", "Date is not valid");
                        return View(workPlace);
                    }
                    if (Convert.ToDateTime(workPlace.OldWorkEndDate) > DateTime.Now && Convert.ToDateTime(workPlace.StartDate) < Convert.ToDateTime(workPlace.OldWorkEndDate))
                    {
                        workPlace.Departments = await _context.Departments.ToListAsync();
                        ModelState.AddModelError("OldWorkEndDate", "Date is not valid");
                        return View(workPlace);
                    }
                    WorkPlace work = new WorkPlace()
                    {
                        Id = workPlace.Id,
                        StartDate = Convert.ToString(workPlace.StartDate),
                        EmployeeId = Convert.ToInt32(workPlace.EmployeeId),
                        PositionId = Convert.ToInt32(workPlace.PositionId)
                    };
                    Employee employee = await _context.Employees.FindAsync(workPlace.EmployeeId);
                    Position position = await _context.Positions.Include(c => c.Company).Where(a => a.Id == workPlace.PositionId).FirstOrDefaultAsync();
                    
                    OldWorkPlace oldWork = new OldWorkPlace()
                    {
                        EmployeeId = workPlace.EmployeeId,
                        Name = position.Company.Name,
                        Position = position.Name,
                        EntryDate = workPlace.StartDate,
                        EndDate = Convert.ToString(workPlace.OldWorkEndDate),
                        EndReason = "Change of position"
                    };
                    _context.OldWorkPlaces.Add(oldWork);

                    EmployeePay employeePay = new EmployeePay()
                    {
                        Name = employee.Name,
                        Surname = employee.Surname,
                        Fathername = employee.Fathername,
                        EmployeeId = employee.Id,
                        Gender = employee.Gender,
                        WorkDate = workPlace.StartDate,
                        PassportId = employee.PassportId,
                        PositionId = workPlace.PositionId
                    };
                    _context.EmployeePays.Add(employeePay);

                    _context.WorkPlaces.Update(work);
                    await _context.SaveChangesAsync();

                    return Redirect($"/hrpayroll/employee/workplacedetails?id={workPlace.EmployeeId}");
                }
                catch
                {
                    return Redirect("/hrpayroll/workplace/index");
                }
            }
            else
            {
                return View(workPlace);
            }
        }

        [HttpPost]
        public async Task<JsonResult> FillCompanies(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }

            List<Company> companies = await _context.Companies.Where(s => s.DepartmentId == Convert.ToInt32(id)).ToListAsync();

            return Json(new { data = companies, status = 200 });
        }

        [HttpPost]
        public async Task<JsonResult> FillBranch(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }

            List<Branch> branches = await _context.Branches.Where(s => s.CompanyId == Convert.ToInt32(id)).ToListAsync();

            return Json(new { data = branches, status = 200 });
        }

        [HttpPost]
        public async Task<JsonResult> FillPosition(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }

            List<Position> positions = await _context.Positions.Where(s => s.CompanyId == Convert.ToInt32(id)).ToListAsync();

            return Json(new { data = positions, status = 200 });
        }

        [HttpPost]
        public async Task<JsonResult> FillSalary(string id)
        {
            if (id == null)
            {
                return Json(new { status = 400, message = "asd" });
            }

            Position positions = await _context.Positions.FindAsync(Convert.ToInt32(id));
            return Json(new { data = positions.Salary, status = 200 });
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
            if(data.Length == 2  && data[1]!="")
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
            else if(data.Length == 2 && data[1] == "")
            {
                name = data[0].ToLower();
                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name)
                                    .FirstOrDefaultAsync();
                
                if(employee == null)
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
            else if(data.Length == 3)
            {
                name = data[0];
                surname = data[1];
                fathername = data[2];
                employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == name && e.Surname.ToLower() == surname && e.Fathername.ToLower()==fathername)
                                    .FirstOrDefaultAsync();
                if(employee == null)
                {
                    employee = await _context
                                 .Employees
                                   .Where(e => e.Name.ToLower() == surname && e.Surname.ToLower() == name && e.Fathername.ToLower() == fathername)
                                    .FirstOrDefaultAsync();
                }
            }
            
            

            return Json(new { data = Convert.ToString(employee.Id), status = 200 });
        }

        [HttpGet]
        public async Task<IActionResult> WorkPlaceDetails(int? id)
        {
            try
            {
                var work = await _context.WorkPlaces.Where(w => w.EmployeeId == id).FirstOrDefaultAsync();
                WorkPlace workPlace = await _context
                                                    .WorkPlaces
                                                     .Where(w => w.EmployeeId == id && w.PositionId == work.PositionId)
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
                    Employee employee = await _context.Employees.FindAsync(id);
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
                        OldWorkPlaces = await _context.OldWorkPlaces.Where(e => e.EmployeeId == id).ToListAsync()
                    };

                    return View(workPlaceDetail);
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/workplaceindex");
                }
            }
        }

        //--End-- Work Place Add, Edit, Delete, Index 


        [HttpGet]
        public async Task<IActionResult> AbsentTable()
        {
            List<WorkPlace> employees = await _context.WorkPlaces.Include(e=>e.Employee).ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> AbsentTableAdd(int id)
        {
            try
            {
                Employee employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    return Redirect("/hrpayroll/employee/absenttable");
                }

                AbsentAddModel absentAddModel = new AbsentAddModel()
                {
                    Employee = employee,
                    AbsentReasons = await _context.AbsentReasons.ToListAsync(),
                    Absents = await _context.Absents.Where(e => e.EmployeeId == id).Include(r => r.AbsentReason).ToListAsync()
                };
                return View(absentAddModel);
            }
            catch
            {
                return Redirect("/hrpayroll/employee/absenttable");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AbsentTableAdd(AbsentAddModel absentAddModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Employee employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                    List<Holiday> holidays = await _context.Holidays.Where(h => h.EmployeeId == absentAddModel.EmployeeId).ToListAsync();
                    List<Absent> absents = await _context.Absents.Where(a => a.EmployeeId == absentAddModel.EmployeeId).ToListAsync();
                    DateTime absentStart = Convert.ToDateTime(absentAddModel.StartDate);
                    DateTime absentEnd = Convert.ToDateTime(absentAddModel.EndDate);
                    TimeSpan timeSpan = absentEnd.Subtract(absentEnd);
                    int interval = Convert.ToInt32(timeSpan.Days) + 1;

                    if (absentStart > Convert.ToDateTime(absentAddModel.EndDate))
                    {
                        absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                        absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                        absentAddModel.Absents = await _context.Absents
                                                                .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                    .Include(r => r.AbsentReason)
                                                                        .ToListAsync();
                        ModelState.AddModelError("StartDate", "Start date cannot after from end date");
                        return View(absentAddModel);
                    }
                    else if (Convert.ToDateTime(absentAddModel.EndDate) > DateTime.Now)
                    {
                        absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                        absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                        absentAddModel.Absents = await _context.Absents
                                                                .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                    .Include(r => r.AbsentReason)
                                                                        .ToListAsync();
                        ModelState.AddModelError("EndDate", "End date cannot be written for the future");
                        return View(absentAddModel);
                    }
                    else if (absentStart <= Convert.ToDateTime(employee.WorkDate) && absentEnd <= Convert.ToDateTime(employee.WorkDate))
                    {
                        absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                        absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                        absentAddModel.Absents = await _context.Absents
                                                                .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                    .Include(r => r.AbsentReason)
                                                                        .ToListAsync();
                        ModelState.AddModelError("StartDate", "Start date cannot be written before the employee gets to work");
                        ModelState.AddModelError("EndDate", "End date cannot be written before the employee gets to work");
                        return View(absentAddModel);
                    }
                    foreach (var item in absents)
                    {
                        DateTime absentStartDb = Convert.ToDateTime(item.StartDate);
                        DateTime absentEndDb = Convert.ToDateTime(item.EndDate);
                        if (absentStart <= absentEndDb && absentStart >= absentStartDb)
                        {
                            absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                            absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                            absentAddModel.Absents = await _context.Absents
                                                                    .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                        .Include(r => r.AbsentReason)
                                                                            .ToListAsync();
                            ModelState.AddModelError("StartDate", "This date already employee has absent");
                            return View(absentAddModel);
                        }
                        else if (absentEnd <= absentEndDb && absentEnd >= absentStartDb)
                        {
                            absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                            absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                            absentAddModel.Absents = await _context.Absents
                                                                    .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                        .Include(r => r.AbsentReason)
                                                                            .ToListAsync();
                            ModelState.AddModelError("EndDate", "This date already employee has absent");
                            return View(absentAddModel);
                        }
                    }
                    foreach (var item in holidays)
                    {
                        DateTime holidayStart = Convert.ToDateTime(item.StartDate);
                        DateTime holidayEnd = Convert.ToDateTime(item.EndDate);
                        if (absentStart <= holidayEnd && absentStart >= holidayStart)
                        {
                            absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                            absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                            absentAddModel.Absents = await _context.Absents
                                                                    .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                        .Include(r => r.AbsentReason)
                                                                            .ToListAsync();
                            ModelState.AddModelError("StartDate", "This date employee in holiday.Cannot be written absent this date");
                            return View(absentAddModel);
                        }
                        else if (absentEnd <= holidayEnd && absentEnd >= holidayStart)
                        {
                            absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                            absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                            absentAddModel.Absents = await _context.Absents
                                                                    .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                        .Include(r => r.AbsentReason)
                                                                            .ToListAsync();
                            ModelState.AddModelError("EndDate", "This date employee in holiday.Cannot be written absent this date");
                            return View(absentAddModel);
                        }
                    }
                    AbsentReason absentReason = await _context.AbsentReasons.FindAsync(absentAddModel.AbsentReasonId);
                    if (interval > 5 && absentReason.ExcusableOrInexcusable == "Inexcuable")
                    {
                        WorkPlace workPlace = await _context.WorkPlaces.Where(e => e.EmployeeId == absentAddModel.EmployeeId).FirstOrDefaultAsync();
                        _context.WorkPlaces.Remove(workPlace);

                        OldWorkPlace oldWork = new OldWorkPlace()
                        {
                            EmployeeId = absentAddModel.EmployeeId,
                            EntryDate = workPlace.StartDate,
                            EndDate = Convert.ToString(DateTime.Now),
                            EndReason = "Employee dont come work more 5 days"
                        };
                        _context.OldWorkPlaces.Add(oldWork);

                        await _context.SaveChangesAsync();
                    }
                    Absent absent = new Absent()
                    {
                        AbsentReasonId = absentAddModel.AbsentReasonId,
                        EmployeeId = absentAddModel.EmployeeId,
                        StartDate = absentAddModel.StartDate,
                        EndDate = absentAddModel.EndDate
                    };

                    try
                    {
                        _context.Absents.Add(absent);
                        await _context.SaveChangesAsync();
                        absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                        absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                        absentAddModel.Absents = await _context.Absents
                                                                .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                    .Include(r => r.AbsentReason)
                                                                        .ToListAsync();
                        return View(absentAddModel);
                    }
                    catch
                    {
                        absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                        absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                        absentAddModel.Absents = await _context.Absents
                                                                .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                    .Include(r => r.AbsentReason)
                                                                        .ToListAsync();
                        return View(absentAddModel);
                    }
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/absenttable");
                }
            }
            else
            {
                try
                {
                    absentAddModel.Employee = await _context.Employees.FindAsync(absentAddModel.EmployeeId);
                    absentAddModel.AbsentReasons = await _context.AbsentReasons.ToListAsync();
                    absentAddModel.Absents = await _context.Absents
                                                            .Where(e => e.EmployeeId == absentAddModel.EmployeeId)
                                                                .Include(r => r.AbsentReason)
                                                                    .ToListAsync();
                    return View(absentAddModel);
                }
                catch
                {
                    return Redirect("/hrpayroll/employee/absenttable");
                }
            }
        }

        public async Task<IActionResult> AbsentDelete(int id)
        {
            try
            {
                Absent absent = await _context.Absents.FindAsync(id);
                
                _context.Absents.Remove(absent);
                await _context.SaveChangesAsync();

                return Redirect($"/hrpayroll/employee/absenttableadd?id={absent.EmployeeId}");
            }
            catch
            {
                return Redirect("/hrpayroll/employee/absenttable");
            }
        }


    }
}
