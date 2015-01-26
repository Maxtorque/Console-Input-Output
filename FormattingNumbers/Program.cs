using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter integer \"a\": ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter double \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter double \"c\": ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("{0,-1:X}", a);
            Console.Write(" |" + Convert.ToString(a, 2).PadLeft(10, '0') + "| ");
            Console.Write("{0,1:F2}|", b);
            Console.Write("{0,-1:F3} |", c);
            Console.WriteLine();
        }
    }
}
