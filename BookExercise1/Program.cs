// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using BookExercise1;

Book myFirstBook = new Book("Peppi", "Tove", "01235", 77.20);
Book mySecondBook = new Book("Peppi Pitkätossu", 77);
Book myBook = new Book("Muumit", "Tove Jansson", "01234", 77.00);
myBook.CompareBooks(myFirstBook);

