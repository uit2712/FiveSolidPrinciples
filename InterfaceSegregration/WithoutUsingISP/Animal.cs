using System;

namespace InterfaceSegregation.WithoutUsingISP
{
    abstract class Animal: IAnimalAction
    {
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hello, I am " + Name + ", I can do these things: ");
            Climb();
            Fly();
            Eat();
            Speak();
            Swim();
        }

        public abstract void Climb();
        public abstract void Eat();
        public abstract void Fly();
        public abstract void Speak();
        public abstract void Swim();
    }
}
