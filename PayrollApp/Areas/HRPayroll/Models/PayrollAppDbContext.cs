using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class PayrollAppDbContext : IdentityDbContext<AppUser>
    {
        public PayrollAppDbContext(DbContextOptions<PayrollAppDbContext> options) : base(options) { }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OldWorkPlace> OldWorkPlaces { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<BonusPenalty> BonusPenalties { get; set; }
        public DbSet<Absent> Absents { get; set; }
        public DbSet<AbsentReason> AbsentReasons { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<EmployeePay> EmployeePays { get; set; }
        public DbSet<Stipulation> Stipulations { get; set; }
        public DbSet<UserDepartmentId> userDepartmentIds { get; set; }
    }
}
