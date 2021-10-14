using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            check c = new check();
            c.func1();

            check1 c1 = new check1();
            c1.func2();

        }

    }

    class check
    {
        public void func1()
        {
            Console.WriteLine("From Class check func1");
        }
    }

    class check1
    {
        public void func2()
        {
            Console.WriteLine("From Class1 check func2");
        }
    }
}
