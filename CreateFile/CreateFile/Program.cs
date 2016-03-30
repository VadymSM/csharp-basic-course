using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"c:\Temp";
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            string file = Path.Combine(folderName, "MyFile.txt");
            for (int i = 20; i < file.Length; i++)
            {                
                File.WriteAllText(file, "Hello World!");                
            }

            string text = File.ReadAllText(@"c:\Temp\MyFile.txt");
            Console.WriteLine();

            
            

            Console.ReadLine();
        }
    }
}
