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
            title = string.Empty;
            address = string.Empty;
            phone = string.Empty;
            outcome = 0;
            expense = 0;
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
            title = other.title;
            address = other.address;
            phone = other.phone;
            outcome = other.outcome;
            expense = other.expense;
        }

        public void Voitot()
        {
            int voitto = (outcome - expense) / expense * 100;

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
