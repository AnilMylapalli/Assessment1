using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assessment
{
    class SclInsUp
    {
        public static void Do()
        {
            Console.WriteLine("--Reading data to a file--");
            string CurDir = Directory.GetCurrentDirectory();
            string FileName = CurDir + "/studentdata2.txt";

            Console.WriteLine("reading contents from the file");

            List<string> lines = new List<string>();

            foreach (var line in File.ReadAllLines(FileName))
            {
                lines.Add(line);
            }

            foreach (string line in lines)
                Console.WriteLine(line);

            File.Delete(FileName);

            Console.WriteLine("please provide input in the below format");
            Console.WriteLine("ID:{}, Name: {}, Class: {}, Section: {}");

            lines.Add(Convert.ToString(Console.ReadLine()));

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                for (int i = 1; i < lines.Count; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                Console.WriteLine("--File created--");
            }
        }

        class StudentModel
        {
            public int ID { set; get; }
            public string Name { set; get; }
            public string Class { set; get; }
            public string Section { set; get; }
        }
    }
}
