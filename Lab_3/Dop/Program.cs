using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { };

            Stack<int> stack = new Stack<int>(arr);

            try
            {
                stack.Clear();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("a");
            }

        }
    }
}
