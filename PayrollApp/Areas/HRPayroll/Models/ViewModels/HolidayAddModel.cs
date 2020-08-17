using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class HolidayAddModel
    {
        public List<Holiday> Holidays { get; set; }
        [Required(ErrorMessage = "Please provide start date")]
        public string StartDate { get; set; }
        [Required(ErrorMessage = "Please provide end date")]
        public string EndDate { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}
