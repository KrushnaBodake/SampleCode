﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
   public class Annagram
   {
        public static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string str = new string(ch1);
            string st = new string(ch2);

            if (str == st)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
   }
    public class Pallindreome
    {
        
        static void Main(string[] args)
        {
            String s = "nitin";
            String rev = "";
            for (int i = s.Length-1; i >=0 ; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine(rev);
            if(rev==s)
            {
                Console.WriteLine("string is Pallindrom");
            }
        }
        

    }

}
