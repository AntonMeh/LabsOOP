using System;
using System.IO;

namespace RegExLab_F06
{
    class Program
    {
        static String searchPatt = @"(\b[A-Z][a-zA-Z]*\b(?:\s+\b[A-Z][a-zA-Z]*\b){2,})\b";
        static String replacePatt = "\"$1\"";
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
