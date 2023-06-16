using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.OOPs
{
    public class Class1
    {
       
        public virtual void Show()
        {
            //parent class logic is same for all child class
            Console.WriteLine("Parent class  show method ");
        }
    }
    public class Class2:Class1
    {
        
        public override void Show()
        {                    
            Class1 c = new Class1();   // Calling Parent Class Show Method
            c.Show();
            base.Show();  // Calling Parent Class Show Method
            //Child class  Reimplement the logic.
            Console.WriteLine("Child class  show method ");
        }
    }
    public class Class3: Class1
    {
        // Happy with Parent Class method
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.Show();       // Complier find Class1 method but at time runtime Class2 method Executes

            Class3 obj3 = new Class3();
            obj3.Show();   // Class3 Method not availble then Executes Class1 Show Method

            Class1 obj4 = new Class3();
            obj4.Show();     // complier find Class1 Method then at runtime there is no method then excutes the class1
        }
    }
    











    public class Emp
    {
        public int x;
        public int y;
        public int Id { get; set; }
        public double Salary { get; set; }

        public virtual double CalBonus(double Salary)
        {
            return 50000;
        }
    }
    public class Developer : Emp
    {
      
      
        // 50000 or 20% Bonus to Developer Which is greater
        public override double CalBonus(double Salary)
        {
            int rusult = x + y;

            double baseBonus = base.CalBonus(Salary);
            double bonusBasedOnSalary = Salary * 0.20;
            if(baseBonus >= bonusBasedOnSalary)
            {
                return baseBonus;
            }
            else
            {
                return bonusBasedOnSalary;
            }          
        }
    }
    public class Mainclass
    {
        static void Main(string[] args)
        {
            Emp emp = new Developer();
            emp.x = 10;
            emp.y = 20;
            emp.Salary = 500000;
            emp.Id = 101;
            double bonus=emp.CalBonus(emp.Salary);
            Console.WriteLine($" empId {emp.Id}  empSalary {emp.Salary} bonus {bonus} ");
        }
    }
}
