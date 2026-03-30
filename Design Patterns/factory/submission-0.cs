public interface IVehicle
{
    string getType();
}

public class Car : IVehicle
{
    public string getType()
    {
        return "Car";
    }
}

public class Bike : IVehicle
{
    public string getType()
    {
        return "Bike";
    }
}

public class Truck : IVehicle
{
    public string getType()
    {
        return "Truck";
    }
}

public abstract class VehicleFactory
{
    public abstract IVehicle createVehicle();
}

public class CarFactory : VehicleFactory
{
    Car car;

    public override IVehicle createVehicle()
    {
        car = new Car();
        return car;
    }
}

public class BikeFactory : VehicleFactory
{
    Bike bike;
    public override IVehicle createVehicle()
    {
        bike = new Bike();
        return bike;
    }
}

public class TruckFactory : VehicleFactory
{
    Truck truck;

    public override IVehicle createVehicle()
    {
        truck = new Truck();
        return truck;
    }
}