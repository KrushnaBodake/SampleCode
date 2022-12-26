using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ExtendMethod
    {
        public void M1()
        {
            Console.WriteLine("m1 Method");
        }
        public void M2()
        {
            Console.WriteLine("m2 Method");
        }
    }
    public static class ExtendedClass
    {
        public static void ExtentedMethod1(this ExtendMethod t1)
        {
            Console.WriteLine("Extended Method 1");
        }
        public static void ExtentedMethod2(this ExtendMethod t, string name)
        {
            Console.WriteLine("Extended Method 2" + name);
        }
        static void Main(string[] args)
        {
            ExtendMethod m = new ExtendMethod();
            m.ExtentedMethod1();
            m.ExtentedMethod2("vikas");
        }
    }
    
    
}
