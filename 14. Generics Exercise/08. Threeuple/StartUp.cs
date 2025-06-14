namespace ThreeupleType
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] nameBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] nameBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            Threeuple<string, string, string> nameAndAdress = new($"{nameAdress[0]} {nameAdress[1]}", nameAdress[2], string.Join(" ", nameAdress[3..]));
            Threeuple<string, int, bool> nameAndBeer = new(nameBeer[0], int.Parse(nameBeer[1]), nameBeer[2] == "drunk");
            Threeuple<string, double, string> nameAndBank = new(nameBank[0], double.Parse(nameBank[1]), nameBank[2]);

            Console.WriteLine(nameAndAdress);
            Console.WriteLine(nameAndBeer);
            Console.WriteLine(nameAndBank);
        }
    }
}