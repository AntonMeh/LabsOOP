using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] rowInput = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = rowInput[j];
                }
            }

            if (n == 1)
            {
                Console.WriteLine(matrix.Cast<int>().Max());
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j == 0 && j < m - 1)
                        {
                            matrix[i, j] += Math.Max(matrix[i - 1, j], matrix[i - 1, j + 1]);
                        }
                        else if (j == 0 && j == m - 1)
                        {
                            matrix[i, j] += matrix[i - 1, j];
                        }
                        else if (j == m - 1 && j > 0)
                        {
                            matrix[i, j] += Math.Max(matrix[i - 1, j], matrix[i - 1, j - 1]);
                        }
                        else if (j == m - 1 && j == 0)
                        {
                            matrix[i, j] += matrix[i - 1, j];
                        }
                        else
                        {
                            matrix[i, j] += Math.Max(matrix[i - 1, j], Math.Max(matrix[i - 1, j - 1], matrix[i - 1, j + 1]));
                        }
                    }
                }

                Console.WriteLine(matrix.Cast<int>().Skip((n - 1) * m).Max());
            }
        }
    }
}
