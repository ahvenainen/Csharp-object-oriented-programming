using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string type, string color, double r) : base(type, color)
        {
            radius = r;
        }

        public override double GetArea()
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 2);
        }

        public override string GetInfo()
        {
            return "Type: " + this.type + " \nColor: " + this.color + " \nRadius: " + this.radius + "\nArea: " + this.GetArea();
        }
    }
}
