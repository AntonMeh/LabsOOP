using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (int i = arr[0]; i <= arr[1]; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        public static bool IsPrimeNumber(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            long sqrt = (long)Math.Sqrt(n);
            for (long i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
