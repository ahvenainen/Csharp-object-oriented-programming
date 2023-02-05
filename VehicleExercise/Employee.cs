using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Employee: Person
    {
        private string id;
        public Employee()
        {
            this.id = "3JVKV84KLSL";
        }

        public Employee(string name, string id) : base(name)
        {
            this.id = id;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            //Console.WriteLine("Nimi: " + name + ", ID: " + id);
            Console.WriteLine(" ID: " + id);
        }

        public override string? ToString()
        {
            return base.ToString() + " ID: " + id;
        }
    }
}
