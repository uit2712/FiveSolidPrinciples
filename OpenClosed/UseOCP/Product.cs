namespace OpenClosed.UseOCP
{
    class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", color: " + Color + ", quantity: " + Quantity;
        }
    }
}
