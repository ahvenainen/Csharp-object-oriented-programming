// See https://aka.ms/new-console-template for more information
using CompanyExercise;

Console.WriteLine("This is Company Exericse!");
Console.WriteLine("-------------------------\n");

Company finnair = new Company("Finnair Oyj", "Kalevankatu 4", "01122 22", 3000, 3000);
//finnair.setTitle("Finnair Oyj");
finnair.PrintInfo();
Console.WriteLine(finnair.ToString());
finnair.Voitot();
Console.WriteLine("");

Company lufthansa = new Company("Lufthansa Group", "Mannerheimintie 50", "010 12345", 5000000, 2500000);
//lufthansa.setTitle("Lufthansa Group");
lufthansa.PrintInfo();
Console.WriteLine(lufthansa.ToString());
lufthansa.Voitot();
Console.WriteLine("");

//kopio
Company finavia = new Company(lufthansa);
finavia.PrintInfo();
Console.WriteLine(finavia.ToString());
finavia.Voitot();