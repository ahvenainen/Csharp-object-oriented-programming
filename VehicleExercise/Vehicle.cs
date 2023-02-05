using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    abstract class Vehicle
    {
        protected string brand;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle(string brand, string model, int modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine("\u001b[4mAjoneuvon tiedot\u001b[0m");
            Console.WriteLine("Brandi: {0}\nMalli: {1}\nVuosimalli: {2}\nHinta: {3}", brand, model, modelYear, price);
        }
    }
}
