using System;
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

        public override void FuelType(string fueltype)
        {
            Console.WriteLine($"i am derived class fuel type is" + fueltype);
        }

        static void Main(string[] args)
        {
            Vehicle d = new Derived();
            d.FuelType("petrol");
            d.FuelType("petrol");

        }
    }

    
}
