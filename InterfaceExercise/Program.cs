using InterfaceExercise;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Store dna = new("DNA Oyj", 1000000);
dna.AddProduct(new("Telakka", 50, 50));
dna.AddProduct(new("Puhelin", 500, 50));
dna.AddProduct(new("Laturi", 20, 50));
dna.AddCustomer(new("Pekka", 500));
dna.AddCustomer(new("Samuli", 1500));
dna.AddCustomer(new("Seppo", 1000));

Console.WriteLine(dna.ToString());
dna.PrintProducts();
dna.PrintCustomers();

//Ylimääräistä koodia. Ei tarvitse huomioida.

//List<Product> products = new List<Product>()
//{
//    new Product("Puhelin", 150, 3),
//    new Product("Laturi", 30, 3),
//    new Product("Kuulokkeet", 123, 4),
//};

//foreach(Product p in products)
//{
//    Console.WriteLine(p.ToString());
//    Console.WriteLine("Varaston arvo: " + p.CalculateTotal() + "€");
//}

//Store dna = new Store("DNA", 1000000);
//dna.AddProduct(new Product("Phone", 150, 3));
//dna.AddProduct(new Product("Charger", 30, 3));
//dna.PrintProducts();

//Console.WriteLine();
//List<Customer> customers = new List<Customer>()
//{
//    new Customer("Pekka", 1000),
//    new Customer("Samuli", 2000),
//    new Customer("Eemeli", 3001)
//};


//Console.WriteLine("\u001b[3m\n-------ASIAKKAAT-------\u001b[0m");
//foreach (Customer customer in customers)
//{
//    Console.WriteLine(customer.ToString());
//    Console.WriteLine("Bonus on: " + customer.GetBonus());
//    if (customer.GetCustomer("Samuli") != null)
//    {
//        Console.WriteLine("Henkilö on sama kuin kutsuttava");
//    }
//}
