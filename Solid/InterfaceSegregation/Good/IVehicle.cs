namespace Solid.InterfaceSegregation.Good;

/// <summary>
/// Pulling out Fly() method into new Flyable interface solves the issue.
/// Now, IVehicle interface contains methods supported by all Vehicles.
/// And, Aeroplane implements both IVehicle and IFlyable interface as it can fly too.
/// </summary>
public interface IVehicle
{
    void Accelerate();
    void ApplyBrakes();
}