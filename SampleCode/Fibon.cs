using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public class Fibon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            for(int i=0; i<=n;i++)
            {
                Console.WriteLine(a);

                int c = a + b;    //  0+1 , 1+1 , 1+2, 2+3
                a = b;           //   a=1,  a=1 , a=2, a=3
                b = c;           //   b=1 , b=2 , a=3, a=5
                
            }
        }
    }
}
