using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    public class Class1 : IDisposable
    {
        public void Display_Msg()
        {
            Console.WriteLine("Inside Display Method");
        }
        public Class1()
        {
            Console.WriteLine("Default Constructor");
        }
        public Class1(string s)
        {
            Console.WriteLine("Parameterized Constructor with a message {0}", s);
        }
        public void Dispose()
        {
            Console.WriteLine("Freeing up space using Dispose");
            GC.SuppressFinalize(this);
        }
    }
}
