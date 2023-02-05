using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Customer: ICustomer
    {
        private string name;
        private double purchases;
        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public override string? ToString()
        {
            return "Asiakas: " + name + "\nOstokset: " + purchases + "€";
        }

        public Customer GetCustomer(string name)
        {
            if (name == this.name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double GetBonus()
        {
            if(purchases <= 1000)
            {
                double bonus = purchases * 0.02;
                return bonus;
            }
            else if (purchases > 1000 && purchases <= 2000) 
            {
                double bonus = purchases * 0.03;
                return bonus;
            }
            else
            {
                double bonus = purchases * 0.05;
                return bonus;
            }
        }
    }
}
