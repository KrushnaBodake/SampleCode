using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class Authorr
    {
        public string AuthorName { get; set; }
        public string AuthorAddress { get; set; }

    }
    public class Category
    {
        public string Categories { get; set; }
        public List<Book> Book1 = new List<Book>();
    }
    public class Book
    {
        public int BookId { get; set; }
        public string BokkName{ get; set; }
        public int Price { get; set; }
        public List<Authorr> Author = new List<Authorr>();
    }

    public class Printt
    {
        static void Main(string[] args)
        {
            List<Category> cat = new List<Category>();
            {
                cat.Add(new Category
                {
                    Categories = "StoryBook",
                    Book1 =
                    { new Book { BookId = 234, BokkName = "Kantara" ,Price=480,

                           Author ={ new Authorr { AuthorName = "mr Javed", AuthorAddress = "Pune" } ,
                                     new Authorr { AuthorName = "mr. Vijay", AuthorAddress = "Nashik" }

                                       }     
                              },
                        new Book 
                        { BookId = 235, BokkName = "Natsmarat",Price=4656,
                                 Author ={ new Authorr { AuthorName = "mr hari", AuthorAddress = "Aurangabad" } ,
                                           new Authorr { AuthorName = "mr. Ajay", AuthorAddress = "Latur" }


                        }        }
                    }
                }


                );

            }
            foreach(Category c in cat)
            {
                Console.WriteLine($" {c.Categories}");
                foreach (Book b in c.Book1)
                {
                    Console.WriteLine($"{b.BookId} {b.BokkName} {b.Price}");
                    foreach ( Authorr a in  b.Author)
                    {
                        Console.WriteLine($"{a.AuthorName} {a.AuthorAddress}");
                    }
                }
            }
        }
    }
}
