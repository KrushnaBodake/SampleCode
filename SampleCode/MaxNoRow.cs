using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class MaxNoRow
    {
            public void FindMax(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int max = a[i, 0];
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                    Console.WriteLine(" max =" + max);
                    Console.WriteLine();
                }
            }
            static void Main(string[] args)
            {
                int[,] a = { {2,3,5,3},
                             {4,6,7,4},
                             {7,6,3,6} };
                MaxNoRow s = new MaxNoRow();

                s.FindMax(a);
            }
        
    }
}
