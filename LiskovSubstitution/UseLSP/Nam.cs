using System.Collections.Generic;

namespace UseLSP.LiskovSubstitution
{
    class Nam : Lover
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

        public override void Gift()
        {
            foreach (Lover lover in _lovers)
                lover.Gift();
        }

        public override void Kiss()
        {
            foreach (Lover lover in _lovers)
                lover.Kiss();
        }
    }
}
