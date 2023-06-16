using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public abstract class ClassAB
    {
        int a = 0;
        public ClassAB()
        {
            Console.WriteLine("hi");
        }

       
    }

    public class Mock1
    {

        static void Main(string []args)
        {
            // Output "tentod" , "avaj"
            String[] s = { "c", "angular", "java", "dotnet" };
           // Array.Reverse(s);
            for (int i = 0, j = s.Length -1; i < s.Length / 2 && j <= s.Length; i++,j--)
            {
                String temp = "";
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
              
               
            }
            Console.WriteLine(String.Join(" ",s));
            // dotnet java angular c

            for (int k = 0; k <s.Length; k++)
            {

                Char[] ch = s[k].ToCharArray();
                for (int n = 0, m = ch.Length - 1; n < ch.Length / 2 && m <= ch.Length; n++, m--)
                {
                    Char z;
                    z = ch[n];
                    ch[n] = ch[m];
                    ch[m] = z;

                } 
                s[k] = new String(ch);
            }
            Console.WriteLine(string.Join(" ", s));
           
        }
      

    }
    public class Reve
    {
        static void Main(string[] args)
        {
            String s = "dotnet";
            char[] ch = s.ToCharArray();

            for (int k = 0, m = ch.Length - 1; k < ch.Length / 2 && m <= ch.Length; k++, m--)
            {
                Char z;
                z = ch[k];
                ch[k] = ch[m];
                ch[m] = z;

            }
            String s2 = new String(ch);

            Console.WriteLine(s2);
            Console.WriteLine( string.Join(" ",ch));
        }
   
    }
    public class MergeArrWithoutDuplicate
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 3, 4 };
            int[] a2 = new int[] { 3, 4, 6 };
            int[] a3 = new int[7];

            int m = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                a3[m]= a1[i];
                m++;
            }

            for (int i = 0; i < a2.Length; i++)
            {
                a3[m] = a2[i];
                m++;
            }
            //1 2 3 4 3 4 6
            int zerocount = 0;
            for (int i = 0; i < a3.Length; i++)
            {
                for (int j = i+1; j <a3.Length; j++)
                {
                    if(a3[i]==a3[j])
                    {
                        a3[i] = 0;
                        zerocount++;
                    }
                }
            }
             Console.WriteLine(String.Join(" ",a3));
            Console.WriteLine("total no of zeros"+ zerocount);
            int[] e = new int[7 - zerocount];
            int z = 0;
            for (int i = 0; i < a3.Length; i++)
            {
                if(a3[i]!=0)
                {
                    e[z] = a3[i];
                    z++;
                }
            }
            Console.WriteLine(string.Join(" ",e));
        }
    }
    public class Mock2
    {
        static void Main(string[] args)
        {
            string[] s1 = { "Krushna","Arun","Mahesh","Nayan"};

              for (int i = 0, j = s1.Length - 1; i < s1.Length / 2 ; i++,j--)
              {
                 string temp;
                temp = s1[i];
                s1[i] = s1[j];
                s1[j] = temp;
              }
            Console.WriteLine(string.Join(" ",s1));
          
            for (int k = 0; k < s1.Length; k++)
            {
                char[] ch = s1[k].ToCharArray();
                for (int m = 0, n = ch.Length - 1; m < ch.Length / 2; m++, n--)
                {
                    char b;
                    b = ch[m];
                    ch[m] = ch[n];
                    ch[n] = b;
                   
                }
                s1[k] = new string(ch);
                              
            }
            Console.WriteLine(string.Join(" ", s1));
        }
    }
}
