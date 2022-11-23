using Solid.SingleResponsibility.Good;

namespace Solid.OpenClose.Good;

/// <summary>
/// We can introduce a new interface EmployeeSalary and create two child classes for Permanent and Contractual Employees.
/// By doing this, when a new type comes then a new child class needs to be created
/// and our core logic will also not change from this.
/// </summary>
public interface IEmployeeSalary
{
    decimal? CalculateSalary(Employee employee);
}