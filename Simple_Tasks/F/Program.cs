using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F
{
    internal class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            for (long x = 1; x * x < n; x++)
            {
                long squared_y = n - x * x;
                long y = (long)Math.Sqrt(squared_y);

                if (squared_y == y * y)
                {
                    Console.WriteLine($"{x} {y}");
                }
            }
        }
    }
}
