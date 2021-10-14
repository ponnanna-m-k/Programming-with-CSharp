using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQDemo
{
    class LinqDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ implementation in C#");
            int[] scores = new int[] { 15, 20, 42, 76 };
            //Console.WriteLine(score[3]);

            IEnumerable<int> scoreQuery =
               from score in scores
               where score > 80
               select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
