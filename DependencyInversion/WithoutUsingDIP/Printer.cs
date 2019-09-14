using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.WithoutUsingDIP
{
    class Printer
    {
        public void Print(EPrintType printType)
        {
            switch(printType)
            {
                default:
                case EPrintType.COLOR:
                    PrintColor();
                    break;
                case EPrintType.NOCOLOR:
                    PrintNoColor();
                    break;
                case EPrintType._3D:
                    Print3D();
                    break;
                case EPrintType._2D:
                    Print2D();
                    break;
            }
        }

        void PrintColor()
        {
            Console.WriteLine("Print color...");
        }

        void PrintNoColor()
        {
            Console.WriteLine("Print no color...");
        }

        void Print3D()
        {
            Console.WriteLine("Print 3d...");
        }

        void Print2D()
        {
            Console.WriteLine("Print 2d...");
        }
    }
}
