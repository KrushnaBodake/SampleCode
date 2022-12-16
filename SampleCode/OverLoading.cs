using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class OverLoading
    {
        public int Add(int a, int b)
        {
           return a + b;
        }
        public double Add(int a, int b, double d)
        {
            return a+b+d;
        }
        public double Add(double d, int a)
        {
            return a+d;
        }

    }
}
