using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.DeligatAndEvent
{
    public delegate void MyDel();

    public class EventStudent
    {
        public event MyDel Pass;   // Declaration of Event
        public event MyDel Fail;

        public void Accept(int marks)
        {
            if(marks>=40)
            {
                Pass();   // Raise An Event
            }
            else
            {
                Fail();
            }
        }
    }
    public static class Message
    {
        public static void PassMessage()
        {
            Console.WriteLine("Great ! you are pass");
        }
        public static void FailMessage()
        {
            Console.WriteLine(" ");
        }
    }
    public class Programm
    {
        static void Main(string[] args)
        {
            EventStudent stud = new EventStudent();
            stud.Pass += new MyDel(Message.PassMessage);
            stud.Fail += new MyDel(Message.FailMessage);

            Console.WriteLine("Enter Marks");
            int n = Convert.ToInt32(Console.ReadLine());
            stud.Accept(n);
        }
    }
}
