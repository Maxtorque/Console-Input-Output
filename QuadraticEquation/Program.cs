using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            
            double a, b, c, discriminant, x1, x2;
            Console.Write("Enter the first coefficient a:");
            bool isaDouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second coefficients b:");
            bool isbDouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the third coefficients c:");
            bool iscDouble = double.TryParse(Console.ReadLine(), out c);
            if (isaDouble & isbDouble & iscDouble)
            {
                discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    x2 = (b + Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine("The real roots are:");
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                }
                else
                {
                    Console.WriteLine("There are no real roots!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
            }
        }
    }
}
