using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.OOPs
{
    //////////////////////////////////   Welcome to Interface    /////////////////////////////////
  
    public interface IBank
    {
        void BankTransfer();
        void CheckBalance();
     
    }
    public interface IBank1
    {
        void ValidateUser();       
    }


  /*  public class BankFactory
    {
        public static IBank GetBankObject(String bankType)
        {
            IBank BankObject = null;
            if(bankType=="Abstractio")
            {
                BankObject = new Abstractio();
            }
            else
            {

            }
        }
    }
*/

    public class Abstractio : IBank , IBank1//SBI services
    {

        public void BankTransfer()
        {
            Console.WriteLine("Sbi bank Transfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("Sbi bank Check Bal");
        }

        public void ValidateUser()
        {
           
        }
    }
    public class Axis : IBank,IBank1
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIS bank Transfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("Axis bank Check Bal");
        }

        public void ValidateUser()
        {
            Console.WriteLine("Axis bank Validate");
        }
    }
    public class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transction for Sbi");
            IBank ibank = new Abstractio();
            ibank.BankTransfer();
            ibank.CheckBalance();


            Console.WriteLine("Transction for Axis");
            IBank bank =new Axis();
            bank.BankTransfer();
            bank.CheckBalance();
            IBank1 b = new Axis();
            b.ValidateUser();

           
        }
    }

    /////////////////////////////   welcome to Abstarct Class  ///////////////////////////////


    public abstract class Bank
    {
        public Bank()
        {
            Console.WriteLine("Hi i am Constructor Method");
        }
        public abstract void BankTransfer1();

        public abstract void CheckBalance1();
        public void Hi()
        {
            Console.WriteLine("hi Abstract class method");
        }
    }
    public class Union : Bank
    {
        public override void BankTransfer1()
        {
            Console.WriteLine("Union Bank Transfer");
        }

        public override void CheckBalance1()
        {
            Console.WriteLine("Union BAnk Check Balance");
        }
    }
    public class HDFC : Bank
    {
        public override void BankTransfer1()
        {
            Console.WriteLine("Union Bank Transfer");
        }

        public override void CheckBalance1()
        {
            Console.WriteLine("Union BAnk Check Balance");
        }
    }
    public class ABS
    {
        static void Main(string[] args)
        {
            Bank b = new Union();
            b.Hi();
            b.BankTransfer1();
            b.CheckBalance1();
        }
    }
}
