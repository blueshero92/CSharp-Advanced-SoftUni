﻿namespace DefiningClasses
{
    public class Person
    {
        
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }       

        public int Age
        {
            get { return this.age; } 
            set { this.age = value; }
        }
    }
}
