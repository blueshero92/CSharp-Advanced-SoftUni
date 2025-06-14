namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new();

            int elementsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementsCount; i++)
            {
                string element = Console.ReadLine();

                box.Add(element);
            }

            string itemToCompare = Console.ReadLine();

            box.Compare(itemToCompare, box.list);
        }
    }
}