using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.OOPs
{
    public class Vehicle
    {
        protected string colour;
        protected private string model;
        protected private string company;
      
        public void FuelType(string fueltype)
        {
            Console.WriteLine("fuel type is and base class method "+fueltype);
        }

    }
}
