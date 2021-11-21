using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SkateShopApi.Models;
using static SkateShopApi.Models.Enum;

namespace SkateShopApi.Services
{
    static class ProductService
    {
        static ArrayList Products { get; } = new ArrayList();
        static int nextId = 21;
        static ProductService()
        {

            List<ProductModel> AllProducts = new List<ProductModel>()
                {
                    new Clothing
                    {
                        Id = 1,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = Models.Enum.Category.Hoodie,
                        Color = Models.Enum.Color.Grey,
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = true,
                        Image = "~/Assets/products/sinus-hoodie-ash.png",
                        Size = Models.Enum.Size.L
                    },
                    new Clothing
                    {
                        Id = 2,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = Models.Enum.Category.Hoodie,
                        Color = Models.Enum.Color.Blue,
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-ocean.png",
                        Size = Models.Enum.Size.L
                    },
                    new Clothing
                    {
                        Id = 3,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = Models.Enum.Category.Hoodie,
                        Color = Models.Enum.Color.Red,
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-fire.png",
                        Size = Models.Enum.Size.M
                    },
                    new Clothing
                    {
                        Id = 4,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = Models.Enum.Category.Hoodie,
                        Color = Models.Enum.Color.Green,
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-green.png",
                        Size = Models.Enum.Size.M
                    },
                    new Clothing
                    {
                        Id = 5,
                        Price = 700,
                        Name = "Thrasher Hooded",
                        Category = Models.Enum.Category.Hoodie,
                        Color = Models.Enum.Color.Purple,
                        Description = "Durable, soft and dependable for the gnarliest skaters",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-hoodie-purple.png",
                        Size = Models.Enum.Size.S
                    },
                    new Boards
                    {
                        Id = 6,
                        Price = 800,
                        Name = "Gretas Fury",
                        Category = Models.Enum.Category.Skateboard,
                        Color = Models.Enum.Color.Patterned,
                        Material = Models.Enum.Material.Wood,
                        Description = "Inflamed with energetic youth",
                        UnitsInStock = 4,
                        Chosen = true,
                        BoardSize = 7.5,
                        Image = "~/Assets/products/sinus-skateboard-gretasfury.png",
                    },
                    new Boards
                    {
                        Id = 7,
                        Price = 2000,
                        Name = "Story Ink",
                        Category = Models.Enum.Category.Skateboard,
                        Color = Models.Enum.Color.Patterned,
                        Material = Models.Enum.Material.Plastic,
                        Description = "Engineered to perfection",
                        UnitsInStock = 2,
                        Chosen = false,
                        BoardSize = 7.5,
                        Image = "~/Assets/products/sinus-skateboard-ink.png",
                    },
                    new Boards
                    {
                        Id = 8,
                        Price = 1899,
                        Name = "Northern lights",
                        Category = Models.Enum.Category.Skateboard,
                        Color = Models.Enum.Color.Patterned,
                        Material = Models.Enum.Material.Wood,
                        Description = "Aurora, You-rora! Handcrafted in Hemavan.",
                        UnitsInStock = 3,
                        Chosen = false,
                        BoardSize = 8,
                        Image = "~/Assets/products/sinus-skateboard-northern_lights.png",
                    },
                    new Boards
                    {
                        Id = 9,
                        Price = 2899,
                        Name = "Gold Standard",
                        Category = Models.Enum.Category.Skateboard,
                        Color = Models.Enum.Color.Patterned,
                        Material = Models.Enum.Material.Wood,
                        Description = "Luxourious gold-laminated wood, for the extravagant skater",
                        UnitsInStock = 3,
                        Chosen = false,
                        BoardSize = 8,
                        Image = "~/Assets/products/sinus-skateboard-yellow.png",
                    },
                    new Boards
                    {
                        Id = 10,
                        Price = 899,
                        Name = "Blazing Saddle",
                        Category = Models.Enum.Category.Skateboard,
                        Color = Models.Enum.Color.Patterned,
                        Material = Models.Enum.Material.Wood,
                        Description = "For people of the land",
                        UnitsInStock = 7,
                        Chosen = false,
                        BoardSize = 8,
                        Image = "~/Assets/products/sinus-skateboard-fire.png",
                    },
                    new Wheels
                    {
                        Id = 11,
                        Price =550,
                        Name = "Spitfire Rims",
                        Color = Models.Enum.Color.Patterned,
                        Category = Models.Enum.Category.Wheel,
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = true,
                        Image = "~/Assets/products/sinus-wheel-rocket.png",
                        Durometer = "99A",
                        WheelSize = 52
                    },
                    new Wheels
                    {
                        Id = 12,
                        Price = 450,
                        Name = "Bones",
                        Color = Models.Enum.Color.Patterned,
                        Category = Models.Enum.Category.Wheel,
                        Description = "Rad rides crave these rims",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-spinner.png",
                        Durometer = "99A",
                        WheelSize = 52
                    },
                    new Wheels
                    {
                        Id = 13,
                        Price = 500,
                        Name = "Spitfire Rims",
                        Color = Models.Enum.Color.Patterned,
                        Category = Models.Enum.Category.Wheel,
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-wave.png",
                        Durometer = "99A",
                        WheelSize = 53
                    },
                    new Wheels
                    {
                        Id = 14,
                        Price = 500,
                        Name = "Spitfire Rad",
                        Color = Models.Enum.Color.Patterned,
                        Category = Models.Enum.Category.Wheel,
                        Description = "Custom made for total road contact",
                        UnitsInStock = 20,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-spinner.png",
                        Durometer = "99A",
                        WheelSize = 53
                    },
                    new Wheels
                    {
                        Id = 15,
                        Price = 459,
                        Name = "Santa Cruz",
                        Color = Models.Enum.Color.White,
                        Category = Models.Enum.Category.Wheel,
                        Description = "Slick, perfect for shredding",
                        UnitsInStock = 10,
                        Chosen = false,
                        Image = "~/Assets/products/sinus-wheel-wave.png",
                        Durometer = "100's",
                        WheelSize = 53
                    },
                    new Shoes
                    {
                        Id = 16,
                        Price = 700,
                        Name = "DC Tonic",
                        Color = Models.Enum.Color.Grey,
                        Category = Models.Enum.Category.Shoes,
                        Description = "Comfort and durability, provides excellent grip when needed",
                        UnitsInStock = 8,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304263560_front.jpg-4YT7onA_uQovNtQuNrZCa8dXK1Q/Tonik+Skateskor.jpg?$b8$",
                        ShoeSizeEu = 40
                    },
                    new Shoes
                    {
                        Id = 17,
                        Price = 700,
                        Name = "Nike Fri",
                        Color = Models.Enum.Color.White,
                        Category = Models.Enum.Category.Shoes,
                        Description = "Lightweight for agile moves, eggshell white",
                        UnitsInStock = 5,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304379064_front.jpg-QDAzF8yLhjdymEgEfDz7JsPQcFY/Nyjah+Free+2+NBA+Skateskor.jpg?$b8$",
                        ShoeSizeEu = 41
                    },
                    new Shoes
                    {
                        Id = 18,
                        Price = 999,
                        Name = "Vans Retro",
                        Color = Models.Enum.Color.Patterned,
                        Category = Models.Enum.Category.Shoes,
                        Description = "None beats the classic, this timeless classic still performs",
                        UnitsInStock = 5,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304461078_front.jpg-lrgaqTMdXv39J5S9DBwECdE2JO4/Skate+Old+Skool+Skateskor.jpg?$b8$",
                        ShoeSizeEu = 41
                    },
                    new Shoes
                    {
                        Id = 19,
                        Price = 799,
                        Name = "Adidas Buz",
                        Color = Models.Enum.Color.White,
                        Category = Models.Enum.Category.Shoes,
                        Description = "Designed by Buz, durable front for more stopping power",
                        UnitsInStock = 2,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304494977_front.jpg-eopv0HjOzWdRIedrB4_OfpWRXHY/Busenitz+Vulc+II+Skateskor.jpg?$b8$",
                        ShoeSizeEu = 39
                    },
                    new Shoes
                    {
                        Id = 20,
                        Price = 899,
                        Name = "Emerica Sneaks",
                        Color = Models.Enum.Color.Blue,
                        Category = Models.Enum.Category.Shoes,
                        Description = "Designed by Buz, durable front for more stopping power",
                        UnitsInStock = 6,
                        Chosen = false,
                        Image = "https://images.blue-tomato.com/is/image/bluetomato/304572494_front.jpg-a9YbnmLm2ybpONHT1_DBgIBo8yM/Dickson+Sneakers.jpg?$b8$",
                        ShoeSizeEu = 42
                    },
                };

            foreach (ProductModel product in AllProducts)
                Products.Add(product) ; 
        }

