using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplusB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st;
            while ((st = Console.ReadLine()) != null)
            {
                int[] arr = st.Trim().Split().Select(int.Parse).ToArray();
                Console.WriteLine(arr[0] + arr[1]);
            }
        }
    }
}
