using System;
using System.IO;
using System.Collections.Generic;

namespace FilesApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\workspace\c_sharp_studies\FilesApp4\myFolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //qualquerNome.qualqueExtensão
                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //qualquerNome.qualqueExtensão
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
