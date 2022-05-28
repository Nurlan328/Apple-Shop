using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Interface;
using AppleShop.Data.Models;
using AppleShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppleShop.Data.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProducts _products;
        private readonly IProductsCategory _productsCategory;

        public ProductsController (IProducts iProducts, IProductsCategory iProductsCategory)
        {
            _products = iProducts;
            _productsCategory = iProductsCategory;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Product> products = null;
            string currentCategory = "";
            string categoryName = "";
            if (string.IsNullOrEmpty(category))
            {
                products = _products.GetProducts.OrderBy(x => x.Id);
            }
            else
            {
                products = _products.GetProducts.Where(x => x.Category.CategoryName.Equals(category, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.Id);
                categoryName = ": " + _productsCategory.GetCategories.Where(x => x.CategoryName.Equals(category, StringComparison.OrdinalIgnoreCase)).First().CategoryName;
                currentCategory = _productsCategory.GetCategories.Where(x => x.CategoryName.Equals(category, StringComparison.OrdinalIgnoreCase)).First().CategoryName;
            }

            var productObject = new ProductsListViewModel
            {
                    AllProducts = products,
                    ProductCategory = currentCategory,
            };

            ViewBag.Title = "All Products" + categoryName;
            return View(productObject);
        }
    }
}