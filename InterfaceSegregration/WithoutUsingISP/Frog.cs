using System;

namespace InterfaceSegregation.WithoutUsingISP
{
    class Frog : Animal
    {
        public Frog()
        {
            Name = "frog";
        }

        public override void Climb()
        {
            Console.WriteLine("I can climb.");
        }

        public override void Eat()
        {
            Console.WriteLine("I can eat.");
        }

        public override void Fly()
        {
            
        }

        public override void Speak()
        {
            Console.WriteLine("I can speak: croak croak");
        }

        public override void Swim()
        {
            Console.WriteLine("I can swim.");
        }
    }
}
