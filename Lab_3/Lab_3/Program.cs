using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine(FileReafder());
            Console.ReadLine();
        }

        static double FileReafder()
        {
            int mul = 0;
            int sum = 0;
            int counter = 0;
            double res = 0;

            var allFiles = Directory.GetFiles("./BadFiles");
            foreach (var file in allFiles)
            {
                File.Delete(file);
            }

             for (int i = 10; i < 30; i++)
             {
                 string addres = $"./files/{i}.txt";
                 try
                 {
                     var fil = new FileStream(addres, FileMode.Open);
                     StreamReader sr = new StreamReader(fil);
                     int n1 = int.Parse(sr.ReadLine());
                     int n2 = int.Parse(sr.ReadLine());
                     fil.Close();
                     sr.Close();
                     checked
                     {
                         mul = n1 * n2;
                         sum += mul;
                         counter++;
                     }
                    res = sum / counter;
                }
                catch (ArgumentNullException)
                 {
                     AppendLog("bad_data", addres);

                 }
                 catch (OverflowException)
                 {
                     AppendLog("overflow", addres);
                 }
                 catch (FormatException)
                 {
                     AppendLog("bad_data", addres);

                 }
                 catch (FileNotFoundException)
                 {
                     AppendLog("no_file", addres);

                 }
                catch (DivideByZeroException)
                {
                    throw new Exception("Dividing by zero");
                }
            }
            
            return res;
        }
        static void AppendLog(string name, string addres)
        {
            try
            {
                FileStream creator = new FileStream($"./BadFiles/{name}.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(creator);
                sw.WriteLine(Path.GetFileName(addres));
                sw.Close();
                creator.Close();
            }
            catch (Exception)
            {
                System.Console.WriteLine($"Couldn't create or update {name}.txt file");
            }
        }
    }
}
