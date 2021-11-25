using System;
using System.IO;

namespace FilesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\workspace\c_sharp_studies\FilesApp1\csharpfiletest.txt";
            string targetPath = @"C:\workspace\c_sharp_studies\FilesApp1\csharpfiletest2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
