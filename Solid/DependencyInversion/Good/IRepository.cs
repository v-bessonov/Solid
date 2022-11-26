namespace Solid.DependencyInversion.Good;

/// <summary>
/// Create a parent interface Repository and SQL and NoSQL Repository implements it.
/// </summary>
public interface IRepository
{
    void Save();
}