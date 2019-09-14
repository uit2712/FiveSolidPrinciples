using System;

namespace DependencyInversion.WithUseDIP
{
    class NoColorPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print no color...");
        }
    }
}
