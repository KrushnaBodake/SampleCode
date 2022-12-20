using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class StaticVar
    {
        private static int count;
        private int rollno;
        private string name, country;

        public StaticVar(string name, string country)
        {
            count++;
            rollno = count;
            this.name = name;
            this.country = country;
        }
        public override string ToString()
        {
            return $"RollNo {rollno} name {name}  country {country}";
        }

        static void Main(string[]args)
        {
            StaticVar s = new StaticVar("Krishna","India");
            StaticVar s1= new StaticVar("Krishna", "India");
            Console.WriteLine(s);
            Console.WriteLine(s1);
           Console.WriteLine( count);

        }
    }
}
