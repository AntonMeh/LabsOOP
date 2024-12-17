using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_EOlimp
{
    internal class Number
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            if (num.Length > 2 || num.Length < 1000000)
            {
                string maxNum = FindMaxNumberAfterRemove(num);
                Console.WriteLine(maxNum);
            }
            
        }

        static string FindMaxNumberAfterRemove(string num)
        {
            StringBuilder maxNum = new StringBuilder(num);

            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] < num[i + 1])
                {
                    maxNum.Remove(i, 1);
                    return maxNum.ToString();
                }
            }
            maxNum.Remove(num.Length - 1, 1);
            return maxNum.ToString();
        }

    }
}
