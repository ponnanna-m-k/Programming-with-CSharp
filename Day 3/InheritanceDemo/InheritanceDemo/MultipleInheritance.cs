using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class MultipleInheritance
    {
    }

    interface c1
    {
        public void func1()
        {
            Console.WriteLine("From Class C1");
        }

    }

    interface c2
    {
        public void func2()
        {
            Console.WriteLine("From Class C2");
        }

    }

    class c3 : c1,c2
    {
        //public void func3()
        //{
        //    Console.WriteLine("From Class C3");
        //}

    }



}
