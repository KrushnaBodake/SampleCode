using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.OOPs
{
    public class Encap
    {
        
        public string name;
        double balance;
        
        public double GetBal()   // getter method
        {
            return balance;
        }
        public void SetBalance(double balance)    //Setter method
        {
            if(balance>0)
            {
                this.balance = balance;
            }  
            else
            {
                throw new Exception("Please pass a +ve Value");
            }
        }
      
    }
    public class Encap1
    {
        static void Main(string[] args)
        {
            try
            {
                Encap e = new Encap();
                e.name = "krushna";
                e.SetBalance(-500);
                Console.WriteLine(e.GetBal());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
    public class Encapasulate
    {
       
        private double balance;

        public double Balance 
        {
            get
            { 
                return balance; 
            }
            set
            {
                if(value<0)
                {
                    throw new Exception("Pl pass +ve Value");
                }
                else
                {
                    balance = value;
                }               
            }
        }

    }
    public class Encap2
    {
        static void Main(string[] args)
        {
            try
            {
                Encapasulate e = new Encapasulate();
                e.Balance=10;                 // set
                Console.WriteLine(e.Balance); // get return
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    public class E
    {
        public int Amount { get; set; }

    }
    public class E1
    {
        static void Main(string[] args)
        {
            E e = new E();
            e.Amount = 10;
            Console.WriteLine(e.Amount);

        }
    }
}

