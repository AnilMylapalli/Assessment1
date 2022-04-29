using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assessment
{
    class StudentData
    {
        public static void Do()
        {
            //Name: Dheeraj Kumar, RollNo: 1, Class - 10th, Location: Pune

            Console.WriteLine("--Writing data to a file--");
            string CurDir = Directory.GetCurrentDirectory();
            string FileName = CurDir + "/studentdata.txt";

            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine("ID:" + i + ", Name: Dheeraj Kumar" + i + ", RollNo:" + i + ", Class - " + i + ", Location: Pune");
                }
                Console.WriteLine("--File created--");
            }

            Console.WriteLine("--Reading data to a file--");

            Console.WriteLine(File.ReadAllText(FileName));
            Console.Read();
        }
    }
}
