namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();

            ListyIterator<string> listyIterator = new(items);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "PrintAll": 
                        Console.WriteLine(string.Join(" ", listyIterator));
                        break;
                }

            }
        }
    }
}