﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
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

        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result != 0)
            {
                return result;
            }

            result = this.Age.CompareTo(other.Age);

            if (result != 0)
            {
                return result;
            }

            return this.Town.CompareTo(other.Town);
        }
    }
}
