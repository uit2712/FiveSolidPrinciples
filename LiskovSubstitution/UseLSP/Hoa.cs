using System;

namespace UseLSP.LiskovSubstitution
{
    /// <summary>
    /// Người yêu bánh bèo
    /// </summary>
    class Hoa : Lover
    {
        public Hoa(int age)
        {
            Name = "Hoa";
            Age = age;
        }

        public override void Gift()
        {
            Console.WriteLine(Name + ": em cam on anh, ahihi!");
        }

        public override void Kiss()
        {
            Console.WriteLine(Name + ": anh ky qua ha :)))");
        }
    }
}
