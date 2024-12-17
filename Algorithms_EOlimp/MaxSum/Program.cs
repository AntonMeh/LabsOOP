using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[,] arr = new int[dimensions[0], dimensions[1]];
            InputArray(arr);           
            Console.WriteLine(FindMaxSum(arr));

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
        static int FindMaxSum(int[,] arr)
        {
            
            int maxSum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i, 0];
                for (int j = 1; j < arr.GetLength(1); j++) 
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j]; 
                    }
                }
                maxSum += max;   
            }

            return maxSum;
        }
    }
}
