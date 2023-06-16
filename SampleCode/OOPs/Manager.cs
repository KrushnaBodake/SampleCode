using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Manager : Employee
    {
        private double food;
        public Manager(string empName, double basic,  double food) : base(empName, basic)
        {
            this.food = food;
        }
        public void Method2()
        {
            Console.WriteLine("Chid Method");
        }
        public override void CalSalary()
        {
            hra = basic * 0.4;
            da = basic * 0.2;
            pf = basic * 0.12;

            gross = (basic + hra + da + food) - pf;
        }
        public override string ToString()
        {
            return $"Employee name: {empName}, emp basic: {basic} & gross salary of manager: {gross}";
        }
        //static void Main(string[] args)
        //{
        //    Manager m = new Manager("ganesh", 12550, 15000, 2000);
        //    Manager m1 = new Manager("Tushar", 12555, 15005, 2000);
        //    m.CalSalary();
        //    m1.CalSalary();
        //    Console.WriteLine(m);
        //    Console.WriteLine(m1);
        //}


    }
    public class SalesManager : Employee
    {
        private double commision;
        public SalesManager(string empName, double basic, double commision) : base(empName, basic)
        {
            this.commision = commision;
        }


        public override void CalSalary()
        {
            hra = basic * 0.5;
            da = basic * 0.2;
            pf = basic * 0.12;

            gross = (basic + hra + da + commision) - pf;
        }
        public override string ToString()
        {
            return $"Employee name: {empName}, emp basic: {basic} & gross salary of manager: {gross} commision: {commision}";
        }
        //static void Main(string[] args)
        //{
        //    SalesManager sm = new SalesManager("Krishna", 12550, 15000, 200);
        //    SalesManager sm1 = new SalesManager("Sankalp", 12555, 15005, 200);
        //    sm.CalSalary();
        //    sm1.CalSalary();
        //    Console.WriteLine(sm);
        //    Console.WriteLine(sm1);
        //}


    }
    public class Str
    {
        static void Main(string[] args)
        {
            string[] str = { "Krushna", "Ganesh", "Tushar" };
            string str1 = "";
            Char[] ch = { 'a', 'b' };
            string str2 = new string(ch);
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str1 +" " + str[i] ;
               
            }
            Console.WriteLine(str1);
            Console.WriteLine(str2);
           
            string str3 = "";
            for (int i = 0; i < str1.Length; i++)
            {
                str3= str1[i] + str3;
                
            }
            Console.WriteLine(str3);
            Console.ReadLine();
        }
             
    }
}

