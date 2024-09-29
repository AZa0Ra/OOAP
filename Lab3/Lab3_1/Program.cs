using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCreator shapeCreator = null;
            while (true)
            {
                Console.WriteLine("Select a shape to draw:");
                Console.WriteLine("1 - Circle");
                Console.WriteLine("2 - Rectangle");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    {
                        Console.WriteLine("Enter R");
                        if (!double.TryParse(Console.ReadLine(), out double radius))
                        {
                            Console.WriteLine("Invalid radius");
                            continue;
                        }
                        Console.WriteLine("Enter the color:");
                        string color = Console.ReadLine();
                        shapeCreator = new CircleCreator(radius, color);
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("Enter width:");
                        if (!int.TryParse(Console.ReadLine(), out int width))
                        {
                            Console.WriteLine("Invalid width");
                            continue;
                        }
                        Console.WriteLine("Enter height:");
                        if (!int.TryParse(Console.ReadLine(), out int height))
                        {
                            Console.WriteLine("Invalid height");
                            continue;
                        }
                        Console.WriteLine("Enter the color:");
                        string color = Console.ReadLine();
                        shapeCreator = new RectangleCreator(width, height, color);
                        break;
                    }
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Shape shape = shapeCreator.CreateShape();

                Console.WriteLine("Enter X:");
                if (!int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.WriteLine("Invalid X");
                    continue;
                }
                Console.WriteLine("Enter Y:");
                if (!int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.WriteLine("Invalid Y");
                    continue;
                }

                shape.Draw(x, y);
                Console.WriteLine($"The area of the color is: {shape.Color}");
                Console.WriteLine($"The area of the shape is: {shape.GetArea()}");

                var (centerX, centerY) = shape.GetCircleCenter();
                Console.WriteLine($"The center of the circle is ({centerX}, {centerY})");

            }
        }
    }
}
