using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___Q_6
{
    internal class program
    {
        static void Main(string[] arrgs)
        {
            Console.Write("enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayOperations arrayOps = new ArrayOperations();
            arrayOps.FillArray(size);

            Console.ReadLine();
        }
    }
}