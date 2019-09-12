using OpenClosed.UseOCP.ProductFilters;
using System.Collections.Generic;

namespace OpenClosed.UseOCP
{
    class Store
    {
        private List<Product> _products = new List<Product>();
        
        public Store()
        {
            _products.AddRange(new List<Product>
            {
                new Product{ Name = "Product 1", Color = "Red", Quantity = 15 },
                new Product{ Name = "Product 2", Color = "Blue", Quantity = 25 },
                new Product{ Name = "Product 3", Color = "Green", Quantity = 35 },
                new Product{ Name = "Product 4", Color = "Brown", Quantity = 35 },
                new Product{ Name = "Product 5", Color = "Red", Quantity = 37 },
                new Product{ Name = "Product 6", Color = "Red", Quantity = 23 },
                new Product{ Name = "Product 7", Color = "Green", Quantity = 69 },
            });
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public IEnumerable<Product> Filter(ProductFilterSpecification filter)
        {
            return filter.Filter(_products);
        }
    }
}
