using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Finalizer!");
            Class1 obj = new Class1("Helloo ");
            obj.Display_Msg();
            obj.Dispose();
            Console.ReadKey();
        }
    }
}
