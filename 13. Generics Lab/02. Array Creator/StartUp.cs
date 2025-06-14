namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = ArrayCreator.Create(5, "Dido");

            Console.WriteLine(string.Join(" ", array));
        }
    }
}