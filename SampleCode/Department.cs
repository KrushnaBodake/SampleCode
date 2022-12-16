using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public enum Department { Hr=100,Admin=101,Sales=102,Developement,Testing}

    public class Employe
    {
        protected int empId;
        protected string empName;
        private Department dept;

        public Employe(int empId, string empName,Department dept)
        {
            this.empId = empId;
            this.empName = empName;
            this.dept = dept;
        }
        public override string ToString()
        {
            return $"employee Id {empId}, employee Name {empName}, Department {dept}";

        }
      /*  static void Main(string[]args)
        {
            Employe e = new Employe(1, "Vishal", Department.Hr);
            Console.WriteLine(e);
        }*/
    }
   
    
}



