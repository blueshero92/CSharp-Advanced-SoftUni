namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family familyMembers = new Family();
            
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personProps = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personProps[0];
                int age = int.Parse(personProps[1]);

                Person person = new Person(name, age);

                familyMembers.AddMember(person);
            }

            Person oldest = familyMembers.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}