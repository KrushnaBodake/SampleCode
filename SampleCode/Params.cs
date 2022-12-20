using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Params
    {
        public void AcceptParams(params string[] names)
        {
            Console.WriteLine("Length of strings" + names.Length);

            foreach(var a in names)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[]args)
        {
            Params p = new Params();
            p.AcceptParams("Vikas", "Prakas", "Krishna");
            p.AcceptParams("Suyash", "Shubham");
        }
    }
}
