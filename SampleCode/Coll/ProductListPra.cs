using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class ProductListPra
    {
        int id;
        String name;
        int price;
        public ProductListPra()
        {

        }
       /* public ProductList(int id, string name,int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }*/
        public int Id { set; get; }
        public string Name { set; get; }
        public int Price { set; get; }
        /*public void M1(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }*/

        public override string ToString()
        {
            return $"id {Id} name {Name} price {Price}";
        }


        public static void Main(string[] args)
        {


            /*  List<int> list1 = new List<int>();
              list1.Add(10);
              List<ProductList> productlist = new List<ProductList>();
              productlist.Add(new ProductList(101, "arun", 2000));
              productlist.Add(new ProductList { Id = 102, Name = "Vikas", Price = 1000 });*/




            List<ProductListPra> productlist = new List<ProductListPra>() {

                new ProductListPra { Id = 1, Name = "Keyboard", Price = 1500 },
                new ProductListPra { Id = 2, Name = "Mouse", Price = 1000 },
                new ProductListPra { Id = 3, Name = "Display", Price = 2500 },
                new ProductListPra { Id = 4, Name = "board", Price = 1600 }
            };
            Console.WriteLine($"{productlist[3].Id}  {productlist[3].Name}");


            foreach (ProductListPra item in productlist)
            {
                Console.WriteLine(item.Id + " " + item.Name + "" + item.Price);
            }

            Console.WriteLine("..........price less than 2000............");
            foreach (ProductListPra item in productlist)
            {
                if (item.Price < 2000)
                {
                    Console.WriteLine(item.Id + " " + item.Name + "" + item.Price);
                }


/*                productlist.Add(new ProductList { Id = 1, Name = "Keyboard", Price = 1500 });
                productlist.Add(new ProductList { Id = 2, Name = "Mouse", Price = 1000 });
                productlist.Add(new ProductList { Id = 3, Name = "Display", Price = 2500 });
                productlist.Add(new ProductList { Id = 4, Name = "board", Price = 1600 });


                 Console.WriteLine("/////Product List////////");
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
