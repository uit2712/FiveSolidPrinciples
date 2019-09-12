namespace LiskovSubstitution.WithoutUsingLSP
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
    }
}
