using System;

namespace InterfaceSegregation.WithoutUsingISP
{
    class Owl : Animal
    {
        public Owl()
        {
            Name = "owl";
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
            Console.WriteLine("I can fly.");
        }

        public override void Speak()
        {
            Console.WriteLine("I can speak: hoot hoot.");
        }

        public override void Swim()
        {
            
        }
    }
}
