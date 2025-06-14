using _06.SpeedRacing;
using System.Reflection;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new();

            for(int i = 0; i < count; i++)
            {
                string[] carArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArguments[0];
                double fuelAmount = double.Parse(carArguments[1]);
                double fuelConsumptionPer1Km = double.Parse(carArguments[2]);

                Car car = new(model, fuelAmount, fuelConsumptionPer1Km);

                cars.Add(model, car);
            }

            string command;


            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = tokens[1];
                double distance = double.Parse(tokens[2]);

                Car car = cars[carModel];

                car.Drive(distance);
                
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}