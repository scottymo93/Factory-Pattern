namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle CreateRide(int wheels)
    {
        switch (wheels)
        {
            case 2:
                return new Motorcycle();

            case 4:
                return new Car();

                    default:
                return new Car();
        }
    }
}