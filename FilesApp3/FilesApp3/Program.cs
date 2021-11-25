using System;
using System.IO;

namespace FilesApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\workspace\c_sharp_studies\FilesApp3\file.txt";
            string targetPath = @"C:\workspace\c_sharp_studies\FilesApp3\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
