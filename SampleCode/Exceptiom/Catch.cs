using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Exceptiom
{
    public class Catch
    {
        public void Excepti()
        {
            int a = 4, b = 2;
            try
            {
                int[] arr = new int[5];
                arr[7] = 100;
                try
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            /*int a = 4, b = 2;
            try
            {
                int[] arr = new int[5];
                arr[7] = 100;
                try
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            Catch E = new Catch();
            E.Excepti();

        }
       
        
    }
}
