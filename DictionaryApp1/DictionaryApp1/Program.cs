using System;
using System.Collections.Generic;

namespace DictionaryApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "mariateste@gmail.com";
            cookies["phone"] = "11111111";
            cookies["phone"] = "22222222"; //não admite repetições na mesma chave, então sobrescreve

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            } else
            {
                Console.WriteLine("There is no 'email' key!");
            }

            Console.WriteLine("Dictionary's size: " + cookies.Count);
            Console.WriteLine("---ALL COOKIES---");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
