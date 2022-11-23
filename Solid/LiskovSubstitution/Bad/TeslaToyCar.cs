namespace Solid.LiskovSubstitution.Bad;

/// <summary>
/// Below, TeslaToyCar extends Car but does not support fuel() method as its toy. That's why it's violating the LS principle.
/// In our code where ever we've used Car, we can't substitute it directly with TeslaToyCar because fuel() will throw Exception.
/// </summary>
public class TeslaToyCar : Car
{
    public override void Fuel()
    {
        throw new Exception("Not supported");

    }
    
    public override void Wheels()
    {
    }
    
    public override void Run()
    {
    }
}