        public static ArrayList GetAll() => Products; 
        
        public static ProductModel Get(int id)
        {
            IEnumerator enumerator = Products.GetEnumerator();
            while (enumerator.MoveNext() )
            {
                ProductModel product = (ProductModel) enumerator.Current;
                if (product.Id == id) return product; 
            }
            return null;
        }
        public static void Add(JObject jsonProduct)
        {

            int id = nextId++;
            double price = (double)jsonProduct.GetValue("price");
            Category category = (Category)(int)jsonProduct.GetValue("category");
            Color color = (Color)(int)jsonProduct.GetValue("color");
            string description = (string)jsonProduct.GetValue("description");
            string name = (string)jsonProduct.GetValue("name");
            int unitsInStock = (int)jsonProduct.GetValue("unitsInStock");
            bool chosen = (bool)jsonProduct.GetValue("chosen");
            string image = (string)jsonProduct.GetValue("image");
            //Construct a productModel with the new values
            if ((int)category == 0 || (int)category == 1 || (int)category == 3)
            {
                Size size = (Size)(int)jsonProduct.GetValue("size");
                Products.Add(new Clothing
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    Size = size
                });

            }
            else if ((int)category == 2)
            {
                double boardSize = (double)jsonProduct.GetValue("boardSize");
                Material material = (Material)(int)jsonProduct.GetValue("material");

                Products.Add(new Boards
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    BoardSize = boardSize,
                    Material = material
                });
            }
            else if ((int)category == 4)
            {
                int wheelSize = (int)jsonProduct.GetValue("wheelSize"); ;
                string durometer = (string)jsonProduct.GetValue("durometer"); ;

                Products.Add(new Wheels
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    WheelSize = wheelSize,
                    Durometer = durometer
                });
            }
            else if ((int)category == 5)
            {
                int shoeSizeEu = (int)jsonProduct.GetValue("shoeSizeEu");
                Products.Add(new Shoes
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    ShoeSizeEu = shoeSizeEu
                });
            }
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

        public static void Update(JObject jsonProduct)
        {

            ProductModel editedProduct = null; 

            int id = (int)jsonProduct.GetValue("id");
            double price = (double)jsonProduct.GetValue("price");
            Category category = (Category)(int)jsonProduct.GetValue("category");
            Color color = (Color)(int)jsonProduct.GetValue("color");
            string description = (string)jsonProduct.GetValue("description");
            string name = (string)jsonProduct.GetValue("name");
            int unitsInStock = (int)jsonProduct.GetValue("unitsInStock");
            bool chosen = (bool)jsonProduct.GetValue("chosen");
            string image = (string)jsonProduct.GetValue("image");
            //Construct a productModel with the new values
            if ((int)category == 0 || (int)category == 1 || (int)category == 3)
            {
                Size size = (Size)(int)jsonProduct.GetValue("size");
                editedProduct = new Clothing
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    Size = size
                };

            }
            else if ((int)category == 2)
            {
                double boardSize = (double)jsonProduct.GetValue("boardSize");
                Material material = (Material)(int)jsonProduct.GetValue("material");

                editedProduct = new Boards
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    BoardSize = boardSize,
                    Material = material
                }; 
            }
            else if ((int)category == 4)
            {
                int wheelSize = (int)jsonProduct.GetValue("wheelSize"); ;
                string durometer = (string)jsonProduct.GetValue("durometer"); ;

                editedProduct = new Wheels
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    WheelSize = wheelSize,
                    Durometer = durometer
                };
            }
            else if ((int)category == 5)
            {
                int shoeSizeEu = (int)jsonProduct.GetValue("shoeSizeEu");
                editedProduct = new Shoes
                {
                    Id = id,
                    Price = price,
                    Name = name,
                    Category = category,
                    Color = color,
                    Description = description,
                    UnitsInStock = unitsInStock,
                    Chosen = chosen,
                    Image = image,
                    ShoeSizeEu = shoeSizeEu
                };
            }

            int index= - 1; 
            //Find the product with the same Id
            IEnumerator enumerator = Products.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ProductModel product = (ProductModel)enumerator.Current;
                if (product.Id == (int)jsonProduct.GetValue("id"))
                {
                  index = Products.IndexOf(product); 
                }
            }
            //Replace the old product with the new one
            if(index != -1) Products[index] = editedProduct; 
            
        }
        
    }
}
