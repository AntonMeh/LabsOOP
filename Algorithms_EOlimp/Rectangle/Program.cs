using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int[,] arr = new int[amount, 2];
            InputArray(arr);
            if (ISPosible(arr))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            

        }
        static int[,] InputArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = input[j];
                }
            }
            return arr;
        }
        static bool ISPosible(int[,] arr)
        {
            bool res = true;
            int maxFirst = Math.Max(arr[0, 0], arr[0, 1]);
            int minFirst = Math.Min(arr[0, 0], arr[0, 1]);

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                int maxNew = Math.Max(arr[i, 0], arr[i, 1]);
                int minNew = Math.Min(arr[i, 0], arr[i, 1]);

                if (maxNew <= maxFirst)
                {
                    maxFirst = maxNew;
                    minFirst = minNew;
                }

                else if (minNew <= maxFirst)
                {
                    maxFirst = minNew;
                    minFirst = maxNew;
                }

                else if ((maxNew > maxFirst) && (minNew > maxFirst))
                {
                    res = false;
                }
            }
            return res;

        }
    }
}
