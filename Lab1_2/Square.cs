using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooap_lab1
{
    class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            try
            {
                if (side > 0)
                    Side = side;
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
            return Side * Side;
        }
    }
}
