using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Generic
    {
        static void Main (string[]args)
        {
            Service s1 = new Service() { Id = 102, Name = "Rework", Price = 150 };
            List<Service> list = new List<Service>();
            list.Add(new Service { Id = 101, Name = "Repair", Price = 200 });
            list.Add(s1);
      
            foreach(Service item in list)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Price);
            }

            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Insert(0, 20);

            foreach(var item in ls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("...............................");
            int[] arr = new int[] { 30, 15, 40 };
            ls.AddRange(arr);

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

           // ls.Remove(10);
            //ls.RemoveAt(0);
            ls.RemoveRange(2, 2);
            Console.WriteLine(".......................................");
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            // ls.Clear();

            ls.Sort();
            Console.WriteLine(".......................................");
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(".......................................");
            ls.Reverse();
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("..............Stack<>.................");

            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(18);
            st.Push(20);

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }

            st.Pop();
            Console.WriteLine(".................Pop( )......................");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            st.Peek();
            Console.WriteLine("..............Peek( ).................");
            Console.WriteLine(st.Peek());

            Console.WriteLine(".....................Queue< >.......................");
            Queue<string> qq = new Queue<string>();
            qq.Enqueue("Pune");
            qq.Enqueue("Latur");
            qq.Enqueue("Aurangabad");

            foreach (var item in qq)
            {
                Console.WriteLine(item);
            }

            qq.Dequeue();
            Console.WriteLine("....................Dequeue..........................");
            foreach (var item in qq)
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine("Get Beginning value " + qq.Peek());

            Console.WriteLine("..........................Dictionary.........................");

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Prakash");
            d.Add(2, "Vikas");
            d.Add(3, "Krushna");

            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine(item.Key+" " +item.Value);
            }

            Console.WriteLine("..........................SortList<>.........................");
            SortedList<int, double> sd = new SortedList<int, double>();
            sd.Add(1, 65);
            sd.Add(2, 78);
            sd.Add(3, 74);

            foreach(KeyValuePair<int,double> item in sd)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


        }
    }
}
