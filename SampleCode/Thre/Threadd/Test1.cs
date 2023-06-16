using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCode.Exceptiom.Threadd
{
    public class Test1
    {
        public void M1()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
           
        }
        public void M2()
        {
            for (int j = 11; j <= 15; j++)
            {
                Console.WriteLine(j);
                Thread.Sleep(2000);
            }
        }
    }
    public class Ther
    { 
        static void Main(string[] args)
        {
            Test1 t = new Test1();
            Thread t1 = new Thread(new ThreadStart(t.M1));
            Thread t2 = new Thread(new ThreadStart(t.M2));
            Thread t3 = new Thread(new ThreadStart(t.M1));

            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            Console.ReadLine();
        }

        

    }
   
}
