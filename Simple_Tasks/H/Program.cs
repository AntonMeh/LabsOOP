using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H
{
    internal class Program
    {
        static bool IsPrimeNumber(long number, List<int> smallPrimes)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 0; i < smallPrimes.Count; i++)
            {
                if ((long)smallPrimes[i] * smallPrimes[i] > number) break;
                if (number % smallPrimes[i] == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            int SQRT_MAX = 3162277;
            List<int> smallPrimes = new List<int>();
            bool[] sieve = new bool[SQRT_MAX + 1];
            for (int i = 2; i <= SQRT_MAX; i++)
            {
                sieve[i] = true;
            }

            for (int i = 2; i <= SQRT_MAX; i++)
            {
                if (sieve[i])
                {
                    smallPrimes.Add(i);
                    for (long j = (long)i * i; j <= SQRT_MAX; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);

            for (long i = a; i <= b; i++)
            {
                if (IsPrimeNumber(i, smallPrimes))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
