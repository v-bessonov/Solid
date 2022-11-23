namespace Solid.LiskovSubstitution.Good;

/// <summary>
/// Creating new subclass RealCar from parent Car class,
/// so that RealCar can support fuel()
/// and Car can support generic functions support by any type of car.
/// </summary>
public class RealCar : Car
{
    public virtual void Fuel()
    {
    }
}