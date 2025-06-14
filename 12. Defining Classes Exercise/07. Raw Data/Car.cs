using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, 
            int speed, int power, 
            string type, int weight, 
            double pressure, int age,
            double pressure2, int age2,
            double pressure3, int age3,
            double pressure4, int age4)
        {
            this.Model = model;
            this.Engine = new (speed, power);           
            this.Cargo = new(type, weight);
            Tires = new Tire[4];
            Tires[0] = new Tire(pressure, age);
            Tires[1] = new Tire(pressure2, age2);
            Tires[2] = new Tire(pressure3, age3);
            Tires[3] = new Tire(pressure4, age4);

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set{ this.cargo = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
    }
}
