using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Car : Vehicle
    {
        protected string engine;
        protected string type;
        protected int lkm;
        public Car(string brand, string model, int modelYear, double price, string engine, string type, int lkm) : base(brand, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.lkm = lkm;
        }

        public override bool Equals(object? obj)
        {
            Console.Write("\nAutot ovat samat: ");
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(brand, model, modelYear, price, engine, type, lkm);
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine("Moottori: {0}\nTyyppi: {1}\nOvien lkm: {2}", engine, type, lkm);
        }

        public override string? ToString()
        {
            Console.WriteLine("\u001b[4m\nAjoneuvon tiedot\u001b[0m");
            return "Brandi: " + brand + "\nMalli: " + model + "\nVuosimalli: " + modelYear + "\nHinta: " + price + "\nMoottori: " + engine
                + "\nTyyppi: " + type + "\nOvien lkm: " + lkm;
        }
    }
}
