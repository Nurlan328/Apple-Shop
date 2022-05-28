using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Models;

namespace AppleShop.Data.Interface
{
    public interface IProducts
    {
        IEnumerable<Product> GetProducts { get; }
        IEnumerable<Product> GetFavProducts { get; }
        Product GetProductById(int id);
    }
}
