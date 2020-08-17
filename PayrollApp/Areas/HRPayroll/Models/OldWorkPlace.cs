using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class OldWorkPlace
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Position { get; set; }
        public string EntryDate { get; set; }
        public string EndDate { get; set; }
        public string EndReason { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
