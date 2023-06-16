using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Employeee
    {
        protected private int eid;
        protected private string name;
        protected private double basic;
        protected private double hra , da, gross;

        public Employeee()
        {

        }
        public Employeee( string name, double basic)
        {
            this.name = name;
            this.basic = basic;
        }
        public virtual void CalSalary()
        {
            hra = 0.12 * basic;
            da = 0.1 * basic;
            gross = hra + da;
        }
        public override string ToString()
        {
            return $"gross salary{gross}";
        }


    }
    public class Manager1:Employeee
    {
        private int foodall;
        public Manager1() : base()
        {

        }


        public Manager1(string name,double basic, int foodall):base(name,basic)
        {
            this.foodall = foodall;
        }
      
        public override void CalSalary()
        {
            hra = 0.12 * basic;
            da = 0.1 * basic;
            gross = hra + da+foodall;
        }
        public override string ToString()
        {
            return $"gross salary{gross}";
        }
        static void Main(string[] args)
        {
            Employeee emp = new Manager1("Ganesh", 20000,3000);
            
            emp.CalSalary();
        }

    }
    
}
