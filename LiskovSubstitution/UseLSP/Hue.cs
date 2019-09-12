using System;

namespace UseLSP.LiskovSubstitution
{
    /// <summary>
    /// Người yêu có cá tính
    /// </summary>
    class Hue : Lover
    {
        public Hue(int age)
        {
            Name = "Hue";
            Age = age;
        }

        public override void Gift()
        {
            Console.WriteLine(Name + ": u oi, dep the, em cam on anh!");
        }

        public override void Kiss()
        {
            Console.WriteLine(Name + ": tat cho 3 bat tai");
        }
    }
}
