namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());

                list.Add(input);
            }

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Swap(indices[0], indices[1], list);

            foreach (int item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item.ToString()}");
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