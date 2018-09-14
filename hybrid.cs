using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            b o1 = new b();//creating object for the derived class
            o1.show();//calling method from child class
            o1.display();//calling method from parent class
            Console.ReadKey();
        }
        class a//parent or base class
        {
            public void display()
            {
                Console.WriteLine("display");
            }
        }
        class b : a//child or derived class inherited with base class
        {
            public void show()
            {
                Console.WriteLine("show");
            }
        }
    }
}