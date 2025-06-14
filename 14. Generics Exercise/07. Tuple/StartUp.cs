namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] nameBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] intDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            CustomTuple<string, string> nameAndAdress = new ($"{nameAdress[0]} {nameAdress[1]}", nameAdress[2]);
            CustomTuple<string, int> nameAndBeer = new(nameBeer[0], int.Parse(nameBeer[1]));
            CustomTuple<int, double> intAndDouble = new(int.Parse(intDouble[0]) , double.Parse(intDouble[1]));

            Console.WriteLine(nameAndAdress);
            Console.WriteLine(nameAndBeer);
            Console.WriteLine(intAndDouble);

        }
    }
}