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
     /*   static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Call the Method a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($" After call the Method a={a}, b={b}");
        }*/

    }
   

}
