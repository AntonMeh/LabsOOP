using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    internal class Program
    {
        static void Main()
        {
            SortedDictionary<int, int> triangle = new SortedDictionary<int, int>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == null) break;

                string[] input = inputLine.Split();

                if (input[0] == "ADD")
                {
                    int num = int.Parse(input[1]);
                    if (triangle.ContainsKey(num))
                    {
                        triangle[num]++;
                    }
                    else
                    {
                        triangle[num] = 1;
                    }
                }
                else if (input[0] == "CLEAR")
                {
                    triangle.Clear();
                }
                else if (input[0] == "EXTRACT")
                {
                    if (triangle.Count > 0)
                    {
                        int maxKey = triangle.Keys.Max();
                        Console.WriteLine(maxKey);
                        if (triangle[maxKey] == 1)
                        {
                            triangle.Remove(maxKey);
                        }
                        else
                        {
                            triangle[maxKey]--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("CANNOT");
                    }
                }
            }
        }
    }
}
