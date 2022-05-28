using AppleShop.Data.Interface;
using AppleShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AppleShop.Data.Repository
{
    public class ProductRepository : IProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository (AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> GetProducts => appDBContent.Product.Include(p => p.Category);

        public IEnumerable<Product> GetFavProducts => appDBContent.Product.Where(p => p.IsFavourite).Include(c => c.Category);

        public Product GetProductById(int id) => appDBContent.Product.FirstOrDefault(p => p.Id == id);
    }
}
