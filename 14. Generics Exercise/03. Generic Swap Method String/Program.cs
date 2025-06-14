namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Swap(indices[0], indices[1], list);

            foreach (string name in list)
            {
                Console.WriteLine($"{name.GetType()}: {name.ToString()}");
            }

            void Swap<T>(int firstIndex, int secondIndex, List<T> list)
            {
                T temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
        }
    }
}