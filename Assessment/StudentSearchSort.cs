using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assessment
{
    class StudentSearchSort
    {
        public static void Do()
        {
            Console.WriteLine("--Reading data to a file--");
            string CurDir = Directory.GetCurrentDirectory();
            string FileName = CurDir + "/studentdata2.txt";

            string[] lines = File.ReadAllLines(FileName);

            foreach (string line in lines)
                Console.WriteLine(line);
        }

        class StudentModel
        {
            public int ID { set; get; }
            public string Name { set; get; }
            public string  Class { set; get; }
        }
    }
}
