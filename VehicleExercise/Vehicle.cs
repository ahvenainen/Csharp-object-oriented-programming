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
            Console.WriteLine("\u001b[4mVehicle information\u001b[0m");
            Console.WriteLine("Brand: {0}\nModel: {1}\nModel Year: {2}\nPrice: {3}", brand, model, modelYear, price);
        }
    }
}
