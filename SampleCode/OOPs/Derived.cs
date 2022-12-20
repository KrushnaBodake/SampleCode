using System;/* Console.WriteLine(d.colour = "red");
            d.FuelType("petrol");
            d.accelaration="speed";
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.OOPs
{
    public class Derived : Vehicle
    {
        private string accelaration;
        private string gearchange;

        public void FuelType(string fueltype)
        {
            Console.WriteLine($"i am derived class fuel type is" + fueltype);
        }

        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.FuelType("petrol");
   
        }
    }

    
}
