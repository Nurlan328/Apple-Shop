using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Interface;
using AppleShop.Data.Models;

namespace AppleShop.Data.Mocks
{
    public class MockProducts : IProducts
    {
        private readonly IProductsCategory productsCategory = new MockCategory();
        public IEnumerable<Product> GetProducts {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "iPhone 13 Pro Max", Description = "iPhone 13 Pro Max Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = productsCategory.GetCategories.First()
                    },
                    new Product {
                        Name = "iPhone 13 Pro",
                        Description = "iPhone 13 Pro Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = productsCategory.GetCategories.First()
                    },
                    new Product {
                        Name = "iPhone 13",
                        Description = "iPhone 13 Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = productsCategory.GetCategories.First()
                    },
                    new Product {
                        Name = "iPhone 12",
                        Description = "iPhone 12 Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = productsCategory.GetCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
