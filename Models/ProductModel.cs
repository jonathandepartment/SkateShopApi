using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkateShopApi.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int UnitsInStock { get; set; }
        public bool Chosen { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public string AdditionalInformation { get; set; }

    }
}
