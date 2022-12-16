using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class ImplementingClass: CircleArea
    {
        int radius;
        private double area;
        public ImplementingClass(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateCircleArea()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"area of circle is {area}";
        }
       /* static void Main(string[] args)
        {
            ImplementingClass i = new ImplementingClass(12);
            
            i.CalculateCircleArea();
           
            
            Console.WriteLine(i);


        }*/
    }
}
