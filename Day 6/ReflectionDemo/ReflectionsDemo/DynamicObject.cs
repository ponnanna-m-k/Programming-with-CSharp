using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class DynamicObject
    {
        public DynamicObject() { }
        public DynamicObject(int i) { }

        public void First_Method() 
        {
            Console.WriteLine("From first method");
        }
        public void Second_Method() 
        {
            Console.WriteLine("From Second method");
        }

    }
}
