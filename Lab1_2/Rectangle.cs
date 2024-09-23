using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ooap_lab1
{
    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            try
            {
                if (width > 0 && height > 0)
                {
                    Width = width;
                    Height = height;
                }
                else
                    Console.WriteLine("Area can't be minus");
            }
            catch (Exception e)
            {
                Console.WriteLine("Must be positive numbers", e);
            }
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
