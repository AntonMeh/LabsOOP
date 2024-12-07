using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose prog 1 - Matrix 2 - My Frac: ");
            string decision = Console.ReadLine();

            switch (decision)
            {
                case "1":
                    MyMatrixProg();
                    break;
                
                case "2":
                    MyFracProg();
                    break;
            }
            
            
            
        }
        static void MyFracProg()
        {
            Console.WriteLine("Введіть два дроби чисельник знаменни, кожен в окремому рядку");

            MyFracClass calc1 = new MyFracClass();
            calc1.Input();
            MyFracClass calc2 = new MyFracClass();
            calc2.Input();

            Console.WriteLine("Формування рядкового подання дробу з видiленою цiлою частиною");
            Console.WriteLine($"{MyFracClass.ToStringWithIntPart(calc1)} {MyFracClass.ToStringWithIntPart(calc2)}");
            Console.WriteLine("Формування дiйсного значення дробу");
            Console.WriteLine($"{MyFracClass.DoubleValue(calc1)} {MyFracClass.DoubleValue(calc2)}");
            Console.WriteLine("Сума дробiв:");
            Console.WriteLine($"{MyFracClass.Plus(calc1, calc2)}");
            Console.WriteLine("Рiзниця дробiв:");
            Console.WriteLine($"{MyFracClass.Minus(calc1, calc2)}");
            Console.WriteLine("Добуток дробiв");
            Console.WriteLine($"{MyFracClass.Multiply(calc1, calc2)}");
            Console.WriteLine("Частка дробiв");
            Console.WriteLine($"{MyFracClass.Divide(calc1, calc2)}");

            Console.WriteLine("Введiть n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("CalcExpr1:");
            Console.WriteLine($"{MyFracClass.CalcExpr1(n)}");
            Console.WriteLine("CalcExpr2:");
            Console.WriteLine($"{MyFracClass.CalcExpr2(n)}");
        }
        static void MyMatrixProg()
        {
            MyMatrix matr = new MyMatrix(new double[,] { { 12, 123, 4, 1 }, { 5, 13, 435, 32 }, { 2, 12, 43, 9 }, { 543, 212, 65, 5 } });

            double[][] jagMatr = new double[][] { new double[] {  3,20, 69 }, new double[] { 0, 64, 27 }, new double[] { 3, 41, 5 } };
            MyMatrix jagMatrix = new MyMatrix(jagMatr);
            Console.WriteLine("Matrix from jagged array:");
            Console.WriteLine(jagMatrix);
            Console.WriteLine(jagMatrix.DetermineTheMatrixType());


            //string str = "    1   2 3    1\n 12 32    11 4\n 456 454    54 1\n 2\t12\t3\t11\n";
            //MyMatrix testStr = new MyMatrix(str);
            //Console.WriteLine("Matrix from string:");
            //Console.WriteLine(testStr);

            //Console.WriteLine("Sum of string array & MyMatrix array:");
            //MyMatrix sumMatrix = matr + testStr;
            //Console.WriteLine(sumMatrix);

            //Console.WriteLine("Multiplying of string array & MyMatrix array:");
            //MyMatrix multiMatrix = matr * testStr;
            //Console.WriteLine(multiMatrix);

            //Console.WriteLine("Matrix before transpose:");
            //Console.WriteLine(matr);
            //Console.WriteLine("Transposed matrix:");
            //MyMatrix trans = matr.GetTransponedCopy();
            //Console.WriteLine(trans);

            string[] validArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                validArray[i] = Console.ReadLine();
            }
            MyMatrix sass = new MyMatrix(validArray);
            Console.WriteLine("Matrix from an array of strings");
            Console.WriteLine(sass.ToString());
            Console.WriteLine("Determinant:");
            Console.WriteLine(sass.DetermineTheMatrixType());
            Console.WriteLine(sass.CalcDeterminant());
        }
    }
    



}
