using System.Collections.Generic;

namespace OpenClosed.UseOCP.ProductFilters
{
    class QuantityFilterSpecification : ProductFilterSpecification
    {
        private readonly int _quantity;

        public QuantityFilterSpecification(int quantity)
        {
            _quantity = quantity;
        }

        protected override IEnumerable<Product> ApplyFilter(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                if (product != null && product.Quantity == _quantity)
                    yield return product;
            }
        }
    }
}
