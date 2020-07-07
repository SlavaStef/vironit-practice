using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task5.Models;

namespace Task5.Data
{
    public class Products
    {
        public static List<Product> ProductList = new List<Product>
        {
            new Product { Id = 1, Name = "ASUS ROG Zephyrus G Ultra Slim Gaming Laptop", Description = "15.6” IPS Type FHD, GeForceGTX 1660 Ti, AMD Ryzen 7 3750H, 8GB DDR4, 512GB PCIeNVMe SSD, Windows 10,GA502GU-PB73", Price = 1199
            },
            new Product { Id = 2, Name = "Acer Nitro 5 15\" Gaming Laptop", Description = "AMD Ryzen 5 2500U Processor, AMD Radeon RX 560X Graphics, 8GB RAM, 1TB Hard Drive, AN515-42-R5ED", Price = 789
            },
            new Product { Id = 3, Name = "Dell G5 Gaming Laptop", Description = "15.6\" Full HD, Intel Core i7-8750H, NVIDIA GeForce GTX 1050 Ti 4GB, 1TB HDD + 128GB SSD Storage, 8GB RAM, G5587-7037RED-PUS", Price = 930
            },
            new Product { Id = 4, Name = "Legion By Lenovo Y540", Description = "15.6\" Gaming Laptop, Intel Core i7-9750H, Nvidia GeForce GTX 1650 4GB Graphics, 8GB Memory, 512GB PCIe SSD Storage, 81SY0091US", Price = 1099
            },
            new Product { Id = 5, Name = "MSI GL63 Gaming Laptop", Description = "15.6\" Intel Core i7-8750H, NVIDIA GeForce GTX 1050, 8gb RAM, 256gb SSD + 1TB HDD", Price = 1051
            }
        };

    }
}