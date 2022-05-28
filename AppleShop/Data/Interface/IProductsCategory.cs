using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Models;

namespace AppleShop.Data.Interface
{
    public interface IProductsCategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
