using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadingDemo;

namespace MultiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            Console.WriteLine("Main Thread Started");

            ThreadStart s1 = w.Count;
            ThreadStart s2 = w.Alphabets;
            Thread t1 = new Thread(s1);
            Thread t2 = new Thread(s2);
            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread ends");
            Console.ReadKey();
        }
    }
}
