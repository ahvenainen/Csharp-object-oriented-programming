using SortExercise;

List<Book> books = new List<Book>
{
    new Book("Hölmölän tarinat1", "Seppänen", "Hukkala", 15.00, "978VKAOEKG4JE"),
    new Book("Hölmölän tarinat2", "Seppänen", "Hukkanen", 20.00, "978VKAOEKG4JE"),
    new Book("Hölmölän tarinat3", "Seppänen", "Hukkila", 10.00, "978VKAOEKG4JE")
};
books.Add(books[0]);

foreach (Book c in books)
{
    Console.WriteLine(c);
}

books.Sort();
Console.WriteLine("----------------------------------------------------------------");

foreach (Book b in books)
{
    Console.WriteLine(b);
}
