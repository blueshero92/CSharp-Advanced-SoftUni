namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Person> people = new();

            for(int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person person = new(name, age);
                people.Add(person);
            }

            List<Person> filteredPeople = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (Person person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}