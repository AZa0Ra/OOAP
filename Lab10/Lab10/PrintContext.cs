using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10.Printers;

namespace Lab10
{
    internal class PrintContext
    {
        private IPrinter _printer;

        public void SetStrategy(IPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string document)
        {
            if (_printer == null)
            {
                Console.WriteLine("Принтер не обраний.");
                return;
            }

            _printer.Print(document);
        }
    }
}
