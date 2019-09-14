namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintWithoutUsingDIP();
            PrintWithUseDIP();
        }

        static void PrintWithoutUsingDIP()
        {
            WithoutUsingDIP.Printer printer = new WithoutUsingDIP.Printer();
            printer.Print(WithoutUsingDIP.EPrintType.COLOR);
            printer.Print(WithoutUsingDIP.EPrintType.NOCOLOR);
            printer.Print(WithoutUsingDIP.EPrintType._3D);
            printer.Print(WithoutUsingDIP.EPrintType._2D);
        }

        static void PrintWithUseDIP()
        {
            WithUseDIP.Printer printer = new WithUseDIP.Printer();
            printer.Print(new WithUseDIP.ColorPrinter());
            printer.Print(new WithUseDIP.NoColorPrinter());
            printer.Print(new WithUseDIP._3DPrinter());
            printer.Print(new WithUseDIP._2DPrinter());
        }
    }
}
