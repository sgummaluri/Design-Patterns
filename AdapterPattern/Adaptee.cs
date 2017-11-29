using Adapter.Entities;
using System.Collections.Generic;

namespace Adapter
{
    public class Adaptee
    {
        public List<Product> GetAllProducts()
        {
            var ProductList = new List<Product>();
            ProductList.Add(new Product { Name = "Product A", Price = 24.0M });
            ProductList.Add(new Product { Name = "Product B", Price = 25.0M });
            ProductList.Add(new Product { Name = "Product C", Price = 26.0M });
            ProductList.Add(new Product { Name = "Product D", Price = 27.0M });

            return ProductList;
        }
    }
}
