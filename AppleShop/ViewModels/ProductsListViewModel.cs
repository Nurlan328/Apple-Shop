using AppleShop.Data.Models;
using System.Collections.Generic;

namespace AppleShop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }

        public string ProductCategory { get; set; }
    }
}
