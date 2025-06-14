namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                box.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}