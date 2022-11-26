namespace Solid.InterfaceSegregation.Good;

/// <summary>
/// Bus implements IVehicle only as it doesn't support Fly()
/// </summary>
public class Bus : IVehicle
{
    public void Accelerate()
    {
    }

    public void ApplyBrakes()
    {
    }
}