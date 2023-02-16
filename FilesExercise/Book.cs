using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExercise
{

    internal class Book
    {
        public string title;
        public string author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string? ToString()
        {
            return "Author: " + this.author + "\nTitle: " + this.title + "\nPrice: " + this.price;
        }
    }
}
