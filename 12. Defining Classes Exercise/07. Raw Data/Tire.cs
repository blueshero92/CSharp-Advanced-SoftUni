﻿namespace RawData
{
    public class Tire
    {
        private double pressure;
        private int age;

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

    }
}