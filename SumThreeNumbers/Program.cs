using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.Write("Enter the first number a:");
            bool isaInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbInt = int.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the third number c:");
            bool iscInt = int.TryParse(Console.ReadLine(), out c);

            if (isaInt & isbInt & iscInt)
            {
                Console.WriteLine("sum={0}", a + b + c);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not integer!");
            }
        }
    }
}
