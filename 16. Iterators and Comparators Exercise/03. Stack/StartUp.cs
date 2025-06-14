namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> customStack = new();

            string command;

            while((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];

                if (action == "Push")
                {
                    int[] pushedItems = tokens.Skip(1).Select(int.Parse).ToArray();

                    foreach (int item in pushedItems)
                    {
                        customStack.Push(item);
                    }
                }
                else
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch(InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }

            foreach (int item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (int item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}