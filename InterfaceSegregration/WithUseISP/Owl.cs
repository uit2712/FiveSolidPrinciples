using System;

namespace InterfaceSegregation.WithUseISP
{
    class Owl : Animal, IFly, ISpeak
    {
        public Owl()
        {
            Name = "owl";
        }

        public void Fly()
        {
            Console.WriteLine("I can fly.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hello, I am " + Name + ", I can do these things: ");
            Fly();
            Eat();
            Speak();
        }

        public void Speak()
        {
            Console.WriteLine("I can speak.");
        }
    }
}
