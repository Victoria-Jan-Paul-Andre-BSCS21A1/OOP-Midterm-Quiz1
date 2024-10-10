using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IColorable
{
    Color Color { get; set; }
    string Paint(string color);
}


namespace ClassLibrary1
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape, IColorable
    {
        public double Radius { get; set; }
        public Color Color { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public string Paint(string color)
        {
            return $"Painting the circle {color}.";
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

}
