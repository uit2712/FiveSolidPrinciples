using System;

namespace InterfaceSegregation.WithUseISP
{
    class Shark : Animal, ISwim
    {
        public Shark()
        {
            Name = "shark";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hello, I am " + Name + ", I can do these things: ");
            Eat();
            Swim();
        }

        public void Swim()
        {
            Console.WriteLine("I can swim.");
        }
    }
}
