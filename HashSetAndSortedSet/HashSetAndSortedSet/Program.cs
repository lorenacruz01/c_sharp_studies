using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Uso do HashSet---");
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("tablet");
            set.Add("smartwatch");
            Console.WriteLine(set.Contains("Notebook"));


            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
            

            Console.WriteLine("---Uso do SortedSet---");
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            Console.Write("a: ");
            PrintCollection(a);
            Console.Write("b: ");
            PrintCollection(b);
            //union
            Console.WriteLine("---Uso do UnionWith---");
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            Console.WriteLine("---Uso do IntersectWith---");
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            Console.WriteLine("---Uso do ExceptWith---");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T> (IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
