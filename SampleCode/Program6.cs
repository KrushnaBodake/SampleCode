using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Program6
    {
        static void Main(string[] args)
        {            
            List<Student2> stulist = new List<Student2>();
            stulist.Add(new Student2 { Id = 1, Name = "Arun", course = { new Course { Cid=1, Cname="C#",Fees=35000 },
                new Course { Cid=2, Cname="java",Fees=35000 } } });
            stulist.Add(new Student2
            {
                Id = 2,
                Name = "Krushna",
                course = { new Course { Cid=1, Cname="C++",Fees=5000 },
                 }
            });
            foreach (Student2 item in stulist)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
                
                foreach (Course item1 in item.course)
                {
                    Console.WriteLine($"{item1.Cid} {item1.Cname} {item1.Fees}");
                    
                }
            }
            Console.WriteLine("*********************************************************");
            
            foreach (Student2 item in stulist)
            {
                if (item.course.Count > 1)
                {
                    Console.WriteLine(item.Name);
                    foreach (Course item1 in item.course)
                    {
                        Console.WriteLine($"{item1.Cid} {item1.Cname} {item1.Fees}");

                    }
                }
            }
        }
    }
    public class Student2
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Course> course = new List<Course>();      

    }
    public class Course
    {      
        public int Cid { get; set; }
        public string Cname { get; set; }
        public double Fees { get; set; }       
    }
  
}
