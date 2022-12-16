using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class StackHashtable
    {
        static void Main(string[]args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(15);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine("Satck values use Push method"+ item);
            }

            Console.WriteLine("................");

            // stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Peek();
            Console.WriteLine("top element on stack " + stack.Peek());

            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(25);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();

            Console.WriteLine("////////////////////////////////");


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "India");
            hashtable.Add(2, "RSA");
            hashtable.Add("Test", 200);

            hashtable.Remove("Test");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("/////////////////////////////////////////////////");

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "India");
            sortedList.Add(2, "RSA");
            //hashtable.Add("Test", 200);


            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }




        }
    }
}
