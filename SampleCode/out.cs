using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Out
    {
        static void Cal(int a, int b, out int sum, out int sub, out int multiply)
        {
           // a = 40;
           // b = 30;
            sum = a + b;  // out parameter must be initialize 
            sub = a - b;
            multiply = a * b;
        }
        

        static void Main(string[] args)
        {
            int a = 23, b = 25, sum, sub, mul;    // no need to initialize out parametr before passing
            Cal(a, b, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
        }

        static void AcceptNames(params string[] names )
        {
            Console.WriteLine("No of name" + names.Length);
           for(int i=0; i<names.Length; i++)
           {
                Console.WriteLine(names[i]);
           }
        }
        /*static void Main(string[] args)
        {
            AcceptNames("Vikas", "Prakash");
            AcceptNames("Ganesh", "Tushar", "Sankalp");
            AcceptNames("Krishna");
        }*/

    }
}
