﻿namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        
        public Family()
        {
            this.people = new List<Person>();
        }

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
       
        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.People.MaxBy(p => p.Age);
        }
    }
}
