using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            T deb = curr.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            Console.WriteLine("a^3 = " + deb);

            T wholeRightPart = curr;
            T whole = deb;
            curr = a.Multiply(b);  // ab
            curr = curr.Add(curr); // ab + ab = 2ab
                                   // I’m not sure how to create constant factor "2" in more elegant way,
                                   // without knowing how IMyNumber is implemented
            whole = whole.Add(deb.Multiply(b));
            whole = whole.Add(whole.Add(whole));
            Console.WriteLine("3a^2b = " + whole);
            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            deb = curr.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            Console.WriteLine("b^3 = " + deb);
            wholeRightPart = wholeRightPart.Add(curr);
            whole = whole.Add(deb.Multiply(a));
            whole = whole.Add(whole.Add(whole));
            Console.WriteLine("3a^2b+ 3ab^2 = " + whole);
            whole = whole.Add(deb);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine(" a^3 + 3a^2b + 3ab^2 + b^3 = " + whole);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }

        static void Main()
        {
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            MyFrac a = new MyFrac(1, 3);
            MyFrac b = new MyFrac(1, 6);
            MyFrac c = new MyFrac(1, 2);
            MyFrac[] myFracs = [a, b, c];
            Array.Sort(myFracs);
            foreach (var item in myFracs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

            IDriveable car = new Car();
            IDriveable bike = new Bike();

            Console.WriteLine("Тест-драйв автомобіля:");
            TestDrive(car);

            Console.WriteLine("Тест-драйв велосипеда:");
            TestDrive(bike);
        }
        public static void TestDrive(IDriveable vehicle)
        {
            vehicle.Drive();
        }
    }
}
