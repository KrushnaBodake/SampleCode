using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public  class NonGenericPra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    public class Coll
    {
        static void Main(string[] args)
        {
            NonGenericPra c = new NonGenericPra();
            c.Id = 101;
            c.Name = "Krushna";
            c.Salary = 15000;
            ArrayList list = new ArrayList();
            list.Add(c);
            list.Add(new NonGenericPra { Id = 102, Name = "Sankalp", Salary = 15500 });

            foreach (NonGenericPra item in list)
            {
                Console.WriteLine($"{item.Id} ");
            }
            foreach (var item in list)
            {
                if (typeof(NonGenericPra) == item.GetType())
                {
                    NonGenericPra ss = (NonGenericPra)item;
                    Console.WriteLine(ss.Id + " " + ss.Name + " " + ss.Salary);
                }
            }
        }
    }
    public class C
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 20, 30 };
            ArrayList list = new ArrayList();
            list.Add(40);
            list.Add("krushna");
            list.Insert(0, 6);
            list.AddRange(arr);
           // Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(40));
            Console.WriteLine(list.IndexOf(20));
            Console.WriteLine(list.LastIndexOf(20));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Sta
    {
        static void Main(string[] args)
        {
            NonGenericPra ng = new NonGenericPra();
            Stack s = new Stack();
            s.Push(new NonGenericPra { Id = 103, Name = "Tushar", Salary = 25000 });
            s.Push(new NonGenericPra { Id = 103, Name = "Tushar", Salary = 25000 });
            s.Pop();
                       
            foreach (var item in s)
            {
                if (typeof(NonGenericPra) == item.GetType())
                {
                    NonGenericPra ss = (NonGenericPra)item;
                    Console.WriteLine(ss.Id + " " + ss.Name + " " + ss.Salary);
                }
                
            }
        }
    }
    public class Que
    {
        static void Main(string[] args)
        {
            NonGenericPra nn = new NonGenericPra();
            Queue q = new Queue();
            q.Enqueue(new NonGenericPra { Id = 104, Name = "Ganesh", Salary = 18000 });
            q.Dequeue();
            foreach (var item in q)
            {
                if(typeof(NonGenericPra)==item.GetType())
                {
                    NonGenericPra n = (NonGenericPra)item;
                    Console.WriteLine($"{n.Id} {n.Name}");
                }
            }                  
        }
    }
    public class Hash
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1, "krushna");
            hs.Add("Tushar", 2);
            //hs.Remove("Tushar");

            foreach (DictionaryEntry item in hs)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
