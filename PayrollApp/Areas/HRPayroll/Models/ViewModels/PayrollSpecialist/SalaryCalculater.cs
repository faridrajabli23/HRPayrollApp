using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels.PayrollSpecialist                                                                                                
{
    public class SalaryCalculater
    {
        private readonly PayrollAppDbContext _context;

        public SalaryCalculater(PayrollAppDbContext context)
        {
            _context = context;
        }

        public List<CalculatedEmployeePay> Calculator(List<EmployeePay> employeePays)
        {
            List<CalculatorModel> forSame = new List<CalculatorModel>();
            List<CalculatorModel> CalculatorModel = new List<CalculatorModel>();
            List<CalculatedEmployeePay> Result = new List<CalculatedEmployeePay>();

            foreach (var item in employeePays)
            {
                List<EmployeePay> employees = employeePays.Where(e => e.EmployeeId == item.EmployeeId)
                                                                                             .ToList();

                if(employees.Count > 1)
                {
                    CalculatorModel model = new CalculatorModel();
                    model.SameEmployeePays = employees;
                    forSame.Add(model);
                }
                else
                {
                    CalculatorModel model = new CalculatorModel();
                    model.EmployeePay = item;
                    forSame.Add(model);
                }
            }

            foreach (var item in forSame)
            {
                
                if(item.SameEmployeePays != null)
                {
                    item.Employee = _context.Employees.Find(item.SameEmployeePays.FirstOrDefault().EmployeeId);
                    item.Date = item.Employee.WorkDate;
                    item.Absents = _context.Absents.Where(a => a.EmployeeId == item.Employee.Id).ToList();
                    item.Holidays = _context.Holidays.Where(h => h.EmployeeId == item.Employee.Id).ToList();
                    item.BonusPenalties = _context.BonusPenalties.Where(b => b.EmployeeId == item.Employee.Id).ToList();
                    item.Stipulations = _context.Stipulations.ToList();

                    CalculatorModel.Add(item);
                }
                else
                {
                    item.Employee = _context.Employees.Find(item.EmployeePay.EmployeeId);
                    item.Date = item.Employee.WorkDate;
                    item.Absents = _context.Absents.Where(a => a.EmployeeId == item.Employee.Id).ToList();
                    item.Holidays = _context.Holidays.Where(h => h.EmployeeId == item.Employee.Id).ToList();
                    item.BonusPenalties = _context.BonusPenalties.Where(b => b.EmployeeId == item.Employee.Id).ToList();
                    item.Stipulations = _context.Stipulations.ToList();

                    CalculatorModel.Add(item);
                }
            }
            foreach (var item in CalculatorModel)
            {
                if(item.EmployeePay == null)
                {
                    foreach (var same in item.SameEmployeePays)
                    {
                        DateTime workDate = Convert.ToDateTime(same.WorkDate);
                        DateTime now = DateTime.Now;
                        TimeSpan span = now.Subtract(workDate);
                        int workDays = Convert.ToInt32(span.Days) + 1;
                        int holidayDays = 0;
                        int oneDayAbsent = 0;
                        int moreDaysAbsent = 0;
                        int excusableAbsent = 0;
                        double bonus = 0;
                        double penalty = 0;
                        double amount = 0;
                        double percent = 0;
                        foreach (var holiday in item.Holidays)
                        {
                            DateTime holidayStartDate = Convert.ToDateTime(holiday.StartDate);
                            DateTime holidayEndDate = Convert.ToDateTime(holiday.EndDate);
                            
                            if(holidayStartDate <= workDate)
                            {
                                if(holidayEndDate >= now)
                                {
                                    holidayDays = holidayDays + workDays;
                                }
                                else if (holidayEndDate < now)
                                {
                                    TimeSpan time = holidayEndDate.Subtract(workDate);
                                    holidayDays += Convert.ToInt32(span.Days) + 1;
                                }
                            }
                            else
                            {
                                if (holidayEndDate >= now)
                                {
                                    TimeSpan time = now.Subtract(holidayStartDate);
                                    holidayDays += Convert.ToInt32(time.Days)+1; 
                                }
                                else if (holidayEndDate < now)
                                {
                                    TimeSpan time = now.Subtract(holidayEndDate);
                                    holidayDays += Convert.ToInt32(time.Days)+1;
                                }
                            }
                        }
                        foreach (var absent in item.Absents)
                        {
                            DateTime absentStartDate = Convert.ToDateTime(absent.StartDate);
                            DateTime absentEndDate = Convert.ToDateTime(absent.EndDate);
                            TimeSpan absentSpan = absentEndDate.Subtract(absentStartDate);
                            int absentInretval = Convert.ToInt32(absentSpan.Days) + 1;
                            AbsentReason absentReasons = _context.AbsentReasons.Find(absent.AbsentReasonId);
                            
                            if(absentReasons.ExcusableOrInexcusable == "Excusable")
                            {
                                excusableAbsent += absentInretval;
                            }
                            else
                            {
                                if (absentInretval == 1)
                                {
                                    oneDayAbsent++;
                                }
                                else if (absentInretval > 1 && absentInretval < 6)
                                {
                                    moreDaysAbsent += absentInretval;
                                }
                            }
                        }
                        foreach (var bonusPenalty in item.BonusPenalties)
                        {
                            if(bonusPenalty.BonusOrPenalty == "Bonus")
                            {
                                bonus += bonusPenalty.Amount;
                            }
                            else
                            {
                                penalty += bonusPenalty.Amount;
                            }
                        }
                        foreach (var stipulation in item.Stipulations)
                        {
                            if(stipulation.CompanyId == same.Position.CompanyId)
                            {
                                if(stipulation.PercentOrAmount == "Amount")
                                {
                                    amount += stipulation.Amount;
                                }
                                else
                                {
                                    percent += stipulation.Percent;
                                }
                            }
                        }

                        double Salary = same.Position.Salary;
                        double TotalSalary = 0;
                        int TotalWorkDay = workDays - holidayDays - oneDayAbsent - excusableAbsent - moreDaysAbsent;
                        int TotalDays =0;
                        TotalDays += TotalWorkDay;
                        
                        if (holidayDays != 0)
                        {
                            int a = holidayDays / 2;
                            TotalDays += a;
                        } 
                        if(oneDayAbsent != 0)
                        {
                            TotalDays -= oneDayAbsent;
                        }
                        if(moreDaysAbsent != 0)
                        {
                            int b = moreDaysAbsent * 2;
                            TotalDays -= b; 
                        }
                        double SalaryForPay = Salary / 30.5;
                        TotalSalary = TotalDays * SalaryForPay;

                        if(amount != 0)
                        {
                            TotalSalary += amount;
                        }
                        if(percent != 0)
                        {
                            var x = TotalSalary * percent / 100;
                            TotalSalary += x;
                        }

                        CalculatedEmployeePay calculatedEmployeePay = new CalculatedEmployeePay()
                        {
                            Name = same.Name,
                            Surname = same.Surname,
                            Fathername = same.Fathername,
                            Department = same.Position.Company.Department.Name,
                            Company = same.Position.Company.Name,
                            Position = same.Position.Name,
                            MonthSalary = same.Position.Salary,
                            EmployeeId = same.EmployeeId,
                            EmployeePayId = same.Id,
                            Gender = same.Gender,
                            WorkDate = same.WorkDate,
                            ExcusableAbsent = excusableAbsent,
                            OneDayAbsent = oneDayAbsent,
                            MoreDaysAbsent = moreDaysAbsent,
                            HolidayDays = holidayDays,
                            TotalBonus = bonus,
                            TotalPenalty = penalty,
                            TotalSalary = TotalSalary
                        };
                        Result.Add(calculatedEmployeePay);
                    }
                }
                else
                {
                    DateTime workDate = Convert.ToDateTime(item.EmployeePay.WorkDate);
                    DateTime now = DateTime.Now;
                    TimeSpan span = now.Subtract(workDate);
                    int workDays = Convert.ToInt32(span.Days) +1;
                    int holidayDays = 0;
                    int oneDayAbsent = 0;
                    int moreDaysAbsent = 0;
                    int excusableAbsent = 0;
                    double bonus = 0;
                    double penalty = 0;
                    double amount = 0;
                    double percent = 0;
                    foreach (var holiday in item.Holidays)
                    {
                        DateTime holidayStartDate = Convert.ToDateTime(holiday.StartDate);
                        DateTime holidayEndDate = Convert.ToDateTime(holiday.EndDate);

                        if (holidayStartDate <= workDate)
                        {
                            if (holidayEndDate >= now)
                            {
                                holidayDays = holidayDays + workDays;
                            }
                            else if (holidayEndDate < now)
                            {
                                TimeSpan time = holidayEndDate.Subtract(workDate);
                                holidayDays += Convert.ToInt32(span.Days)+1;
                            }
                        }
                        else
                        {
                            if (holidayEndDate >= now)
                            {
                                TimeSpan time = now.Subtract(holidayStartDate);
                                holidayDays += Convert.ToInt32(time.Days) + 1;
                            }
                            else if (holidayEndDate < now)
                            {
                                TimeSpan time = now.Subtract(holidayEndDate);
                                holidayDays += Convert.ToInt32(time.Days)+1;
                            }
                        }
                    }
                    foreach (var absent in item.Absents)
                    {
                        DateTime absentStartDate = Convert.ToDateTime(absent.StartDate);
                        DateTime absentEndDate = Convert.ToDateTime(absent.EndDate);
                        TimeSpan absentSpan = absentEndDate.Subtract(absentStartDate);
                        int absentInretval = Convert.ToInt32(absentSpan.Days) + 1;
                        AbsentReason absentReasons = _context.AbsentReasons.Find(absent.AbsentReasonId);
                        if (absentStartDate <= workDate)
                        {
                            if (absentEndDate < now)
                            {
                                TimeSpan time = absentEndDate.Subtract(workDate);
                                oneDayAbsent += Convert.ToInt32(span.Days) + 1;
                            }
                        }
                        else
                        {
                            if (absentReasons.ExcusableOrInexcusable == "Excusable")
                            {
                                excusableAbsent += absentInretval;
                            }
                            else
                            {
                                if (absentInretval == 1)
                                {
                                    oneDayAbsent++;
                                }
                                else if (absentInretval > 1 && absentInretval < 6)
                                {
                                    moreDaysAbsent += absentInretval;
                                }
                            }
                        }
                        
                    }
                    foreach (var bonusPenalty in item.BonusPenalties)
                    {
                        if (bonusPenalty.BonusOrPenalty == "Bonus")
                        {
                            bonus += bonusPenalty.Amount;
                        }
                        else
                        {
                            penalty += bonusPenalty.Amount;
                        }
                    }

                    foreach (var stipulation in item.Stipulations)
                    {
                        if (stipulation.CompanyId == item.EmployeePay.Position.CompanyId)
                        {
                            if (stipulation.PercentOrAmount == "Amount")
                            {
                                amount += stipulation.Amount;
                            }
                            else
                            {
                                percent += stipulation.Percent;
                            }
                        }
                    }
                    double Salary = item.EmployeePay.Position.Salary;
                    double TotalSalary = 0;
                    int TotalWorkDay = workDays - holidayDays - oneDayAbsent - excusableAbsent - moreDaysAbsent;
                    int TotalDays = 0;
                    TotalDays += TotalWorkDay;

                    if (holidayDays != 0)
                    {
                        int a = holidayDays / 2;
                        TotalDays += a;
                    }
                    
                    if (oneDayAbsent != 0)
                    {
                        TotalDays -= oneDayAbsent;
                    }
                    if (moreDaysAbsent != 0)
                    {
                        int b = moreDaysAbsent * 2;
                        TotalDays -= b;
                    }
                    double SalaryForPay = Salary / 30.5;
                    TotalSalary = TotalDays * SalaryForPay;
                    if(TotalSalary< 0)
                    {
                        TotalSalary = 0;
                    }
                    else
                    {
                        if (amount != 0)
                        {
                            TotalSalary += amount;
                        }
                        if (percent != 0)
                        {
                            var x = TotalSalary * percent / 100;
                            TotalSalary += x;
                        }
                    }

                    

                    CalculatedEmployeePay calculatedEmployeePay = new CalculatedEmployeePay()
                    {
                        Name = item.EmployeePay.Name,
                        Surname = item.EmployeePay.Surname,
                        Fathername = item.EmployeePay.Fathername,
                        Department = item.EmployeePay.Position.Company.Department.Name,
                        Company = item.EmployeePay.Position.Company.Name,
                        Position = item.EmployeePay.Position.Name,
                        MonthSalary = item.EmployeePay.Position.Salary,
                        EmployeeId = item.EmployeePay.EmployeeId,
                        EmployeePayId = item.EmployeePay.Id,
                        Gender = item.EmployeePay.Gender,
                        WorkDate = item.EmployeePay.WorkDate,
                        ExcusableAbsent = excusableAbsent,
                        OneDayAbsent = oneDayAbsent,
                        MoreDaysAbsent = moreDaysAbsent,
                        HolidayDays = holidayDays,
                        TotalBonus = bonus,
                        TotalPenalty = penalty,
                        TotalSalary = TotalSalary
                    };
                    Result.Add(calculatedEmployeePay);
                }
            }

            return Result;
        }
    }
}
