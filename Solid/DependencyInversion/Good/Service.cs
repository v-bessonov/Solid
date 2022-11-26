namespace Solid.DependencyInversion.Good;

/// <summary>
/// Service class refers to Repository interface,
/// in future if we need to support NoSQL
/// then simply need to pass its instance in constructor without changing Service class.
/// </summary>
public class Service
{
    private readonly IRepository _repository;

    /// <summary>
    /// Here we're using interface as a reference
    /// not the concrete class so our code
    /// can easily support other child classes
    /// of the same interface (eg. NoSqlRepository)
    /// </summary>
    /// <param name="repository"></param>
    public Service(IRepository repository)
    {
        _repository = repository;
    }

    public void Save()
    {
        _repository.Save();
    }
}