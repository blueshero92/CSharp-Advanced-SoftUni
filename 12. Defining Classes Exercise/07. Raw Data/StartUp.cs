namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = command[0];
                int speed = int.Parse(command[1]);
                int power = int.Parse(command[2]);
                int weight = int.Parse(command[3]);
                string type = command[4];
                double pressure = double.Parse(command[5]);
                int age = int.Parse(command[6]);
                double pressure2 = double.Parse(command[7]);
                int age2 = int.Parse(command[8]);
                double pressure3 = double.Parse(command[9]);
                int age3 = int.Parse(command[10]);
                double pressure4 = double.Parse(command[11]);
                int age4 = int.Parse(command[12]);

                Car car = new(model, speed, power, type, weight, pressure, age, pressure2, age2, pressure3, age3, pressure4, age4);

                cars.Add(car);
            }

            string typeInput = Console.ReadLine();

            List<Car> fragileCars = cars.Where(car => car.Cargo.Type == "fragile" && car.Tires.Any(t => t.Pressure < 1)).ToList();
            List<Car> flammableCars = cars.Where(car => car.Cargo.Type == "flammable" && car.Engine.Power > 250).ToList();

            if (typeInput == "fragile")
            {
                foreach (Car fragileCar in fragileCars)
                {
                    Console.WriteLine(fragileCar.Model);
                }
            }
            else
            {
                foreach (Car flammableCar in flammableCars)
                {
                    Console.WriteLine(flammableCar.Model);
                }
            }

        }
    }
}