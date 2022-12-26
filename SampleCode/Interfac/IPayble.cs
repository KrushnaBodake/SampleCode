using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public interface IOrder
    {
        string Display();
    }

    public interface ICustomer
    {
        string Display();
    }

    public class Transcations:IOrder,ICustomer
    {
        string IOrder.Display()
        {
            return "Order Details";
        }
        string ICustomer.Display()
        {
            return "Customer Details";
        }

        static void Main(string[] args)
        {
            IOrder order = new Transcations();
            Console.WriteLine(order.Display());

            ICustomer customer = new Transcations();
            Console.WriteLine(customer.Display());
        }

    }
  
}
