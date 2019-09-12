namespace UseLSP.LiskovSubstitution
{
    abstract class Lover
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Kiss();
        public abstract void Gift();
    }
}
