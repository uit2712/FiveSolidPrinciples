using System.Collections.Generic;

namespace OpenClosed.UseOCP.ProductFilters
{
    abstract class ProductFilterSpecification
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products)
        {
            return ApplyFilter(products);
        }

        protected abstract IEnumerable<Product> ApplyFilter(IEnumerable<Product> products);
    }
}
