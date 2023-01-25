using BookExercise2;

Book book1 = new("Värityskirja", "Kyrömäki", "WSOY", 31.90, "978K43SMV48S");
Book book2 = new("Puuhakirja", "Penttinen", "OTAVA", 35.90, "978I4MF93GK9K");
Book book3 = new("Remonttikirja", "Isomäki", "WSOY", 36.90, "978F8SJFMGK3J");
Book.ChangeTheme("Lasten");
book1.GetBookDetails("97843SMV48S9");
Book.ChangeTheme("Fiktio");
book2.GetBookDetails("978I4MF93GK9K");
Book.ChangeTheme("Seikkailu");
book3.GetBookDetails("978F8SJFMGK3J");
Console.WriteLine(book1.Author);
Console.WriteLine(book2.Author);
Console.WriteLine(book3.Author);
