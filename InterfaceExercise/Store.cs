using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceExercise
{
    internal class Store : IProducts, ICustomers
    {
        public string name;
        public double revenue;
        private List<Product> storeProducts = new List<Product>();
        private List<Customer> customers = new List<Customer>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            storeProducts.Add(product);
        }

        public void PrintCustomers()
        {
            Console.WriteLine("\u001b[3m\n-------ASIAKKAAT-------\u001b[0m");
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.ToString() + "\nBonus: " + c.GetBonus() + "€");
                if (c.GetCustomer("Pekka") != null)
                {
                    Console.WriteLine("Henkilö on sama kuin kutsuttava");
                }
                else
                {
                    Console.WriteLine("Kutsuttava henkilö ei ole sama");
                }
            }
        }

        public void PrintProducts()
        {
            double arvo = 0;
            Console.WriteLine("\u001b[3m\n-------VARASTO-------\u001b[0m");
            foreach (Product product in storeProducts)
            {
                Console.Write(product.ToString());
                arvo += product.CalculateTotal();
                Console.WriteLine("\nVaraston arvo: " + product.CalculateTotal() + "€");
            }
            Console.WriteLine("\nKoko varaston arvo: " + arvo + "€");
        }

        public override string? ToString()
        {
            return "Kaupan nimi: " + name + "\nLiikevaihto: " + revenue + "€" + "\nAsiakkaiden määrä: " + customers.Count + "\nTuotteiden määrä: " + storeProducts.Count;
        }
    }
}
