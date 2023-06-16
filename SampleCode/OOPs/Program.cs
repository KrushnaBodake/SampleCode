using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Manager("Rahul", 15000, 1200);
            Employee emp2 = new Manager("Ganesh", 10000.0, 56);
            Employee emp3 = new Manager("Krushna", 10000.0, 789);
            emp.CalSalary();
            emp2.CalSalary();
            emp3.CalSalary();
            emp.Method1();

            // IMP 
            Employee e;
            Manager man = new Manager("Tushar", 10000.0, 789);
            e = man;
            man.Method1();
            man.Method2();
            man.CalSalary();

            e.CalSalary();       // this child
            e.Method1();        // this is child

            Object obj = new object();

            



            // string data = emp.Print();
            // Console.WriteLine(data);
            //Console.WriteLine(emp);
            //Console.WriteLine(emp2);
            //Console.WriteLine(emp3);
            //Console.WriteLine(emp.Print());

            /* Student s = new Student(65, 64, 66);
             s.CalTotal();
             s.Percentage();
             Console.WriteLine(s);

             Book b = new Book();
             b.BookId = 001;
             b.BookName = "Harry Potter";
             b.AuthorName = "J.K.Rowling";
             b.BookPrice = 2185;
             Console.WriteLine(b); */


            /*Properties p = new Properties();
            //Object Initiallizer
            Properties p1 = new Properties { AuthourName = "j,k", BookId = 01, BookName = " HarryPotter", BookPrice = 2000 };

            Console.WriteLine(p1);

            Practic pr = new Practic(1267, "Black");
            Practic pr1 = new Practic(1268, "Red", "kia");
            pr.PassingYear(2012);               // optional parameter
            pr.PassingYear(passingyear: 2012);  // Name Arguments   

            // Practic pr2 = new Practic { CarName = "maruti", FuelType = "hybrid" };

            Console.WriteLine(pr);
            Console.WriteLine(pr1);
            Console.WriteLine(pr.PassingYear(2012));
            Console.WriteLine(pr.PassingYear(passingyear: 2012));*/


        }
    }
}

    

