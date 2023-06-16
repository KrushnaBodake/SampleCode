using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.DeligatAndEvent
{
    public delegate int MyD(int a, int b);
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a , int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    public class Helper
    {
        public event MyD Addition;
        public event MyD Substraction;
        public event MyD Multification;

        public int M1(int a , int b )
        {
            return Addition(a,b);
        }
        public int M2(int a, int b)
        {
            return Substraction(a, b);
        }
        public int M3(int a, int b)
        {
            return Multification(a, b);
        }
    }
    public class M
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Helper h = new Helper();
            h.Addition += new MyD(c.Add);
            h.Substraction += new MyD(c.Sub);
            h.Multification += new MyD(c.Mul);

            int sum=h.M1(10, 20);
            Console.WriteLine(sum);


            Console.WriteLine("enter Value");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multifaction");
            Console.WriteLine(" Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int sm = h.M1(a, b);
                    Console.WriteLine(sum);
                    break;

                case 2:
                    int sub = h.M2(a, b);
                    Console.WriteLine(sub);
                    break;

                case 3:
                    int m = h.M3(a, b);
                    Console.WriteLine(m);
                    break;

                default:
                    Console.WriteLine("No Output");
                    break;


            }
        }
    }
   
}
