using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Printers
{
    internal class PlotterPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("[Плотер] Друк великоформатного документу: " + document);
        }
    }
}
