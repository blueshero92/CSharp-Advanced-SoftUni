namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new("Dido", 31);       

            Console.WriteLine ($"{person.Name} - {person.Age}");
            
        }
    }
}