using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Shape
    {
        public abstract void Draw(int x, int y);
        public abstract double GetArea();
        public string Color { get; set; }
        public abstract (double x, double y) GetCircleCenter();
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public override void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a Circle at ({x}, {y}); Radius: {Radius}");
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override (double x, double y) GetCircleCenter()
        {
            return (0, 0);
        }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }
    class Rectangle : Shape
    {
        public double Height { get; }
        public double Width { get; }
        public override void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a Rectangle at ({x}, {y}); Width: {Width}, Height: {Height} ");
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override (double x, double y) GetCircleCenter()
        {
            return (Width / 2, Height / 2);
        }

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
    }
}
