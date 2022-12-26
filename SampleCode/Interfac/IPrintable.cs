using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public interface IPrintable
    {
        string Print();
    }
    public class Student1: IPrintable
    {
        string IPrintable.Print()
        {
            return" student name";
        }
        
    }
    public class Employee1 : IPrintable
    {
        string IPrintable.Print()
        {
            return " Employee Salary";
        }

    }
  
}
