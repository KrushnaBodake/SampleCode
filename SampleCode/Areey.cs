using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Areey
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 6, 8, 2, 0, 5 };
            //  Console.WriteLine(arr[1]);

            int[] arr1 = { 1, 2, 3 };

            int[] arr2 = new int[3];

            
           // Array.Sort(arr);
            Array.Copy(arr, arr1, 1);
            foreach (int a in arr1)
            {
                Console.WriteLine(a);
            }

        }
       
    }
    class TwoDarray
    {
        static void Main(string[] args)
        {



            int[,] arr = new int[4, 3];
            Console.WriteLine("enter 2d array elements");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Display 2D Array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////////////////////////////////////");

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
