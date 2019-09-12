using System;
using System.Collections.Generic;

namespace LiskovSubstitution.WithoutUsingLSP
{
    class Nam : Lover, ILoverAction
    {
        private List<Lover> _lovers = new List<Lover>();

        public Nam(int age)
        {
            Name = "Nam";
            Age = age;
        }

        public void AddLover(Lover lover)
        {
            if (lover != null)
                _lovers.Add(lover);
        }

        public void Gift()
        {
            foreach (Lover lover in _lovers)
            {
                if (lover.GetType() == typeof(Hoa))
                    Console.WriteLine(lover.Name + ": em cam on anh, ahihi!");

                if (lover.GetType() == typeof(Hue))
                    Console.WriteLine(lover.Name + ": u oi, dep the, em cam on anh!");

                if (lover.GetType() == typeof(Hong))
                    Console.WriteLine(lover.Name + ": thoi, em can 1 can nha co, anh co khong cho em xin?");
            }
        }

        public void Kiss()
        {
            foreach (Lover lover in _lovers)
            {
                if (lover.GetType() == typeof(Hoa))
                    Console.WriteLine(lover.Name + ": anh ky qua ha :)))");

                if (lover.GetType() == typeof(Hue))
                    Console.WriteLine(lover.Name + ": tat cho 3 bat tai");

                if (lover.GetType() == typeof(Hong))
                    Console.WriteLine(lover.Name + ": anh xe em ra di!!!");
            }
        }
    }
}
