using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    internal class Car
    {

        string brand;
        double speed;
        bool valid = false;
 
        public Car()
        {
            this.brand = string.Empty;
            this.speed = 0;
        }
        public void askData()
        {
            Console.Write("Anna merkki: ");
            this.brand = Console.ReadLine()??String.Empty;
            Console.Write("Anna nopeus: ");
            valid = double.TryParse(Console.ReadLine(), out this.speed);
            while (!valid)
            {
                Console.Write("Merkki ei sallittu. Anna uusi nopeus numeroina!: ");
                valid = double.TryParse(Console.ReadLine(), out this.speed);
            }
        }
        public void ShowCarInfo()
        {
            Console.WriteLine("Merkki on {0} ja nopeus on {1}", brand, speed);
            
        }
        public void Accelerate(int value)
        {

            if (value < 0)
            {
                Console.WriteLine("Negatiivinen arvo ei ole sallittu");
               
            }
            else
            {
                this.speed += value;
            }
        }
        public void Brake(double minus)
        {
            this.speed *= minus;
        }
        
    }
}
