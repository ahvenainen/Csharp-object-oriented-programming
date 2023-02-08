using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal class Triangle : Shape
    {
        private double length;
        private double width;

        public Triangle(string type, string color, double length, double width) : base(type, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            double area = (width * length) / 2;
            return Math.Round(area);
        }

        public override string GetInfo()
        {
            return "Type: " + type + "\nColor: " + color + "\nLength: " + length + "\nWidth: " + width + "\nArea: " + GetArea();
        }
    }
}
