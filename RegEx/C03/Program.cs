using System;
using System.IO;

namespace RegExLab_C03
{
    class Program
    {
        static String searchPatt = @"\$v_([a-zA-Z0-9])\$";
        static String replacePatt = "v[$1]";
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            while (str != null)
            {
                String newStr = System.Text.RegularExpressions.Regex.Replace(str, searchPatt, replacePatt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }
    }
}