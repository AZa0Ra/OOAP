using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Printers
{
    internal class PrinterSelector
    {
        public static IPrinter ChoosePrinter(string size, bool isColor, int pages)
        {
            if (size == "A0" || size == "A1")
                return new PlotterPrinter();

            if (isColor)
                return new ColorPrinter();

            return new LaserPrinter();
        }
    }
}
