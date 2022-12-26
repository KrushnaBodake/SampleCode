using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Exceptiom
{
    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }
    public class Stud
    {
        private string name;

      
        public void AcceptName(string name)
        {
            if (name==null)
            {
                throw new NameException("please Enter name Null field not Accepted");
            }
            else
            {
                this.name = name;
            }
        }
        public override string ToString()
        {
            return $"student name is {name}";
        }
    }
    public class Progra
    {
        static void Main(string[] args)
        {
            Stud s = new Stud();
            try
            {
                s.AcceptName(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(s.GetType());
            }

        }
    }
    

}
