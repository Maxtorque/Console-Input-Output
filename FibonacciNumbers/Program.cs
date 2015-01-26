using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                numbers[i] = 0;
            }
            else if (i == 1)
            {
                numbers[i] = 1;
            }
            else
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }

            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
            }
        }
    }


