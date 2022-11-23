using Solid.SingleResponsibility.Good;

namespace Solid.OpenClose.Good;

public class ContractEmployeeSalary : IEmployeeSalary
{
    public decimal? CalculateSalary(Employee employee)
    {
        var totalWorkingDay = 24;
        var basicPay = 10.0M;
        
        return totalWorkingDay * basicPay;
    }
}