using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Literature;

namespace BookExercise2
{ 
    internal class Author
    {
        public string nimi = "";
        public string birthday = "";
        private Book book;

        public Author(string nimi, string birthday)
        {
            this.nimi = nimi;
            this.birthday = birthday;
        }

        public Author(string nimi, string birthday, Book book)
        {
            this.nimi = nimi;
            this.birthday = birthday;
            this.Book = book;
            Console.WriteLine("Kirjan nimi on: {0}\n", book.name);
        }

        internal Book? Book
        {
            get { return book; }
            set
            {
                Console.WriteLine("\nKirjan kirjoittaja on: " + value?.Author);
                Console.WriteLine("Kirjailijan nimi on: " + this.nimi);
                if(value?.Author == this.nimi)
                {
                    book = value;
                }
            }
        }

        public void PrintInformation()
        {
            if (this.book != null)
            {
                //Console.WriteLine(this.book.ToString());
                Console.WriteLine("Tekijän nimi: {0}\n Tekijän syntymäpäivä: {1}\n Kirjan nimi: {2}\n" +
                    " Julkaisija: {4}\n Hinta: {5}\n ISBN: {6}\n", nimi, birthday, Book.name, Book.Author, Book.publisher, Book.Price, Book.Isbn);
            }
            else
            {
                Console.WriteLine("Kirjalija: {0}\nSyntymäpäivä: {1}", nimi, birthday);
                Console.WriteLine("Ei teosta");
            }
        }

    }
}
