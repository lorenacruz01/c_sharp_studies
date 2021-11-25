﻿using System;
using System.IO;

namespace FilesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspace\c_sharp_studies\FilesApp2\file.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
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
