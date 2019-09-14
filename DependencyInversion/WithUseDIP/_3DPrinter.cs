using System;

namespace DependencyInversion.WithUseDIP
{
    class _3DPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print 3d...");
        }
    }
}
