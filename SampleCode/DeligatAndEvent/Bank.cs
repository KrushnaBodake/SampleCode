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
            else
            {
                acbalance =acbalance - amt;
                if (acbalance == 0)
                {
                    Zero();
                }
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

            Console.WriteLine("debit 6000");
            b1.Debit(6000);
            Console.WriteLine(b1);
        }
    }

    public delegate void Mydeleg();

    public class Bank1
    {
        public event Mydeleg InsBalance;
        public event Mydeleg Zero;
        private double acbalance;
        public void Debit(double debitamount)
        {
           if(acbalance<debitamount)
           {
                InsBalance();

           }
          else 
           {
                acbalance = acbalance - debitamount;
                if (acbalance == 0)
                {
                    Zero();
                }
            }
            
        }
        public void Credit(double creditamount)
        {
            acbalance = acbalance + creditamount;
           
        }
        public Bank1(double acbalance)
        {
            this.acbalance = acbalance;
        }
        public override string ToString()
        {
            return $"{acbalance}";
        }
    }
    public class Messagee
    {
        public void InsufficientBalance()
        {
            Console.WriteLine("Enter Valid Amount");
        }
        public void ZeroBalance()
        {
            Console.WriteLine("Zero Balnce in Account");
        }
    }
    public class Mainmethod
    {
        static void Main(string[] args)
        {
            Bank1 b = new Bank1(10000);
            Messagee m = new Messagee();
            b.InsBalance += new Mydeleg(m.InsufficientBalance);
            b.Zero += new Mydeleg(m.ZeroBalance);

            Console.WriteLine(b);

            b.Debit(10000);
            b.Credit(5000);

            Console.WriteLine(b);
        }
       
        
    }
}


