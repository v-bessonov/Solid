using Solid.SingleResponsibility.Good;

namespace Solid.OpenClose.Good;

public class PermanentEmployeeSalary : IEmployeeSalary
{
    
    public decimal? CalculateSalary(Employee employee)
    {
        var totalWorkingDay = 24;
        var basicPay = 10.0M;
        
        return totalWorkingDay * basicPay + GetCompanyBenefits() + GetBonus();;
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