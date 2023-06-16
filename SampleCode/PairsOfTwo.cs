using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class PairsOfTwo
    {
              
        public void Pair( int[] a , int num)
        {
                for (int i = 0; i<a.Length-1; i++)
                {                  
                    for (int j = i+1; j<a.Length; j++)
                    {
                        if (a[i]+a[j]== num)
                        {
                             Console.WriteLine("("+a[i]+","+ a[j]+")");
                        }
                    }
                  
                }
        }
        static void Main(string[] args)
        {
                int num = 7;
                int[] a = new int[] { 4, 3, 7, 2, 5, 0,3,4 };
                PairsOfTwo s = new PairsOfTwo();
                s.Pair(a, num);
                
        }

        
    }
}
