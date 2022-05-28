using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AppleShop.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort Price { get; set; }
        public string Img { get; set; }
        public bool IsFavourite { get; set; }
        public bool Available { get; set; }


        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
