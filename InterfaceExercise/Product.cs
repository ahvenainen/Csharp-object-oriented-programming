using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Product: IProduct
    {
        public string name;
        public double price;
        public int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public double CalculateTotal()
        {
            return price * count;
        }

        public Product GetProduct(string name)
        {
            //if (name.Equals(this.name)
            if (name == this.name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string? ToString()
        {
            return "Tuote: " + this.name + "\nHinta: " + this.price + "\nMäärä: " + this.count;
            //return this.name + this.price + "€" + this.count + "kpl";
        }
    }
}

