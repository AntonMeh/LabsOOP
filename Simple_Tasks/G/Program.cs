using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int a = arr[0];
            int b = arr[1];
            int k = arr[2];

            int counter = 0;

            for (int i = (int)Math.Ceiling(Math.Sqrt(a)); i *i <= b; i++)
            {
                int square = a * a;
                if (isSumOfDigitsDividedByK(i*i,k))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static bool isSumOfDigitsDividedByK(int number, int k)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % k == 0;
        }
    }
}
