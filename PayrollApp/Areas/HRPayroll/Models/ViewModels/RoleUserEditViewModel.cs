using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class RoleUserEditViewModel
    {
        public IdentityRole IdentityRole { get; set; }
        public List<AppUser> AppUsersInThisRole { get; set; }
        public List<AppUser> OtherAppUsers { get; set; }
    }
}
