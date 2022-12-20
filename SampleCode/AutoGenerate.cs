using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class AutoGenerate
    {
        private int srno;
        private int carno;
        private string carname, colour, fueltype ,  model;
        private int passingyear;
        private static int count;

        public AutoGenerate(int carno,string colour,string model="swift")
        {
            count++;
            srno = count;
            this.carno = carno;
            this.colour = colour;
            this.model = model;
          
        }
        public int PassingYear(int passingyear, int srno=1)
        {
            return passingyear;
        }

        public string CarName
        {
            set { carname = value; }
            get { return carname; }
        }
        public string FuelType
        {
            set { fueltype = value; }
            get { return fueltype; }
        }
        public override string ToString()
        {
            return $"{carno} , {colour}, {carname}, {fueltype}, {passingyear}{model} {srno} ";
        }
    }
    
}
