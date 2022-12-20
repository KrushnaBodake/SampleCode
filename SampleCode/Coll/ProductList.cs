using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class ProductList
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Price { set; get; }

        /* public override string ToString()
         {
             return $"id {Id} name {Name} price {Price}";
         }*/


        public static void Main(string[] args)
        {
            List<ProductList> productlist = new List<ProductList>() {

                new ProductList { Id = 1, Name = "Keyboard", Price = 1500 },
                new ProductList { Id = 2, Name = "Mouse", Price = 1000 },
                new ProductList { Id = 3, Name = "Display", Price = 2500 },
                new ProductList { Id = 4, Name = "board", Price = 1600 }
            };
            Console.WriteLine($"{productlist[3].Id}  {productlist[3].Name}");


            foreach (ProductList item in productlist)
            {
                Console.WriteLine(item.Id + " " + item.Name + "" + item.Price);
            }

            Console.WriteLine("..........price less than 2000............");
            foreach (ProductList item in productlist)
            {
                if (item.Price < 2000)
                {
                    Console.WriteLine(item.Id + " " + item.Name + "" + item.Price);
                }


                productlist.Add(new ProductList { Id = 1, Name = "Keyboard", Price = 1500 });
                productlist.Add(new ProductList { Id = 2, Name = "Mouse", Price = 1000 });
                productlist.Add(new ProductList { Id = 3, Name = "Display", Price = 2500 });
                productlist.Add(new ProductList { Id = 4, Name = "board", Price = 1600 });


                /* Console.WriteLine("/////Product List////////");
                 foreach (ProductList item in productlist)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("..........price less than 2000............");
                 foreach(ProductList item in productlist)
                 {
                     if (item.Price < 2000)
                     { 
                         Console.WriteLine(item);
                     }

                 }*/
            }
        }

    }
}
