using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    internal abstract class Shape : IComparable<Shape>
    {
        protected string type;
        protected string color;

        protected Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        public abstract double GetArea();
        public abstract string GetInfo();

        
        public string GetColor()
        {
            return color;
        }

        //public int CompareTo(Shape? other)
        //{
        //    return GetArea().CompareTo(other?.GetArea());
        //}

        public int CompareTo(Shape? other)
        {
            return this.GetColor().CompareTo(other?.GetColor());
        }
    }
}
