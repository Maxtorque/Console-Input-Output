using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            string[] fiveNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
