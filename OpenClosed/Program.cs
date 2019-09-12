using OpenClosed.UseOCP.ProductFilters;
using System;
using System.Collections.Generic;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilterWithOCP();
            FilterWithoutOCP();
        }

        private static void FilterWithoutOCP()
        {
            WithoutUsingOCP.Store store = new WithoutUsingOCP.Store();
            Console.WriteLine("All products:");
            IEnumerable<UseOCP.Product> allProducts = store.GetProducts();
            foreach (UseOCP.Product product in allProducts)
                Console.WriteLine(product.ToString());

            WithoutUsingOCP.ProductFilter productFilter = new WithoutUsingOCP.ProductFilter();

            string color = "Green";
            Console.WriteLine(color + " products:");
            IEnumerable<UseOCP.Product> greenProducts = productFilter.ByColor(allProducts, color);
            foreach (UseOCP.Product product in greenProducts)
                Console.WriteLine(product.ToString());

            int quantity = 35;
            Console.WriteLine("Products with quantity = " + quantity);
            IEnumerable<UseOCP.Product> quantityProducts = productFilter.ByQuantity(allProducts, quantity);
            foreach (UseOCP.Product product in quantityProducts)
                Console.WriteLine(product.ToString());

            Console.WriteLine("Green products with quantity = " + quantity);
            IEnumerable<UseOCP.Product> greenAnd35Products = productFilter.ByColorAndQuantity(allProducts, color, quantity);
            foreach (UseOCP.Product product in greenAnd35Products)
                Console.WriteLine(product.ToString());
        }

        private static void FilterWithOCP()
        {
            UseOCP.Store store = new UseOCP.Store();
            Console.WriteLine("All products:");
            IEnumerable<UseOCP.Product> allProducts = store.GetProducts();
            foreach (UseOCP.Product product in allProducts)
                Console.WriteLine(product.ToString());

            string color = "Green";
            Console.WriteLine(color + " products:");
            IEnumerable<UseOCP.Product> greenProducts = store.Filter(new ColorFilterSpecification(color));
            foreach (UseOCP.Product product in greenProducts)
                Console.WriteLine(product.ToString());

            int quantity = 35;
            Console.WriteLine("Products with quantity = " + quantity);
            IEnumerable<UseOCP.Product> quantityProducts = store.Filter(new QuantityFilterSpecification(quantity));
            foreach (UseOCP.Product product in quantityProducts)
                Console.WriteLine(product.ToString());

            Console.WriteLine("Green products with quantity = " + quantity);
            IEnumerable<UseOCP.Product> greenAnd35Products = store.Filter(new ColorAndQuantityFilterSpecification(color, quantity));
            foreach (UseOCP.Product product in greenAnd35Products)
                Console.WriteLine(product.ToString());
        }
    }
}
