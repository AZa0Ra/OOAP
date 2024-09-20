using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooap_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3);
            circle.PrintArea();

            Shape square = new Square(5);
            square.PrintArea();

            Shape rectangle = new Rectangle(6, 8);
            rectangle.PrintArea();



            
        }
    }
}
