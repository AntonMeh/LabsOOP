using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
     
            Console.WriteLine(CountMinAmountBanknote(n));
        }
        static int CountMinAmountBanknote(int n)
        {
            int count = 0;
            if (n % 10 == 0 && n > 0)
            {
                    while (n >=500)
                    {
                        n -= 500;
                        count++;
                    }
                    while (n >= 200)
                    {
                        n -= 200;
                        count++;
                    }
                    while (n >= 100)
                    {
                        n -= 100;
                        count++;
                    }
                    while (n >= 50)
                    {
                        n -= 50;
                        count++;
                    }
                    while (n >= 20)
                    {
                        n -= 20;
                        count++;
                    }
                    while (n >= 10)
                    {
                        n -= 10;
                        count++;
                    }
                
            }else
            count = -1;

           return count;
        }
    }
}
