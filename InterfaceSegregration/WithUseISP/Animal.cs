using System;

namespace InterfaceSegregation.WithUseISP
{
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Introduce();
        public virtual void Eat()
        {
            Console.WriteLine("I can eat.");
        }
    }
}
