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
        private Department admin;

        public Employe(int empId, string empName,Department dept,Department admin)
        {
            this.empId = empId;
            this.empName = empName;
            this.dept = dept;
            this.admin = admin;
        }
        public override string ToString()
        {
            return $"employee Id {empId}, employee Name {empName}, Department {dept}, Department {admin}";

        }
        static void Main(string[]args)
        {
            Employe e = new Employe(1, "Vishal", Department.Hr, Department.Admin);
            Console.WriteLine(e);
        }
    }
   
    
}



