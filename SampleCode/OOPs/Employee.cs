using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
    // namespace is logical group of types
    // Types-- class, struct,interface, delegate, enum
    // default access is internal
{
    public class Employee
    {
        int a = 10;
        // Members- field/ariable/Data menber
        // method- constructor,property,indexer,event
        // default access is private

        protected private int empId;
        protected private string empName;
        protected private double basic, hra, da, pf, gross;
        protected private static int count;
        protected private const int Max = 15500;
        protected private readonly int max;

        public Employee(string empName, double basic)
        {
            count++;
            empId = count;
            
            this.empName = empName;   // this refer to the data member
            this.basic = basic;
        }
        public void Method1()
        {
            Console.WriteLine("Parent method");
        }
        public virtual void CalSalary()
        {
            hra = basic * 0.4;
            da = basic * 0.2;
            pf = basic * 0.12;
            
            gross = (basic + hra + da) - pf ;
        }
        public override string ToString()
        {
            return $"employee Id {empId}, employee Name {empName}, gross salary{gross}";
        }
       /* public string Print()
        {
            return $"employee Id {empId}";
        }*/
        /*public double GetgrossSalary()
        {
            return gross;
        }*/
    }
    public class Student
    {
        private int sub1, sub2, sub3;
        private int total;
        private double per;
    
         public Student(int sub1, int sub2, int sub3)
         {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            //this.total = total;
            //this.per=per;
         }
        public void CalTotal()
        {
            total = sub1 + sub2 + sub3;
            per = (total * 100) / 300.0;
        }
        public double Percentage()
        {
            return per;
        }
        public override string ToString()
        {
            return $"Total: {total} and Percentage: {per}";
        }


    }
    public class Book
    {
        private int bookId;
        private string bookName;
        private string authorName;
        private int bookPrice;

        public int BookId
        {
            set
            {
                bookId = value;
            }
            get
            {
                return bookId;
            }
        }
        public string BookName
        {
            set
            {
                bookName = value;
            }
            get
            {
                return bookName;
            }
        }
        public string AuthorName
        {
            set
            {
                authorName = value;
            }
            get
            {
                return authorName;
            }
        }
        public int BookPrice
        {
            set
            {
                bookPrice = value;
            }
            get
            {
                return bookPrice;
            }
        }
        public override string ToString()
        {
            return $"Book Id No: {bookId} Book Name: {bookName} Author Name: {authorName} Book Price: {bookPrice} ";
        }

    }

   
}
