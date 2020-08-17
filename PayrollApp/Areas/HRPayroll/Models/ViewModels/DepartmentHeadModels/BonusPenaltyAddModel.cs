using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels.DepartmentHeadModels
{
    public class BonusPenaltyAddModel
    {
        [Required(ErrorMessage = "Please provide amount")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Please provide date")]
        public string Date { get; set; }
        public string BonusOrPenalty { get; set; }
        [Required(ErrorMessage = "Please provide reason")]
        [MaxLength(30, ErrorMessage = "Reason is too long")]
        public string Reason { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<BonusPenalty> BonusPenalties { get; set; }
    }
}
