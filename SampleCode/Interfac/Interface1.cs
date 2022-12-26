using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Check : IComparer
    {
        public int Compare(object x, object y)
        {
            CompanyEmployee employee = (CompanyEmployee)x;
            CompanyEmployee employee2 = (CompanyEmployee)y;

            if (employee.Salary > employee2.Salary)
            {
                return 1;
            }
            else if (employee.Salary > employee2.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
    public class CompanyEmployee:IComparable
    {
        private string name;
        private int salary;

        public int Salary 
        { 
            get { return salary; } 
        }

        public CompanyEmployee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(object obj)
        {
            CompanyEmployee employee2 = (CompanyEmployee)obj; // type cast
            if( this.salary > employee2.salary)   // this means current object that employee.
            {
                return 1;
            }
            else if (this.salary<employee2.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name}   -->  {salary}" ;
        }
    }

    public class Employeeteam: IEnumerable
    {
        CompanyEmployee [] employee;

        public Employeeteam()
        {
            employee = new CompanyEmployee[3];
            employee [0]= new CompanyEmployee("Ganesh", 18000);
            employee[1] = new CompanyEmployee("Tushar", 25000);
            employee[2] = new CompanyEmployee("Sankalp",15300);          

        }

        public IEnumerator GetEnumerator()
        {
            return employee.GetEnumerator();
        }
    }
    public class Printt
    {
        /*static void Main(string[]args)
        {
            Employeeteam b = new Employeeteam();
            foreach(var item in b)
            {
                Console.WriteLine(item);
            }

            CompanyEmployee employee = new CompanyEmployee("Ganessh", 25000);
            CompanyEmployee employee1 = new CompanyEmployee("Tushar", 25000);
            CompanyEmployee employee2 = new CompanyEmployee("sankalp", 15500);

            // int result=employee.CompareTo(employee2);
            //Console.WriteLine(result);

            Check c = new Check();
            int result=c.Compare(employee,employee2);

            if(result==1)
            {
                Console.WriteLine("Ganesh Salary is more than Sankalp");
            }
            else if (result==-1)
            {
                Console.WriteLine("Sankalp Salary is less than Sankalp");
            }
            else 
            {
                Console.WriteLine("Sankalp and Ganesh has same Salary");
            }
        } */
    }

}
