using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
   public enum Category { StoryBook, Adventures, Historical}

    public class Category1
    {
        public string Categories { get; set; }
        public List<Book> Book1 = new List<Book>();
    }
    public class Book
    {
        public int BookId { get; set; }
        public string BokkName{ get; set; }
        public int Price { get; set; }
        public string AuthorName { get; set; }
        public Category Cat;
        
    }

    public class Printt
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();
            {
                Books.Add(new Book
                {
                    Cat = Category.StoryBook,
                    BookId = 234,
                    AuthorName = "Mr.Vijay",
                    BokkName = "Kantara",
                    Price = 567,
                });
                Books.Add(new Book
                {
                    Cat = Category.Historical,
                    BookId = 236,
                    AuthorName = "Mr.Vijay Shrama",
                    BokkName = "Kantara2",
                    Price = 699,
                });

            }
            
          
            foreach(Book b in Books)
            {
                Console.WriteLine($" {b.BookId} {b.AuthorName} {b.BokkName} {b.Price}");
                
            }
        }
    }

}
