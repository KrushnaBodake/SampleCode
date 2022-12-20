using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.StaticUse
{
    public class Book
    {
        private string bookname;
        private string author;
        private int price;
        private double discount;
        public Book(string bookname, string author, int price)
        {
            this.bookname = bookname;
            this.author = author;
            this.price = price;
        }
        public void DiscoutPrice()
        {
            discount = price -(price * 0.10);
            Console.WriteLine("Discount Price Is"+discount);
        }
        public override string ToString()
        {
            return $"Book name{bookname} author {author} price{price} ";
        }
        public static void Main(string[] args)
        {
            Book b = new Book("A nation to protect", "Priyam Gandhi", 100);
            Console.WriteLine(b);
            b.DiscoutPrice();

        }
    }
}
