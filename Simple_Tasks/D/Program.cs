using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "ADD")
                {
                    set.Add(input[1]);
                }
                if (input[0] == "PRESENT")
                {
                    if (set.Contains(input[1]))
                    {
                        Console.WriteLine("YES");
                    }else { Console.WriteLine("NO"); }
                    
                }
                if (input[0] == "COUNT")
                {
                    Console.WriteLine(set.Count);
                }
            }
        }
    }
}
