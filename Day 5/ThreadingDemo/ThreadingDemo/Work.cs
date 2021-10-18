using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Work
    {
        public void Count()
        {
            Console.WriteLine("Thread 1 Start");
            for(int i=0; i<100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 1 Ended");
        }

        public void Alphabets()
        {
            Console.WriteLine("Thread 2 Start");
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Thread 2 Ended");
        }
    }
}
