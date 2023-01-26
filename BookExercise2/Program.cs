using BookExercise2;
using Literature;

Book book1 = new("Värityskirja", "Sepponen", "WSOY", 31.90, "978K43SMV48S9");
Book book2 = new("Puuhakirja", "Penttinen", "OTAVA", 35.90, "978I4MF93GK9K");
Book book3 = new("Remonttikirja", "Isomäki", "WSOY", 36.90, "978F8SJFMGK3J");
Book.ChangeTheme("Lasten");
book1.GetBookDetails("978K43SMV48S9");
Book.ChangeTheme("Fiktio");
book2.GetBookDetails("978I4MF93GK9K");
Book.ChangeTheme("Seikkailu");
book3.GetBookDetails("978F8SJFMGK3J");
Console.WriteLine(book1.Author);
Console.WriteLine(book2.Author);
Console.WriteLine(book3.Author);

Author author1 = new("Sepponen", "16.1.1993", book1);
Author author2 = new("Penttinen", "16.1.1992", book2);
Author author3 = new("Isomäki", "16.1.1991");

author1.PrintInformation();
author2.PrintInformation();
author3.PrintInformation();
