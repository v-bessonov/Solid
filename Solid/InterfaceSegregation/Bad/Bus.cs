namespace Solid.InterfaceSegregation.Bad;

/// <summary>
/// Bus provides dummy implementation for Fly() method as it can't fly
/// </summary>
public class Bus : IVehicle
{
    public void Accelerate()
    {
    }

    public void ApplyBrakes()
    {
    }

    public void Fly()
    {
        // dummy implementation
    }
}