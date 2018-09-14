using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream obj = new FileStream("c:/C sharp/aruna.txt", FileMode.Create, FileAccess.Read, FileShare.Read);
            StreamWriter sw = new StreamWriter(obj);
            StreamReader sr = new StreamReader(obj);
            String s;
            Console.WriteLine("Enter values:");
            s = Console.ReadLine();
            sw.Write(s);
            String s1;
            s1 = sr.ReadToEnd();
            Console.WriteLine("values:" + s1);
            sw.Close();
            sr.Close();
            Console.ReadLine();
        }
    }
}
