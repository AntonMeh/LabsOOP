using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAba_1
{
    
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Ввеiть 3 сторони трикутника через пробiл :)");
            double[] arr = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();

            try
            {
                TTriangle triangle = new TTriangle(arr[0], arr[1], arr[2]);
                Console.Write("Периметр цього трикутника: " + triangle.GetPerimeter());
                Console.WriteLine();
                Console.Write("Площа цього трикутника: " + triangle.GetArea());
                Console.ReadKey();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return;
            }    
  
        }
    }
}
