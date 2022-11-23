namespace Solid.SingleResponsibility.Bad;

/// <summary>
/// Below Employee class contains personal details, business logic to perform a few calculations,
/// and DB logic to save/update.
/// Our class is tightly coupled, hard to maintain, multiple reasons to modify this class.
/// </summary>
public class Employee
{
    // standart getters and setters
    
    public string FullName { get; protected set; }
    public DateTime? DateOfBirth { get; protected set; }
    public decimal? Salary { get; protected set; }
    
    
    //biz logic

    public decimal? CalculateEmployeeSalary(Employee employee)
    {
        return null;
    }
    
    public decimal? CalculateEmployeeLeaves(Employee employee)
    {
        return null;
    }
    
    public decimal? CalculateTaxOnSalary(Employee employee)
    {
        return null;
    }
    
    // data persistence logic
    
    public Employee SaveEmployee(Employee employee)
    {
        return employee;
    }
    
    public Employee UpdateEmployee(Employee employee)
    {
        return employee;
    }
}