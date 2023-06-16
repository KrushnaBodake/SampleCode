using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Problemarr
    {    
        int[] c = new int[12];
        int[] e = new int[4];
        int[] x = new int[4];

        int d = 0;
       
        public void Unique(int[]a,int[]b)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if(i<a.Length)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = b[d];
                    d++;
                }
                
            }
            Console.Write("Addition of two array =");
            Console.WriteLine(String.Join("",c));
            int z = 0;
            for (int i = 0; i < c.Length; i++)
            {
                for (int j =i+1; j < c.Length; j++)
                {
                    if(c[i]==c[j])
                    {
                        e[z] = c[i];
                        z++;
                    }
                                      
                }
            }
            Console.Write("Common Elments e = ");
            Console.WriteLine(String.Join(",", e));
            int r = 0;
            for (int i = 0; i < c.Length; i++)
            {
                bool isvisited = false;
                for (int k = i + 1; k < c.Length; k++)
                {
                    if (c[i] == c[k])
                    {
                        isvisited = true;
                        break;
                    }
                }

                if (isvisited == false)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (c[i] == c[k])
                        {
                            isvisited = true;
                            break;
                        }
                    }
                    if (isvisited == false)
                    {
                        x[r] = c[i];
                        r++;
                    }

                }
            }
            Console.Write("Uncommon= ");
            Console.WriteLine(String.Join("", x));

        }
        static void Main(string[] args)
        {
            int[] a =  { 1, 2, 3, 4, 5, 6 };
            int[] b = { 8, 2, 3, 5, 6, 9 };
           
            Problemarr problemarr = new Problemarr();
            problemarr.Unique(a, b);
            Console.ReadLine();

        }
    }
    
    class Uncommon1
    {
        public void Frequency(int[] a)
        {
            int[] x = new int[4];
            int d = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isvisited = false;
                for (int k =i+1; k < a.Length; k++)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                
                if (isvisited == false)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (a[i] == a[k])
                        {
                            isvisited = true;
                            break;
                        }
                    }
                    if(isvisited==false)
                    {
                        x[d] = a[i];
                        d++;
                    }
                    
                }
            }
            Console.WriteLine(String.Join("", x));

        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6, 8, 2, 3, 5, 6, 9 };
            
            Uncommon1 s = new Uncommon1();
            s.Frequency(arr);
            Console.ReadLine();
        }
    }
    public class Uncommon
    {
        static void printUncommon(int[] arr1,
                          int[] arr2,
                          int n1,
                          int n2)
        {

            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                {
                    Console.Write(arr1[i] + " ");
                    i++;
                    k++;
                }
                else if (arr2[j] < arr1[i])
                {
                    Console.Write(arr2[j] + " ");
                    k++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            while (i < n1)
            {
                Console.Write(arr1[i] + " ");
                i++;
                k++;
            }
            while (j < n2)
            {
                Console.Write(arr2[j] + " ");
                j++;
                k++;
            }
        }
        public static void Main()
        {
            int[] arr1 = { 2,3,4,5,6 };
            int[] arr2 = { 2,3,5,7,1 };

            int n1 = arr1.Length;
            int n2 = arr2.Length;

            printUncommon(arr1, arr2, n1, n2);
        }
    }
}
