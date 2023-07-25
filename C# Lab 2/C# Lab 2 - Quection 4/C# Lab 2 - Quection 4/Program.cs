using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_2___Quection_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + "is even");
            else
                Console.WriteLine(n + "is odd");
            Console.ReadKey();
        }
    }
}
