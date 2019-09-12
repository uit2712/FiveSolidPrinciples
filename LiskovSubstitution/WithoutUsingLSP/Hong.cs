namespace LiskovSubstitution.WithoutUsingLSP
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
    }
}
