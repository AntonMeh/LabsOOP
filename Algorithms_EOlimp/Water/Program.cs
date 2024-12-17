using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n_k = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int[] buckets = new int[n_k[0]];
            buckets = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int times = HowMuchTimes(buckets, n_k[1]);
            if (times == 0)
                Console.WriteLine("Impossible");
            else Console.WriteLine(times);
        }
        static int HowMuchTimes(int[] arr, int max) {

            int count = 0;
            int left = 0;
            int right = arr.Length - 1;

            Array.Sort(arr);

            if (arr[right] > max)
                return 0;

            while (left <= right)
            {
                if (left == right)
                {
                    count++;
                    break;
                }
                if (arr[left] + arr[right] <= max)
                {
                    count++;
                    left++;
                    right--;
                }
                else
                {
                    count++;
                    right--;
                }
               
            }
                       
            return count;
        }
    }
}
