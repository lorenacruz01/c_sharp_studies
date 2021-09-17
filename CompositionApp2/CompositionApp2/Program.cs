using System;
using CompositionApp2.Entities;

namespace CompositionApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow... that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("17/09/2021 14:00:02"),
                "Traveling to New Zealand",
                "Im going to visit this worderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post p2 = new Post(
                DateTime.Parse("17/09/2021 14:05:05"),
                "Good night guys!",
                "See you tomorrow :)",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
