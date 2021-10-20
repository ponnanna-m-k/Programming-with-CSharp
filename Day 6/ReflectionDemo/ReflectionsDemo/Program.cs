using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection Demo in C#....");
            Type T = typeof(int);
            Console.WriteLine("Type Of Name : {0}", T.Name);
            Console.WriteLine("Full name of the type defined : {0}", T.FullName);
            Console.WriteLine("Type Of Assembly : {0} ", T.Assembly);
            Console.WriteLine("Information about base type : {0}", T.BaseType);
            Console.WriteLine("Attributes of type : {0}", T.Attributes);


            //Demonstration of dynamic objects

            DynamicObject d = new DynamicObject();
            d.First_Method();
            d.Second_Method();

            Console.WriteLine("\nDynamic\n");
            dynamic dy = new DynamicObject();
            dy.First_Method();
            dy.Second_Method();

        }
    }
}
