namespace C_;

public class Car : IVehicle
{
    public void Deliver()
    {
        Console.WriteLine("Delivering Car...");
    }
}

public class Bike : IVehicle
{
    public void Deliver()
    {
        Console.WriteLine("Delivering Bike...");
    }
}