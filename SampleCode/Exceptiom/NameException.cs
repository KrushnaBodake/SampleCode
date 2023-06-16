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
    public class MarksException : Exception
    {
        public MarksException(String Message):base (Message)
        {

        }
    }
    public class Student
    {
        private int marks;
        public void AcceptMarkks(int marks)
        {
            if(marks>100)
            {
                throw new MarksException("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
                Console.WriteLine(marks);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student ss = new Student();
                ss.AcceptMarkks(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
