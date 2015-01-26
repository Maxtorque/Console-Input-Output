using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOneToN
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Enter the first number n:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);

            if (isnInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! n is not an integer!");
            }
        }
    }
}
