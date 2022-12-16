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
        public Manager(string empName, double basic, int max, double food) : base(empName, basic, max)
        {
            this.food = food;
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
        public SalesManager(string empName, double basic, int max, double commision) : base(empName, basic, max)
        {
            this.commision = commision;
        }


        public override void CalSalary()
        {
            hra = basic * 0.4;
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





}

