using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result != 0)
            {
                return result;
            }

            return this.Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (other == null)
            {
                return false;
            }

            return this.Name == other.Name && this.Age == other.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = this.Name.GetHashCode() + this.Age.GetHashCode();

            return hashCode;
        }
    }
}
