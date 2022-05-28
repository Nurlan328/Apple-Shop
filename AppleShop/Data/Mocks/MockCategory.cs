using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleShop.Data.Interface;
using AppleShop.Data.Models;

namespace AppleShop.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> GetCategories
        {
            get { 
                return new List<Category>
                {
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
            }
        }
    }
}
