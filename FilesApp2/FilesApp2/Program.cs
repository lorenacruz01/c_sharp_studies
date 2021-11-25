using System;
using System.IO;

namespace FilesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspace\c_sharp_studies\FilesApp2\file.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }

        }
    }
}
