using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        string title;
        string address;
        string phone;
        int outcome;
        int expense;
        public Company()
        {   
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public Company(Company other)
        {
            this.title = other.title;
            this.address = other.address;
            this.phone = other.phone;
            this.outcome = other.outcome;
            this.expense = other.expense;
        }

        public void Voitot()
        {
            int voitto = (this.outcome - this.expense) / this.expense * 100;

            if (voitto < 100)
            {
                Console.WriteLine("Kehnosti menee. Voitto: " + voitto.ToString());
            }
            else if (voitto >= 100 && voitto < 200)
            {
                Console.WriteLine("Välttävästi menee. Voitto: " + voitto.ToString());
            }
            else if (voitto >= 200 && voitto < 300)
            {
                Console.WriteLine("Tyydyttävästi menee. Voitto: " + voitto.ToString());
            }
            else
            {
                Console.WriteLine("Hyvin menee. Voitto: " + voitto.ToString());
            }
        }

        internal void setTitle(string value)
        {
            this.title = value;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Yrityksen nimi: {0}", title);
        }
        public override string? ToString()
        {
            return "title: " + this.title + ", address: " + this.address + ", phone: " 
                + this.phone + ", outcome: " + this.outcome + ", expense: " +  this.expense;
        }
    }
}
