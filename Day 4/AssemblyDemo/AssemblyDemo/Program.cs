using System;
using AssemblyDemo;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stringer myStringInstance = new Stringer(); 
            Console.WriteLine("Client code executes"); 
            myStringInstance.StringerMethod();
        }
    }
}
