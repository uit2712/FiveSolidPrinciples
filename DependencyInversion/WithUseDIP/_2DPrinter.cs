using System;

namespace DependencyInversion.WithUseDIP
{
    class _2DPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print 2d...");
        }
    }
}
