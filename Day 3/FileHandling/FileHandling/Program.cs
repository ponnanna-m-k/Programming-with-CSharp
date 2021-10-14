using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Read the contents of the file
            //Read r = new Read();
            //r.readFile();

            //To Write into a file
            Write w = new Write();
            w.writeData();
        }
    }
}
