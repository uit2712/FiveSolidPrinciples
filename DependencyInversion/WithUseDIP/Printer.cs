using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.WithUseDIP
{
    class Printer
    {
        public void Print(IPrinter printer)
        {
            printer.Print();
        }
    }
}
