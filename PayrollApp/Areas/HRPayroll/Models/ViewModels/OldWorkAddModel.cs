using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class OldWorkAddModel
    {
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a company name")]
        [MaxLength(30, ErrorMessage = "Company is too long")]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a position name")]
        [MaxLength(30, ErrorMessage = "Position name is too long")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please provide entry date")]
        public string EntryDate { get; set; }

        [Required(ErrorMessage = "Please provide end date")]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "Please provide reason")]
        [MaxLength(100, ErrorMessage = "Text can be max 100 symbol")]
        public string EndReason { get; set; }
        public int EmployeeId { get; set; }

        public List<OldWorkPlace> OldWorkPlaces { get; set; }
        public Employee Employee { get; set; }
    }
}
