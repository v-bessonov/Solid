namespace Solid.InterfaceSegregation.Bad;

/// <summary>
/// Aeroplane implements all methods as it supports all operations
/// </summary>
public class Aeroplane : IVehicle
{
    public void Accelerate()
    {
    }

    public void ApplyBrakes()
    {
    }

    public void Fly()
    {
    }
}