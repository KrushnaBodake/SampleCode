using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.DeligatAndEvent
{
    
    public delegate void MyDele();
    public class Bank
    {
        private double acbalance;
        public event MyDele InsufficientBal;
        public event MyDele Zero;
        public Bank(double acbalance)
        {
            this.acbalance = acbalance;
        }

        public void Debit(double amt)
        {
            if (amt > acbalance)
            {
                InsufficientBal();
            }
            else if(amt<=acbalance)
            {
                acbalance =acbalance - amt;
                
            }
            if (acbalance == 0)
            {
                Zero();
            }
        }
        public void Credit(double amt)
        {
            acbalance =acbalance + amt;
        }
        public override string ToString()
        {
            return $"Current balance is {acbalance}";
        }
    }
    public static class SMessage
    {
        public static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient Balance to withdraw");
        }
        public static void ZeroBalance()
        {
            Console.WriteLine("Cureent Account balance is Zero");
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Bank b1 = new Bank(5000);
            b1.InsufficientBal += new MyDele(SMessage.InsufficientBalance);
            b1.Zero += new MyDele(SMessage.ZeroBalance);
            Console.WriteLine("Credit of 1500");
            b1.Credit(1500);
            Console.WriteLine(b1);

            Console.WriteLine("Debit 15000");
            b1.Debit(15000);
            Console.WriteLine(b1);

            Console.WriteLine("debit 6500");
            b1.Debit(6500);
            Console.WriteLine(b1);
        }
    }
   /* public delegate void MyDelegate();
    public class ClassBank
    {
        public event MyDelegate InBal;
        public event MyDelegate Zero;

       private double acbalance;
        public ClassBank(double acbalance )
        {
            this.acbalance = acbalance;
        }
        public void Debit(int amt)
        {
            if(amt>acbalance)
            {
                InBal();
            }
            else
            { acbalance = acbalance - amt; 
                if(amt==acbalance)
                {
                    Zero();
                }
            }          
        }
        public void Credit(int amt)
        {
            acbalance = acbalance + amt;
        }
        public override string ToString()
        {
            return $"current balance is { acbalance}";
        }

    }
    public static class Message
    {
        public static void InsufficientBal()
        {
            Console.WriteLine("Insufficient fund to withdraw");
        }
        public static void ZeroBalance()
        {
            Console.WriteLine("Current acc balance is Zero");
        }

    }

   public class Call
   {
        static void Main(string[] args)
        {
            ClassBank b = new ClassBank(5000);
            b.InBal += new MyDelegate(Message.InsufficientBal);
            b.Zero += new MyDelegate(Message.ZeroBalance);


        }
   }
*/

}


