
using System.Runtime.CompilerServices;
using BookExercise1;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Book myFirstBook = new Book("Muumilaakson tarinat", "Tove", "01235", 19.90);
Book mySecondBook = new Book("Peppi Pitkätossu", 15.90);
Console.WriteLine();
Book myBook = new Book("Muumit", "Tove Jansson", "01234", 16.90);
myBook.CompareBooks(myFirstBook);
