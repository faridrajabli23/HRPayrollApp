using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string RegisterAddress { get; set; }
        public string PassportId { get; set; }
        public string WorkDate { get; set; }
        public string PassportExpDate { get; set; }
        public string Education { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
    }
}
