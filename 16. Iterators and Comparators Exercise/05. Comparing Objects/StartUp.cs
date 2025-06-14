namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;

            while((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person person = new(name, age, town);
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            Person comparedPerson = people[index];

            int equals = 0;
            int differences = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    equals++;
                }
                else
                {
                    differences++;
                }
            }

            if (equals == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equals} {differences} {people.Count}");
            }
        }
    }
}