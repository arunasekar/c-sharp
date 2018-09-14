using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int n, fact = 1;
            Console.Write("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + n + " is: " + fact);
            Console.ReadLine();
        }
       
    }
}
