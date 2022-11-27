namespace Solid.SingleResponsibility.Good;

/// <summary>
/// We can split a single Employee class into multiple classes as per their specific responsibility.
/// It made our class loosely coupled, easy to maintain, and only single reason to modify.
/// </summary>
public class Employee
{
    // standart getters and setters
    
    public string FullName { get; protected set; }
    public DateTime? DateOfBirth { get; protected set; }
    public decimal? Salary { get; protected set; }
}