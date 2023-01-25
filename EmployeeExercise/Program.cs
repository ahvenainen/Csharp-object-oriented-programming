using EmployeeExercise;

Console.WriteLine("Työntekijöiden tiedot\n");

Employee[] employees = new Employee[3];
employees[0] = new Employee("Jorma", "111", "Kirurgi", 25000);
employees[1] = new Employee("Sepi", "222", "Lentäjä", 220007);
employees[2] = new Employee("Jesse", "333", "Astronautti", 23000);

Console.WriteLine("Tietojen tulostus käyttäen PrintEmployeeInfo-metodia");
Console.WriteLine("----------------------------------------------------");
for (int i = 0; i < employees.Length; i++)
{
    employees[i].PrintEmployeeInfo();
}
Console.WriteLine("Tietojen tulostus käyttäen ToString-metodia");
Console.WriteLine("-------------------------------------------");
for (int i = 0; i < employees.Length; i++)
{
    Console.WriteLine(employees[i].ToString() + "\n");
}

Console.WriteLine("---------------------\n");

for (int i = 0; i < employees.Length; i++)
{
    Employee nykyinen = employees[i];
    Employee seuraava;
    if (i == employees.Length - 1)
    {
        seuraava = employees[0];
    }
    else
    {
        seuraava = employees[i + 1];
    }
    nykyinen.CompareSalary(seuraava);
}