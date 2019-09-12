using OpenClosed.UseOCP;
using System.Collections.Generic;

namespace OpenClosed.WithoutUsingOCP
{
    class ProductFilter
    {
        public IEnumerable<Product> ByColor(IEnumerable<Product> products, string color)
        {
            foreach (Product product in products)
                if (product != null && product.Color.Equals(color))
                    yield return product;
        }

        public IEnumerable<Product> ByQuantity(IEnumerable<Product> products, int quantity)
        {
            foreach (Product product in products)
                if (product != null && product.Quantity == quantity)
                    yield return product;
        }

        public IEnumerable<Product> ByColorAndQuantity(IEnumerable<Product> products, string color, int quantity)
        {
            foreach (Product product in products)
                if (product != null && product.Color.Equals(color) && product.Quantity == quantity)
                    yield return product;
        }
    }
}
