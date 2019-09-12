using System.Collections.Generic;

namespace OpenClosed.UseOCP.ProductFilters
{
    class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly string _color;

        public ColorFilterSpecification(string color)
        {
            _color = color;
        }

        protected override IEnumerable<Product> ApplyFilter(IEnumerable<Product> products)
        {
            foreach(Product product in products)
            {
                if (product != null && product.Color.Equals(_color))
                    yield return product;
            }
        }
    }
}
