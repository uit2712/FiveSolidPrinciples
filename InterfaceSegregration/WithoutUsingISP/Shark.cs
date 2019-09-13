using System;

namespace InterfaceSegregation.WithoutUsingISP
{
    class Shark : Animal
    {
        public Shark()
        {
            Name = "shark";
        }

        public override void Climb()
        {
            
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
            
        }

        public override void Swim()
        {
            Console.WriteLine("I can swim.");
        }
    }
}
