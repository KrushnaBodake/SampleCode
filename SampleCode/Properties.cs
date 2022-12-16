using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class Properties
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthourName { get; set; }
        public int BookPrice { get; set; }

        public override string ToString()
        {
            return $"{BookId},{BookName}{AuthourName}{BookPrice}";
        }
    }
}
