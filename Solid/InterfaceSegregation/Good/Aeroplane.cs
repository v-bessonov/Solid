namespace Solid.InterfaceSegregation.Good;

/// <summary>
/// Aeroplane implements IVehicle and IFlyable
/// </summary>
public class Aeroplane : IVehicle, IFlyable
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