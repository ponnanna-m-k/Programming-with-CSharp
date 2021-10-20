using System;

namespace UserDefinedAttributes
{
    [Author("P.Hanselman", version_number = 1.0)]




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo User Defined Attributes!");
            AuthorAttribute A1 = new AuthorAttribute("John");
            Console.WriteLine("By default version of the Author : {0}", A1.version_number);

        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class AuthorAttribute : System.Attribute
    {
        private string Author_name;
        public double version_number;



        public AuthorAttribute(string name)
        {
            this.Author_name = name;
            version_number = 4.0;
            Console.WriteLine("The author name is : {0}", name);
        }
    }
}
