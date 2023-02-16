using FilesExercise;
using Newtonsoft.Json;

const string FilePath = @"C:\Users\aleks\source\repos\Olio-ohjelmointi\Object oriented programming1\FilesExercise\myBooks.json";

FileManager uusi = new FileManager(FilePath);

try
{
    uusi.ReadWords();
    Console.WriteLine(uusi.ReadWords());
}
catch(Exception e)
{
    Console.WriteLine("VIRHE! " + e.Message);
}

// Luetaan myBooks.json ja deserialisoidaan se listaksi Book-olioita.

string fileContent = uusi.ReadWords();
List<Book>? books = JsonConvert.DeserializeObject<List<Book>>(fileContent);

foreach(Book x in books)
{
    Console.WriteLine(x);
}

//Lisätään muutama kirja listaan
books.Add(new Book("Title1", "Author1", 10.90));
books.Add(new Book("Title2", "Author1", 10.90));
books.Add(new Book("Title3", "Author1", 10.90));
books.Add(new Book("Title4", "Author1", 10.90));
books.Add(new Book("Title5", "Author1", 10.90));

File.WriteAllText(@"C:\Users\aleks\source\repos\Olio-ohjelmointi\Object oriented programming1\FilesExercise\myBooks.json", JsonConvert.SerializeObject(books));

