using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class String1
    {
        static void Main(string[] args)
       {
            string str1 = "Hello to All";
            Console.WriteLine("Length of String Hello to All "+ str1.Length);

           

            string str2 = "Welcome to Csharp";
            str1.Concat(str2);

            string str = String.Concat(str1, str2);
            Console.WriteLine("Caoncate Hellow to All + Welcome to C#:"+str);

            bool l = String.IsNullOrEmpty(str1);
            Console.WriteLine("Hello to All is null;"+l);

            bool b = str1.StartsWith("Hi");
            Console.WriteLine("Hello to All is start with Hi ;"+b);

            bool c = str2.EndsWith("Csharp");
            Console.WriteLine("Welcome to cSharp end with Csharp;"+c);

            bool cc = str2.Contains("Welcome");
            Console.WriteLine(" WelCOme to csharp contains welcome;"+cc);

            String u = str1.ToUpper();
            Console.WriteLine("Hello to all in UpeerCase;"+u);
            String ll = str1.ToLower();
            Console.WriteLine("Hello to all in Lower case;"+ll);

           // Trim, TrimEnd, TimStart
             String t= str1.Trim();
            Console.WriteLine("Trim Hello to all: "+t);

            String te = str1.TrimEnd();
            Console.WriteLine("Trim End hello to all:"+te);

/*
            char[] ch = str1.ToCharArray();

            foreach (var c in ch)
            {
                Console.WriteLine(c);
            }*/

            string s = "TEST";
            string s1 = "test";

            int i = String.Compare(s, s1);
            Console.WriteLine("Compare two strings :"+ i);
            Console.WriteLine("Compare to method:"+s.CompareTo(s1));

            bool e = str.Equals(str2);
            Console.WriteLine("Equals check two strings are equal "+e);

            Console.WriteLine("SubString  hello to All;"+str.Substring(2, 7)); 

            int j=str1.IndexOf('H');
            Console.WriteLine("Returns the index of chatacter;"+j);

            String ss1=str1.Remove(0, 3);
            Console.WriteLine("Remove Nethod Hello to All(0 3):" + ss1);

            
        }

    }
    class S
    {
        static void Main(string[] args)
        {

            
            string s = "KriShnA";
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                {
                    ch[i] = char.ToLower(ch[i]);
                }

                else
                    ch[i] = char.ToUpper(ch[i]);

            }
            Console.WriteLine(string.Join("", ch));


          /*  string s = "nitin";
            string revs = "";

            for (int i = s.Length - 1; i >= 0; i--) //Revesrse
            {
                revs = revs + s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome {0} and reverse string is {1}", s, revs);
            }*/
        }
    }
   
}
