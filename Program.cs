namespace FiveSolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Nam nam = new Nam(25);
            nam.AddLover(new Hoa(18));
            nam.AddLover(new Hue(23));
            nam.AddLover(new Hong(26));

            nam.Kiss();
            nam.Gift();
        }
    }
}
