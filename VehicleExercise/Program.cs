using VehicleExercise;

//Vehicle vehicle = new Vehicle("Mercedes Benz", "AMG", "2023", 100000);
Car car = new("Mercedes Benz", "AMG", 2023, 100000, "V8", "Sedan", 4);
Car car1 = new("BWM", "5-sarja", 2023, 80000, "V6", "Sedan", 4);
//vehicle.PrintInformation();

car.PrintInformation();
Console.WriteLine(car1.ToString());
Console.WriteLine(car.Equals(car1));
Console.WriteLine();

Truck truck = new("SISU", "CK16M", 2023, 200000, "V100", "Yhdistelmä", 2, 5, 9.5);
Truck truck1 = new("SISU", "CK23M", 2022, 160000, "V2500", "Yhdistelmä", 3, 5, 8.5);

truck.PrintInformation();
Console.WriteLine("Kokonaiskulutus: " + truck.CalculateConsumption() + "l/100km");
Console.WriteLine();
truck1.PrintInformation();
Console.WriteLine("Kokonaiskulutus: " + truck1.CalculateConsumption() + "l/100km");

//Truck t = car as Truck;

if (truck1 is Car)
{
    Console.WriteLine("\nTyyppimuunnos Auto -> Rekka: onnistui");
}
else
{
    Console.WriteLine("Tyyppimunnos Auto -> Rekka: epäonnistui");
}

if (car1 is Truck)
{
    Console.WriteLine("Tyyppimuunnos Rekka -> Auto: onnistui");
}
else
{
    Console.WriteLine("Tyyppimuunnos Rekka -> Auto: epäonnistui");
}

//Employee e = new Employee();
//e.GetInfo();

//Employee boss = new Employee("Sepi", "69420");
//Employee boss2 = new Employee("Kartsa", "AB123");
//Employee boss3 = new Employee("Sepi", "69420");

//Console.WriteLine("GetInfo():");
//boss.GetInfo();
//Console.WriteLine("ToString():");
//Console.WriteLine(boss.ToString());

//Console.WriteLine("\nVERTAILUA");
//Console.WriteLine("Onko samat: " + boss.Equals(boss2));
//Console.WriteLine("Onko samat: " + boss.Equals(boss3));

//if (boss.Equals(boss2))
//{
//    Console.WriteLine(boss.ToString() + " ja " + boss2.ToString() + " ovat yhtäsuuria");
//}
//else
//{
//    Console.WriteLine(boss.ToString() + " ja " + boss2.ToString() + " eivät ole yhtäsuuria");
//}

//Person p = boss as Person;
//p.GetInfo();