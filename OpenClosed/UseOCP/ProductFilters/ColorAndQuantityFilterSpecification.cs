using System.Collections.Generic;

namespace OpenClosed.UseOCP.ProductFilters
{
    class ColorAndQuantityFilterSpecification : ProductFilterSpecification
    {
        private readonly string _color;
        private readonly int _quantity;

        public ColorAndQuantityFilterSpecification(string color, int quantity)
        {
            _color = color;
            _quantity = quantity;
        }

        protected override IEnumerable<Product> ApplyFilter(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                if (product != null && product.Color.Equals(_color) && product.Quantity == _quantity)
                    yield return product;
            }
        }
    }
}
