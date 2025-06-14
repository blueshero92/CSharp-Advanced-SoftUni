namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new();

            int elementsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementsCount; i++)
            {
                double element = double.Parse(Console.ReadLine());

                box.Add(element);
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(itemToCompare));
        }
    }
}