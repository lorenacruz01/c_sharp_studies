using SetApp1.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace SetApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            Console.Write("Enter file's full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(username, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
