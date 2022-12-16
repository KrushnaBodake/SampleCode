using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Dog : Animal
    {
        private int r;
        private double area;
        private int l;
        private int b;
        private double rectanglearea;
        public override void Sound()
        {
            string bark;
        }       
        public Dog(int r)
        {
            this.r = r;
            //this.l = l;
            //this.b = b;
        }
        public override void CalculateCircleArea()
        {
            Sound();
            area = 3.14 * r * r;
        }
       
            
        public override void CalculateRectangleArea(int l, int b)
        {
            rectanglearea = l * b;
        }
        public override string ToString()
        {
            return $"area of circle is {area} / area of Rectangle {rectanglearea}";
        }


        //static void Main(string[] args)
        //{
        //    Dog d = new Dog(10);
        //    d.CalculateCircleArea();
        //    d.CalculateRectangleArea(20,25);
        //    d.Sound();
        //    Console.WriteLine(d);


        //}
    }




}

