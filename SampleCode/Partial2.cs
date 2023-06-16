using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public partial class Calculator
    {
        partial void Square(int a);
        public void HelperMethod(int a)
        {
            Square(a);
        }

        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Div(10, 2);
            cal.HelperMethod(2);
        }
    }


    
}
