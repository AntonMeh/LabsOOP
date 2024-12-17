using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] platforms = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (n == 2)
            {
                Console.WriteLine(Math.Abs(platforms[1] - platforms[0]));
                Console.WriteLine(2);
                Console.WriteLine("1 2");
            }
            else
            {
                int[] result = new int[n];
                int[] previousPlatforms = new int[n];

                result[1] = Math.Abs(platforms[1] - platforms[0]);
                previousPlatforms[1] = 0;

                for (int i = 2; i < n; i++)
                {
                    int stepOne = Math.Abs(platforms[i] - platforms[i - 1]) + result[i - 1];
                    int stepTwo = 3 * Math.Abs(platforms[i] - platforms[i - 2]) + result[i - 2];

                    if (stepOne <= stepTwo)
                    {
                        result[i] = stepOne;
                        previousPlatforms[i] = i - 1;
                    }
                    else
                    {
                        result[i] = stepTwo;
                        previousPlatforms[i] = i - 2;
                    }
                }

                List<int> path = new List<int>();
                int current = n - 1;

                while (current > 0)
                {
                    path.Add(current + 1);
                    current = previousPlatforms[current];
                }
                path.Add(1);
                path.Reverse();

                Console.WriteLine(result[n - 1]);
                Console.WriteLine(path.Count);
                Console.WriteLine(string.Join(" ", path));
            }
        }
    }
}
