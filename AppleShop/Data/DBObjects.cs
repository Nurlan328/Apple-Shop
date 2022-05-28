using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Models;
using Microsoft.AspNetCore.Builder;

namespace AppleShop.Data
{
    public class DBObjects {
        public static void Initial(AppDBContent content)
        { 
            if(!content.Category.Any())
                content.AddRange(Categories.Select(c => c.Value));

            if (!content.Product.Any()) {
                content.AddRange(
                    new Product
                  {
                        Name = "iPhone 13 Pro Max",
                        Description = "iPhone 13 Pro Max Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["iPhone"]
                    },
                    new Product
                    {
                        Name = "iPhone 13 Pro",
                        Description = "iPhone 13 Pro Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["iPhone"]
                    },
                    new Product
                    {
                        Name = "iPhone 13",
                        Description = "iPhone 13 Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["iPhone"]
                    },
                    new Product
                    {
                        Name = "iPhone 12",
                        Description = "iPhone 12 Description",
                        Price = 45000,
                        Img = "/img/1.jpeg",
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["iPhone"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if(category == null) {
                    var list = new Category[] {
                        new Category {
                            CategoryName = "iPhone",
                            Description = "iPhone Description"
                        },
                        new Category {
                            CategoryName = "iPad",
                            Description = "iPad Description"
                        },
                        new Category {
                            CategoryName = "Watch",
                            Description = "Watch Description"
                        },
                        new Category {
                            CategoryName = "Mac",
                            Description = "Mac Description"
                        },
                        new Category {
                            CategoryName = "AirPods",
                            Description = "AirPods Description"
                        }
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }
        }
    }
}