namespace Solid.DependencyInversion.Bad;

/// <summary>
/// We've got a Service class, in which we've directly referenced concrete class(SQLRepository).
/// Issue: Our class is now tightly coupled with SQLRepository,
/// in future if we need to start supporting NoSQLRepository then we need to change Service class.
/// </summary>
public class Service
{
    private readonly SqlRepository _repository = new SqlRepository();

    public void Save()
    {
        _repository.Save();
    }
}