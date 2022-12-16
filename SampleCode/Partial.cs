using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public partial class Calculator
   {
        public double Div(int a,int b)
        {
            return(a/b);
        }

        partial void Square(int a)
        {
            Console.WriteLine(a * a);
        }

        public void HelperMethod(int a)
        {
            Square(a);
        }

   }

}
