using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkateShopApi.Models;
using static SkateShopApi.Models.ProductModel;

namespace SkateShopApi.Services
{
    static class ProductService
    {
        static List<ProductModel> Products { get; }
        static int nextId = 21;
        static ProductService()
        {
            Products = new List<ProductModel>()
                {
                    new ProductModel
                    {
                        Id = 1,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = "Hoodie",
                        Color = "Grey",
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = true,
                        Image = "~/Assets/products/sinus-hoodie-ash.png",
                        Size = "L"
                    },
                    new ProductModel
                    {
                        Id = 2,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = "Hoodie",
                        Color = "Blue",
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-ocean.png",
                        Size = "L"
                    },
                    new ProductModel
                    {
                        Id = 3,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = "Hoodie",
                        Color = "Red",
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-fire.png",
                        Size = "M"
                    },
                    new ProductModel
                    {
                        Id = 4,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = "Hoodie",
                        Color = "Green",
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-green.png",
                        Size = "M"
                    },
                    new ProductModel
                    {
                        Id = 5,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = "Hoodie",
                        Color = "Purple",
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-purple.png",
                        Size = "S"
                    },
                    new ProductModel
                    {
                        Id = 6,
                        Price = 800,
                        Name = "Gretas Fury",
                        Category = "Skateboard",
                        Color = "Patterned",
                        AdditionalInformation = "Wood",
                        Description = "Inflamed with energetic youth",
                        UnitsInStock = 4,
                        Chosen = true,
                        Size = "7,5",
                        Image = "~/Assets/products/sinus-skateboard-gretasfury.png",
                    },
                    new ProductModel
                    {
                        Id = 7,
                        Price = 2000,
                        Name = "Story Ink",
                        Category = "Skateboard",
                        Color = "Patterned",
                        AdditionalInformation = "Plastic",
                        Description = "Engineered to perfection",
                        UnitsInStock = 2,
                        Chosen = false,
                        Size = "7,5",
                        Image = "~/Assets/products/sinus-skateboard-ink.png",
                    },
                    new ProductModel
                    {
                        Id = 8,
                        Price = 1899,
                        Name = "Northern lights",
                        Category = "Skateboard",
                        Color = "Patterned",
                        AdditionalInformation = "Wood",
                        Description = "Aurora, You-rora! Handcrafted in Hemavan.",
                        UnitsInStock = 3,
                        Chosen = false,
                        Size = "8",
                        Image = "~/Assets/products/sinus-skateboard-northern_lights.png",
                    },
                    new ProductModel
                    {
                        Id = 9,
                        Price = 2899,
                        Name = "Gold Standard",
                        Category = "Skateboard",
                        Color = "Patterned",
                        AdditionalInformation = "Wood",
                        Description = "Luxourious gold-laminated wood, for the extravagant skater",
                        UnitsInStock = 3,
                        Chosen = false,
                        Size = "8",
                        Image = "~/Assets/products/sinus-skateboard-yellow.png",
                    },
                    new ProductModel
                    {
                        Id = 10,
                        Price = 899,
                        Name = "Blazing Saddle",
                        Category = "Skateboard",
                        Color = "Patterned",
                        AdditionalInformation = "Wood",
                        Description = "For people of the land",
                        UnitsInStock = 7,
                        Chosen = false,
                        Size = "8",
                        Image = "~/Assets/products/sinus-skateboard-fire.png",
                    },
                    new ProductModel
                    {
                        Id = 11,
                        Price =550,
                        Name = "Spitfire Rims",
                        Color = "Patterned",
                        Category = "Wheel",
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = true,
                        Image = "~/Assets/products/sinus-wheel-rocket.png",
                        AdditionalInformation = "99A",
                        Size = "52"
                    },
                    new ProductModel
                    {
                        Id = 12,
                        Price = 450,
                        Name = "Bones",
                        Color = "Patterned",
                        Category = "Wheel",
                        Description = "Rad rides crave these rims",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-spinner.png",
                        AdditionalInformation = "99A",
                        Size = "52"
                    },
                    new ProductModel
                    {
                        Id = 13,
                        Price = 500,
                        Name = "Spitfire Rims",
                        Color = "Patterned",
                        Category = "Wheel",
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-wave.png",
                        AdditionalInformation = "99A",
                        Size = "53"
                    },
                    new ProductModel
                    {
                        Id = 14,
                        Price = 500,
                        Name = "Spitfire Rad",
                        Color = "Patterned",
                        Category = "Wheel",
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-spinner.png",
                        AdditionalInformation = "99A",
                        Size = "53"
                    },
                    new ProductModel
                    {
                        Id = 15,
                        Price = 459,
                        Name = "Santa Cruz",
                        Color = "White",
                        Category = "Wheel",
                        Description = "Slick, perfect for shredding",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-wave.png",
                        AdditionalInformation = "100's",
                        Size = "53"
                    },
                    new ProductModel
                    {
                        Id = 16,
                        Price = 700,
                        Name = "DC Tonic",
                        Color = "Grey",
                        Category = "Shoes",
                        Description = "Comfort and durability, provides excellent grip when needed",
                        UnitsInStock = 8,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304263560_front.jpg-4YT7onA_uQovNtQuNrZCa8dXK1Q/Tonik+Skateskor.jpg?$b8$",
                        Size = "40"
                    },
                    new ProductModel
                    {
                        Id = 17,
                        Price = 700,
                        Name = "Nike Fri",
                        Color = "White",
                        Category = "Shoes",
                        Description = "Lightweight for agile moves, eggshell white",
                        UnitsInStock = 5,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304379064_front.jpg-QDAzF8yLhjdymEgEfDz7JsPQcFY/Nyjah+Free+2+NBA+Skateskor.jpg?$b8$",
                        Size = "41"
                    },
                    new ProductModel
                    {
                        Id = 18,
                        Price = 999,
                        Name = "Vans Retro",
                        Color = "Patterned",
                        Category = "Shoes",
                        Description = "None beats the classic, this timeless classic still performs",
                        UnitsInStock = 5,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304461078_front.jpg-lrgaqTMdXv39J5S9DBwECdE2JO4/Skate+Old+Skool+Skateskor.jpg?$b8$",
                        Size = "41"
                    },
                    new ProductModel
                    {
                        Id = 19,
                        Price = 799,
                        Name = "Adidas Buz",
                        Color = "White",
                        Category = "Shoes",
                        Description = "Designed by Buz, durable front for more stopping power",
                        UnitsInStock = 2,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304494977_front.jpg-eopv0HjOzWdRIedrB4_OfpWRXHY/Busenitz+Vulc+II+Skateskor.jpg?$b8$",
                        Size = "39"
                    },
                    new ProductModel
                    {
                        Id = 20,
                        Price = 899,
                        Name = "Emerica Sneaks",
                        Color = "Blue",
                        Category = "Shoes",
                        Description = "Designed by Buz, durable front for more stopping power",
                        UnitsInStock = 6,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304572494_front.jpg-a9YbnmLm2ybpONHT1_DBgIBo8yM/Dickson+Sneakers.jpg?$b8$",
                        Size = "42"
                    },
                    new ProductModel
                    {
                        Id = 21,
                        Price = 899,
                        Name = "Special Api Edition",
                        Color = "Blue",
                        Category = "Shoes",
                        Description = "If this is in inventory, the api was loaded",
                        UnitsInStock = 1,
                        Chosen = false,
                        Image = "https://i.kym-cdn.com/photos/images/facebook/001/379/081/562",
                        Size = "42"
                    },
                };
        }

        public static List<ProductModel> GetAll() => Products;
        public static ProductModel Get(int id) => Products.FirstOrDefault(product => product.Id == id);
        public static void Add(ProductModel product)
        {
            product.Id = nextId++;
            Products.Add(product);
        }

        public static void Delete(int id)
        {
            var product = Get(id);
            if (product is null)
            {
                return;
            }
            Products.Remove(product);
        }

        public static void Update(ProductModel productToUpdate)
        {
            var index = Products.FindIndex(product => product.Id == productToUpdate.Id);
            if (index == -1)
            {
                return;
            }
            Products[index] = productToUpdate;
        }
    }
}
