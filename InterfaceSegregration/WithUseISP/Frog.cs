using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.WithUseISP
{
    class Frog : Animal, ISwim, IClimb, ISpeak
    {
        public Frog()
        {
            Name = "frog";
        }

        public void Climb()
        {
            Console.WriteLine("I can climb.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hello, I am " + Name + ", I can do these things: ");
            Climb();
            Eat();
            Speak();
            Swim();
        }

        public void Speak()
        {
            Console.WriteLine("I can speak: croak croak");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim.");
        }
    }
}
