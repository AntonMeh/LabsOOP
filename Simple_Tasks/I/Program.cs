using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> platforms = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.WriteLine(Math.Abs(platforms[1] - platforms[0]));
            }
            else
            {
                int[] result = new int[n];

                result[1] = Math.Abs(platforms[1] -platforms[0]);

                for (int i = 2; i < n; i++)
                {
                    int firstStep = Math.Abs(platforms[i] - platforms[i - 1]) + result[i - 1];
                    int secondStep = 3 * Math.Abs(platforms[i] - platforms[i - 2]) + result[i - 2];

                    result[i] = Math.Min(firstStep, secondStep);
                }

                Console.WriteLine(result[n - 1]);
            }
        }
    }
}
