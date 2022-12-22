using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class Categories
    {
        public string Category { set; get; }
        public List<ProductDislay> Product = new List<ProductDislay>();
    }
    public class ProductDislay
    {
        public string ProductDetails { set; get; }
        public int ProductNo { set; get; }
        public int price { set; get; }
    }

    public class DisplayProduct
    {
        static void Main(string[] args)
        {
            List<Categories> categories = new List<Categories>()
            {
                new Categories
                {
                    Category="Furniture",
                    Product=
                    {
                        new ProductDislay{ProductDetails="Chair",ProductNo=57614, price=1500 },
                        new ProductDislay{ProductDetails="Study Table",ProductNo=57667, price=1800},
                    }
                },
                new Categories
                {
                    Category="Mobiles",
                    Product=
                    {
                        new ProductDislay{ProductDetails="Samsung",ProductNo=354, price=25000 },
                        new ProductDislay{ProductDetails="OnePlus",ProductNo=355, price=35000},
                    }
                   
                }
            };

            foreach(Categories c in categories)
            {
                Console.WriteLine($"Category Type: {c.Category} ");

                foreach(ProductDislay s in c.Product)
                {
                    Console.WriteLine($"Product Detail: {s.ProductDetails} Prod No {s.ProductNo} Price {s.price}");
             
                }
                Console.WriteLine("                                                                   ");
            }
        }
    }
}
