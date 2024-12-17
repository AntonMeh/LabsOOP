using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIMLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            string aStr = A.ToString();
            string bStr = B.ToString();

            int maxLength = Math.Max(aStr.Length, bStr.Length);
            aStr = aStr.PadLeft(maxLength, '0');
            bStr = bStr.PadLeft(maxLength, '0');

            string result = "";

            for (int i = 0; i < maxLength; i++)
            {
                int digitA = aStr[i] - '0';
                int digitB = bStr[i] - '0';
                int sum = digitA + digitB;
                result += sum.ToString();
            }

            Console.WriteLine(result); 
        }
    }
}
