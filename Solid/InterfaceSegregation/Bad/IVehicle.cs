namespace Solid.InterfaceSegregation.Bad;

/// <summary>
/// Vehicle interface contains the Fly() method which is not supported by all vehicles
/// i.e. Bus, Car, etc. Hence they've to forcefully provide a dummy implementation.
/// </summary>
public interface IVehicle
{
    void Accelerate();
    void ApplyBrakes();
    void Fly();
}