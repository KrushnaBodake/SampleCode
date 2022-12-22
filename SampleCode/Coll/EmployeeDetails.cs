using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    public class Departments
    {
        public string Dept { set; get; }
        public int DeptNo { set; get; }
       public List<Employees> Emplist = new List<Employees>();
    }
    public class Employees
    {
        public int Id { set; get; }
        public string Ename { set; get; }
        public string Post { set; get; }
    }

    public class Print
    {
        static void Main(string[]args)
        {
            List<Departments> dept = new List<Departments>()
            {  
                new Departments
                { 
                    Dept="Hr",
                    DeptNo=1,
                    Emplist= 
                    {
                        new Employees { Id=01, Ename="E1", Post="Trainee"} ,
                        new Employees { Id=02, Ename="E2", Post="ManagementTrainee"},
                    }
                },
                new Departments
                {
                    Dept="QA",
                    DeptNo=2,
                    Emplist=
                    {
                        new Employees { Id=01, Ename="E1", Post="Jr.QA"} ,
                        new Employees { Id=02, Ename="E2", Post="Sr.QA"},
                    }
                },
            };
            foreach(Departments d in dept)
            {
                Console.WriteLine($" Department Name: {d.Dept}  Department Id {d.DeptNo}");

                foreach(Employees e in d.Emplist)
                {
                    Console.WriteLine($" Employee ID: {e.Id} Empolyee Name: {e.Ename} Employee Designation: {e.Post}");
                }

                Console.WriteLine("                                                         ");
            }
        }
    }
}

