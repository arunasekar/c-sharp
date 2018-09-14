using System;
namespace Application
{
    class A
    {
        public void show()
        {
            Console.WriteLine("Welcome to the world of c#");
        }
    }
    class B : A //class B is derived by class A
    {
        public void display()
        {
            Console.WriteLine("Hello");
        }
    }
    class C : B //class C is derived by class B
    {
        public void show1()
        {
            Console.WriteLine("How are You ?");
        }
        class multilevel
        {
            public static void Main()
            {
                C obj = new C();
                obj.show();               // super class member function
                obj.display();                 // base class member function
                obj.show1();                 // own member function
            }
        }
    }
}