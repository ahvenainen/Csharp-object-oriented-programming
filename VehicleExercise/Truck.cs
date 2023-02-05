using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Truck : Car
    {
        protected double load;
        protected double consumption;

        public Truck(string brand, string model, int modelYear, double price, string engine, string type, int lkm, double load, double consumption) : 
            base(brand, model, modelYear, price, engine, type, lkm)
        {
            this.load = load;
            this.consumption = consumption;
        }
        public double CalculateConsumption()
        {
            double kokonaiskulutus = consumption * load;
            return kokonaiskulutus;
        }
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine("Load: " + load + "\nConsumption: " + consumption);
        }
    }
}
