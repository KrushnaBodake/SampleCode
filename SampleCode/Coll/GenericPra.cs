using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class GenericPra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class GList
    {
        static void Main(string[] args)
        {
            //GenericPra g = new GenericPra();
            List<GenericPra> list = new List<GenericPra>();
            list.Add(new GenericPra { Id = 1, Name = "Krushna", Salary = 15000 });
            foreach (GenericPra item in list)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
    public class Cat
    {
        public String Category { get; set; }
        public List<Product> products = new List<Product>();
    }
    public class Product
    {
        public String ProductDetails { get; set; }
        public int ProdId { get; set; }
        public int Price { get; set; }
        public List<Color> color = new List<Color>();
    }
    public class Color
    {
        public String Colour { get; set; }
        public int Size { get; set; }
    }
    public class ProductD
    {
        static void Main(string[] args)
        {
            
            List<Cat> catlist = new List<Cat>();
            catlist.Add(new Cat
            {
                Category = "Furniture",
                products = { new Product { ProductDetails = "Chair", ProdId = 1, Price = 200,
                    color = { new Color { Colour = "White", Size = 14 },
                    new Color { Colour = "Red", Size = 14} } },
                    new Product{ ProductDetails = "Table", ProdId = 4, Price = 2000,
                    color={ new Color { Colour = "White", Size = 14} } 
                    }
                }
            });



            catlist.Add(new Cat
            {
                Category = "Home Needs",
                products = {new Product { ProductDetails="Freeze", ProdId=6, Price=7000 ,
                color={new Color { Colour="Pink", Size=26} }} ,
                new Product{ ProductDetails="Washing Mc", ProdId=20, Price=8000 ,
                color={ new Color{ Colour="white", Size=44} } } }
            });

            catlist.Add(new Cat
            {
                Category = "Electronics",
                products = {new Product { ProductDetails="Mobile", ProdId=2,Price=16000},
                new Product{ProductDetails="TV", ProdId=3, Price=15000}}
            });

            foreach (Cat item in catlist)
            {
                Console.WriteLine(item.Category);
                foreach (Product p in item.products)
                {
                    Console.WriteLine(p.ProductDetails +" "+ p.ProdId +" "+ p.Price);

                    foreach (Color c in p.color)
                    {
                        Console.WriteLine(c.Colour + " " + c.Size );
                    }
                }
               
                Console.WriteLine("                                                         ");
            }
           
        }
    }
    public class GStack
    {
        static void Main(string[] args)
        {
            Stack<GenericPra> st = new Stack<GenericPra>();
            st.Push(new GenericPra { Id = 201, Name = "Vikas", Salary = 20000 });
            st.Push(new GenericPra {Id=202, Name="Prakash", Salary=20000});
            //st.Pop();
           // st.Peek();
           Console.WriteLine(st.Count);

            foreach ( GenericPra item in st)
            {
                Console.WriteLine(item.Id +" "+ item.Name +" "+ item.Salary);
            }
        }
    }
    public class GDict
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> d = new Dictionary<int, string>();
            d.Add(1, "Krushna");
            d.Add(2, "Vikas");
            d.Add(3, "Prakash");
            Console.WriteLine(d[2] = "Monika");
            foreach (KeyValuePair<int,String> item in d)
            {
                
                Console.WriteLine(item.Key +" "+ item.Value);
                
            }
            if(d.ContainsKey(1))
            {
                Console.WriteLine("Key is found");
            }
            
        }
    }

}
