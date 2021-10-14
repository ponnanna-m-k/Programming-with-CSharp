using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Write
    {
        public void writeData()
        {
            FileStream write = new FileStream("D:\\Training\\Files\\check.txt", FileMode.Append);
            StreamWriter s = new StreamWriter(write);
            Console.WriteLine("Type the contents");
            string content = Console.ReadLine();
            s.WriteLine(content);
            s.Flush();
            write.Flush();
            write.Close();
        }
    }
}
