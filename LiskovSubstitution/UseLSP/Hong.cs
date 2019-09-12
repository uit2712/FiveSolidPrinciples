using System;

namespace UseLSP.LiskovSubstitution
{
    /// <summary>
    /// Người yêu có tính đua đòi
    /// </summary>
    class Hong : Lover
    {
        public Hong(int age)
        {
            Name = "Hong";
            Age = age;
        }

        public override void Gift()
        {
            Console.WriteLine(Name + ": thoi, em can 1 can nha co, anh co khong cho em xin?");
        }

        public override void Kiss()
        {
            Console.WriteLine(Name + ": anh xe em ra di!!!");
        }
    }
}
