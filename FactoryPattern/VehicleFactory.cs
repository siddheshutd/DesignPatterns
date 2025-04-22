namespace C_;

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
    public void DeliverVehicle(){
        IVehicle vehicle = CreateVehicle();
        vehicle.Deliver();
    }
}

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}

public class BikeFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Bike();
    }
}