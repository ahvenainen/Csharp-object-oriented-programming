using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise1
{
    internal class Book
    {
        public string title;
        int pageCount;
        string author;
        string id;
        public double price;

        public Book(string title, double price)
        {
            this.title = string.Empty;
            this.pageCount = 2;
            this.author = string.Empty;
            this.price = 10.00;
            this.id = "00000";
            this.WriteTitle(pageCount, title);
        }

        public Book(string title, int pageCount)
        {
            this.title = title;
            this.pageCount = pageCount;
           
            this.author = string.Empty;
            this.id = "00000";
            this.price = 10.00;
            this.WriteTitle(pageCount, title);
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.SetId(id);
            this.price = price;
            this.pageCount = 0;
            //this.WriteAllDetails(pageCount, title, author, id, price);
            this.PrintData();
        }

        public void WriteTitle(int parameter1, string parameter2)
        {
            Console.WriteLine("Page count: {0} \nBook name: {1}", parameter1, parameter2);
        }

        public void WriteAllDetails(int parameter1, string parameter2, string parameter3, string parameter4, double parameter5)
        {
            Console.WriteLine("Page count: {0} " + "\nBook name: {1}" + "Third param {2}" + "fourth parameter {3}" + "fifth parameter {4}",
            parameter1, parameter2, parameter3, parameter4, parameter5);
        }
        public void PrintData()
        {
            Console.WriteLine("Title: {0}" + "\nAuthor: {1}" + "\nID: {2}" + "\nPrice: {3}\n",
            this.title, this.author, this.id, this.price);
        }

        public void SetId(string id)
        {
            if (id.Length != 5)
            {
                Console.WriteLine("Id not valid");
                this.id = "ERROR";
            }
            else
            {
                this.id = id;
            }         
        }
        public void CompareBooks(Book other)
        {
            Console.WriteLine("Book name: " + this.title + " (" + this.price + "€)");
            Console.WriteLine("Book name: " + other.title + " (" + other.price + "€)");
            if (this.price > other.price)
            {
                Console.WriteLine(this.title + " is more expensive than " + other.title + "\n");
            }
            else
                Console.WriteLine(other.title + " is more expensive than " + this.title + "\n");
        }
    }
}
