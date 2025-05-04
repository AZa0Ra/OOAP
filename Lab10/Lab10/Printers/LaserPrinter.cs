using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Printers
{
    internal class LaserPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("[Лазерний принтер] Друк документу: " + document);
        }
    }
}
