using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int A = arr[0];
            int B = arr[1];

            int result = CountMartians(A, B);

            Console.WriteLine(result);
        }

        static int CountMartians(int minDigits, int maxDigits)
        {
            if (minDigits > maxDigits)
                return 0;

            int count = 0;

            for (int digits = minDigits; digits <= maxDigits; digits++)
            {
                count += 9 * (int)Math.Pow(10, digits - 1);
            }

            return count;
        }
    }
}
