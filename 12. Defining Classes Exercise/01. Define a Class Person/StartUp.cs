namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new();

            person.Name = "Dido";
            person.Age = 31;

            Console.WriteLine ($"{person.Name} - {person.Age}");
            
        }
    }
}