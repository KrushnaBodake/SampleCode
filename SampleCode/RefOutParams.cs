using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class RefOutParams
    {
        static void Swap(ref int a, ref int b)
        {
           
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Call the Method a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($" After call the Method a={a}, b={b}");
        }

    }
    public class RefOutParams2
    {
        public void Update(out int a, ref int b)
        {
            a = 10;
            b = 20;
        }
        static void Main(string[] args)
        {
            int a=100;  // no need to intialize out parameter
            int b=5;
            RefOutParams2 ro = new RefOutParams2();
            ro.Update(out a,ref b);
            Console.WriteLine($"Before Call the Method a={a}, b={b}");
            
        }

    }
    public class RefOutEg
    {
        public void UpdateValue(int a, int b)
        {
            a = 10;
            b = 20;       
           
        }
        static void Main(string[] args)
        {
            int a = 30, b = 40;
            RefOutEg ro = new RefOutEg();
            ro.UpdateValue(a,b);
            Console.WriteLine($" {a}  {b}");


        }
    }

}
