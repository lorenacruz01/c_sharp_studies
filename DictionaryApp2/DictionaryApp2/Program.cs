using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file's full path: ");
            string path = Console.ReadLine();
            try
            {
                Dictionary<string, int> allVotes = new Dictionary<string, int>();
                string[] line;
                string name;
                int votes;
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split(',');
                        name = line[0];
                        votes = int.Parse(line[1]);
                        if (allVotes.ContainsKey(name))
                        {
                            allVotes[name] += votes;
                        }
                        else
                        {
                            allVotes[name] = votes;
                        }
                    }
                    Console.WriteLine("---RESULTS---");
                    foreach(KeyValuePair<string, int> item in allVotes)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
