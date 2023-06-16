using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Collectiom
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }

        static void Main(string[] args)
        {
            /* Employee p1 = new Employee { empId = 01 };
             ArrayList list = new ArrayList();
             list.Add(p1);

             list.Add(10);
              list.Add("Hello");
              list.Add(63.78);

             list.Insert(0, 5);
             list.Insert(2, 50);

             int[] arr = new int[] { 100, 55, 200 };

             list.AddRange(arr);
             list.Remove(63.78);

             string name = list[3].ToString();
             double d = Convert.ToDouble(list[4]);

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }

             list.Sort();
             list.Reverse();

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }
 */

        }
    }
    public class Service
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public int Price { set; get; }

    }
}
   // public class CollArrayLis
    //{
        /*static void Main(string[] args)
        {
            Service s = new Service { Id = 01, Name = "Keyboard", Price = 4500 };
            Collectiom c = new Collectiom { Id = 02, Name = "Mouse", Salary=2000 };

            ArrayList list = new ArrayList();
            list.Add(s);
            list.Add(c);

            foreach( var item in list)
            {
                if(typeof(Service)==item.GetType())
                {
                    Service ss = (Service)item;
                    Console.WriteLine(ss.Id + " " + ss.Name + " " + ss.Price);
                }
                else if (typeof(Collectiom)==item.GetType())
                {
                    Collectiom cc=(Collectiom)item;
                    Console.WriteLine(cc.Id + " " + cc.Name + " " + cc.Salary);
                }
            }
        }
    }
  

*/



