using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class WorkPlaceDetails
    {
        public string Photo { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Education { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public List<OldWorkPlace> OldWorkPlaces { get; set; }
    }
}
