using System;

namespace DependencyInversion.WithUseDIP
{
    class ColorPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print color...");
        }
    }
}
