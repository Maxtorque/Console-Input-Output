using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividableGivenNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first positive integer number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second positive integer number: ");
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                int temp = first;
                first = second;
                second = temp;
            }

            int count = 0;
            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Exactly {0} numbers exist between them.", count);
        }
    }
}
