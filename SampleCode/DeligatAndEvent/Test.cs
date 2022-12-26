using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Deligat
{
    //Deligate
    public delegate int Mydele1(int n1, int n2);
    public delegate string Mydel2(string s);    
    public class Test
    {
        public int M1 (int a, int b)
        {
            return a + b;
        }
        public int M3 (int a, int b)
        {
            return a * b;
        }
        public int M4(int a, int b)
        {
            return a - b;
        }

        public string M2( string name)
        {
            return name;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Mydele1 d1 = new Mydele1(t.M1);
            d1 += new Mydele1(t.M3);
            d1 += new Mydele1(t.M4);         // one delegate hold multiple methods references 


            Delegate[] list = d1.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(67,34));
            }

            Mydel2 d2 = new Mydel2(t.M2);

           /* int sum = d1.Invoke(23, 45);
            Console.WriteLine(sum);*/
        }
        

    }
}
