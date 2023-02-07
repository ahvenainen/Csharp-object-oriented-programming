using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExercise
{
    internal class Book : IComparable<Book>
    {
        public string name = "";
        private readonly string author = "";
        public string publisher = "";
        public double price = 0;
        private string isbn = "";
        private static string theme = "";
        private const int MaxLength = 13;

        public double Price
        {
            get 
            { 
                return price; 
            }
            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }
                else 
                    price = value;
            }
        }

        public string Isbn
        {
            get 
            { 
                return isbn; 
            }
            set
            {
                if (value.Length == MaxLength && value.StartsWith("978"))
                {
                    isbn = value;               
                }
                else
                {
                    isbn = "ISBN ei ole oikea. Kirjoitapa ISBN oikein!! Äkkiä!!";
                }               
            }
        }

        public string Author
        {
            get 
            { 
                return author; 
            }           
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }
        public void GetBookDetails(string Isbn)
        {
            if (Isbn == this.Isbn)
            {
                Console.WriteLine("Nimi: {0}\n Tekijä: {1}\n Julkaisija: {2}\n Hinta: {3}\n ISBN: {4}\n Teema: {5}\n", name, Author, publisher, Price, this.Isbn, theme);
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voi tulostaa");
                Console.WriteLine(isbn + "\n");
            }
        }
        public static void ChangeTheme(string uusi)
        {
            theme = uusi;
        }

        public override string? ToString()
        {
            return $"{this.name}, {this.author}, {this.isbn}, {this.publisher}, {this.price}";
        }

        public int CompareTo(Book? other)
        {
            return this.price.CompareTo(other.price);
        }
    }
}
