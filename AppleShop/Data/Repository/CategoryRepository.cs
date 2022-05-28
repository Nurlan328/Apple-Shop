using AppleShop.Data.Interface;
using AppleShop.Data.Models;

namespace AppleShop.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> GetCategories => appDBContent.Category;
    }
}
