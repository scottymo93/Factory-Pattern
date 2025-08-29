namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheels;
            bool input = true;
            do
            {
                Console.WriteLine("How many wheels do you want your vehicle to have?");

                input = int.TryParse(Console.ReadLine(), out wheels);

            } while (input == false);
            
           var vehicle = VehicleFactory.CreateRide(wheels);
           
           vehicle.Drive();
        }
    }
}
