using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            while (a.CompareTo(b) == 1)
            {
                Console.WriteLine("{0} is greater", a);
                break;
            }
            while (a.CompareTo(b) == -1)
            {
                Console.WriteLine("{0} is greater", b);
                break;
            }
            while (a.CompareTo(b) == 0)
            {
                Console.WriteLine("{0} == {1}", a, b);
                break;
            }
        }
    }
}
