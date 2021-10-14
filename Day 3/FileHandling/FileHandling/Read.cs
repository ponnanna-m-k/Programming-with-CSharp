using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Read
    {
        public void readFile()
        {
            FileStream fs = new FileStream("D:\\Training\\Files\\check.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Reading from " + fs.Name);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }

            fs.Flush();
            fs.Close();

        }
    }
}
