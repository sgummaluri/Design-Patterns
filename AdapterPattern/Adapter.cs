using Adapter.Contracts;
using System;

namespace Adapter
{
    public class Adapter : ITarget
    {
        public string GetAllProductNames()
        {
            Adaptee adaptee = new Adaptee();
            string FormattedString = "<ul>{0}</ul>";
            string placeholder = string.Empty;
            var productList = adaptee.GetAllProducts();

            foreach (var product in productList)
            {
                placeholder += "<li>" + product.Name + "</li>";
            }

            return String.Format(FormattedString, placeholder);
        }
    }
}
