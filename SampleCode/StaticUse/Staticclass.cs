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
    public class Cha
    {
        public void Char1()
        {
            String s1 = "KrushnaKsrusKrK";
            char[] ch = s1.ToCharArray();
            Console.WriteLine(ch);

            for (int i = 0; i <= ch.Length; i++)
            {
                int count = 1;
                bool isvisit = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        isvisit = true;
                        break;
                    }
                }

                
                if (isvisit == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }

                    }
                    Console.WriteLine(ch[i] + "" + count);
                  /*  if (count >= 2)
                    {
                        Console.WriteLine(ch[i]);
                        Console.WriteLine(ch[i] + "" + count);
                    }*/
                }

            }

        }
        static void Main(string[] args)
        {
            Cha c = new Cha();
            c.Char1();
        }
    }
}
