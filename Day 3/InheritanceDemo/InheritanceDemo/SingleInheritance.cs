using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SingleInheritance
    {
    }

    class abc
    {
        public void funcA()
        {
            Console.WriteLine("From Class A");
        }

    }

    class bcd : abc
    {
        public void funcB()
        {
            Console.WriteLine("From Class B");
        }

    }
}
