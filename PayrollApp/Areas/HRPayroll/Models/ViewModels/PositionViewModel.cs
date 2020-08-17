using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class PositionViewModel
    {
        public PositionAddModel PositionAddModel { get; set; }
        public List<Position> Positions { get; set; }
        public List<Company> Companies { get; set; }
    }
}
