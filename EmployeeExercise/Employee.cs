using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{

    internal class Employee
    {
        string name;
        string id;
        string position;
        double salary;
        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine(this.name + "n palkka (" + this.salary + ") on suurempi kuin " + employee.name + "n palkka (" + employee.salary + ")");
            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine(this.name + "n palkka (" + this.salary + ") on pienempi kuin " + employee.name + "n palkka (" + employee.salary + ")");
            }
            else
            {
                Console.WriteLine(this.name + "n (" + this.salary + ") ja " + employee.name + "n (" + employee.salary + ") palkat ovat yhtä suuret");
            }
        }
        
        public void PrintEmployeeInfo()
        {
            Console.WriteLine("Nimi: {0}\nID: {1}\nTehtävä: {2}\nPalkka: {3} e/kk\n", name, id, position, salary);
        }

        public override string? ToString()
        {
            return "Nimi: " + this.name + "\nID: " + this.id + "\nTehtävä: " + this.position +
                "\nPalkka: " + this.salary + " e/kk";
        }
    }
}
