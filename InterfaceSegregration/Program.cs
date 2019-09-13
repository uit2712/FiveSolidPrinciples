using System.Collections.Generic;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            //NotUseISP();
            UseISP();
        }

        private static void NotUseISP()
        {
            List<WithoutUsingISP.Animal> animals = new List<WithoutUsingISP.Animal>();
            animals.Add(new WithoutUsingISP.Frog());
            animals.Add(new WithoutUsingISP.Owl());
            animals.Add(new WithoutUsingISP.Shark());

            foreach (var animal in animals)
                animal.Introduce();
        }

        private static void UseISP()
        {
            List<WithUseISP.Animal> animals = new List<WithUseISP.Animal>();
            animals.Add(new WithUseISP.Frog());
            animals.Add(new WithUseISP.Owl());
            animals.Add(new WithUseISP.Shark());

            foreach (var animal in animals)
                animal.Introduce();
        }
    }
}
