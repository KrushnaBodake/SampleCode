using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Coll
{
    
   /* public class Bank
    {
        public string AccontType { get; set; }
        public string  CustomerName { get; set; }

    }
    public class LoanType
    {
        public string Loan { get; set; }
       
        public List<Bank> Studlist = new List<Bank>();

    }
    public class Program
    {

        static void Main(string[] args)
        {
            //Account   saving , current  (cus.NAme)
            // Loans   (home, car,personal, gold)
            List<LoanType> list = new List<LoanType>()
            {
                new LoanType{

                   Loan="Gold",
                    Studlist={
                        new Bank{AccontType="Saving",CustomerName="Abc" },
                        new Bank{AccontType="Current",CustomerName="xyz" }
                            }
                     },
                new LoanType{
                   Loan="Home",
                    Studlist={
                         new Bank{AccontType="Saving",CustomerName="Abc" },
                        new Bank{AccontType="Current",CustomerName="xyz" }
                            }
                     },
            };


            foreach (LoanType a in list)
            {
                Console.WriteLine($"{a.Loan}");
                foreach (Bank s in a.Studlist)
                {
                    Console.WriteLine($"\t{s.AccontType}  {s.CustomerName} {s.C");
                }
            }
        }*/


    
    public enum AccountType { Saving, Current }
    public class Customer
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public AccountType AccountType;
        public List<Loan> Loans = new List<Loan>();
    }
    public class Loan
    {
        public int Id { get; set; }
        public string LoanName { get; set; }
    }
    public class Pro
    {

        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>()
            {
                new Customer
                {
                    AccNo = 101,
                    Name="Customer1",
                    AccountType=AccountType.Saving,
                    Loans =
                    {
                        new Loan{Id=1,LoanName="Car"},
                        new Loan{Id=2,LoanName="Home"},
                    }
                },
                new Customer
                {
                    AccNo = 102,
                     Name="Customer2",
                    AccountType=AccountType.Current,
                    Loans =
                    {
                        new Loan{Id=1,LoanName="Business"},

                    }
                }
            };

            foreach (Customer c in list)
            {
                Console.WriteLine($"{c.Name} ,{c.AccountType}");
               
            }

           
          /*  foreach (Loan s in c.Loans)
            {
                Console.WriteLine($"\t{s.LoanName}");
            }
*/
        }


    }


}
