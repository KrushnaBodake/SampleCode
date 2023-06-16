using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Exceptiom.Threadd.FileSerlizaton
{
    public class Stream
    {
        static void Main(string[] args)
        {
            string path = @"E:\SkillMineDoc\Test1.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string data = reader.ReadToEnd();

                    Console.WriteLine(data);
                }

            }

        }
    }
}
