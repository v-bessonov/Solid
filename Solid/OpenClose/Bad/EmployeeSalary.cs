using Solid.SingleResponsibility.Good;

namespace Solid.OpenClose.Bad;

/// <summary>
/// Below EmployeeSalary class calculates salary based on employee type: Permanent and Contractual.
/// Issue: In the future, if a new type(Part-time Employee) comes
/// then the code needs to be modified to calculate the salary based on employee type.
/// </summary>
public class EmployeeSalary
{
    public decimal? CalculateSalary(Employee employee)
    {
        decimal? salary = null;
        var totalWorkingDay = 24;
        var basicPay = 10.0M;
        
        if (employee.GetType().Name == "Permanent")
        {
            salary = totalWorkingDay * basicPay + GetCompanyBenefits() + GetBonus();
        }else if (employee.GetType().Name == "Contract")
        {
            salary = totalWorkingDay * basicPay;
        }
        return salary;
    }

    private decimal GetBonus()
    {
        return 1000.0M;
    }

    private decimal GetCompanyBenefits()
    {
        return 1000.0M;
    }
}