using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class MoveZeros
    {
        public void ShiftZeroAtLeft(int[]a)
        {
            for(int i=0; i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[j]==0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }
        }
        public void ShiftZeroRight(int[] a)
        {
            for (int i =a.Length-1; i >=1; i--)
            {
                for (int j = i - 1; j >=0; j--)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                       
                    }
                }
                
            }
            
        }
        /*public void Move(int[] a)
        {
            int count= a.Length - 1;
            
                for (int i = count ; i >=0; i--)
                {
                    if (a[i] != 0)
                    {
                    a[count] = a[i];
                    count--;
                    }
                }
                while(count>=0)
                {
                     a[count] = 0;
                     count--;
                }
                for(int i=0;i<a.Length;i++)
                {
                Console.WriteLine(a[i] + " ");
                }
            Console.WriteLine("..........Zero At the End............");

        }

        public void MoveZ(int[] a)
        {
            int count = 0;

            for (int i = 0; i<a.Length;i++)
            {
                if (a[i] != 0)
                {
                    a[count] = a[i];
                    count++;
                }
            }
            while (count<a.Length)
            {
                a[count] = 0;
                count++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }*/
        static void Main(string[] args)
        {
        
          int[] a = new int[] { 2,10,0,5,3,0,4,1};
            MoveZeros s = new MoveZeros();
            s.ShiftZeroAtLeft(a);
           /* foreach( var item in a)
            {
                Console.WriteLine(item);
            }
*/
            s.ShiftZeroRight(a);
            foreach (var b in a)
            {
                Console.WriteLine(b);
            }


        }
    }
}
