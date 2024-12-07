using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_2
{
    public class MyFracClass
    {
        long nom, denom;

        public MyFracClass()
        {
            nom = 0; denom = 0;
        }
        public MyFracClass(long nom_, long denom_) {
            if (denom_ == 0)
                throw new ArgumentException("Знаменник не може дорівнювати нулю.");

            nom = denom_ < 0 ? -nom_ : nom_;
            denom = Math.Abs(denom_);
            Reduce();
        }
        private void Reduce()
        {
            long a = Math.Abs(nom);
            long b = Math.Abs(denom);
            long c = 0;

            while (a % b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            nom /= b;
            denom /= b;
        }
        public MyFracClass(MyFracClass other)
        {
            nom = other.nom;
            denom = other.denom;
        }
        public override string ToString()
        {
            return nom + "/" + denom;
        }
        public long Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public long Denom
        {
            get { return denom; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменник не може дорівнювати нулю.");
                }
                denom = value < 0 ? -value : value;
                nom =  -nom;
            }
        }
        
        public static string ToStringWithIntPart(MyFracClass f)
        {
            long wholePart = f.nom / f.denom;
            long remainder = f.nom % f.denom;

            if (f.nom < 0 && remainder == 0)
            {
                return $"-({Math.Abs(wholePart)})";
            }
            else if (f.nom > 0 && remainder == 0)
            {
                return $"({Math.Abs(wholePart)})";
            }
            else if (f.nom < 0 && wholePart != 0)
            {
                return $"-({Math.Abs(wholePart)} + {Math.Abs(remainder)}/{f.denom})";
            }
            else if (f.nom > 0 && wholePart != 0)
            {
                return $"({Math.Abs(wholePart)} + {Math.Abs(remainder)}/{f.denom})";
            }
            else if (f.nom > 0 && wholePart == 0)
            {
                return $"({Math.Abs(remainder)}/{f.denom})";
            }
            else
            {
                return $"-({Math.Abs(remainder)}/{f.denom})";
            }
            

        }
        public static double DoubleValue(MyFracClass f)
        {
            double result = (double)f.nom / f.denom;
            return result;
        }
        public static MyFracClass Plus(MyFracClass f1, MyFracClass f2)
        {
            return new MyFracClass(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFracClass Minus(MyFracClass f1, MyFracClass f2)
        {
            return new MyFracClass(f1.nom * f2.denom - f1.denom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFracClass Multiply(MyFracClass f1, MyFracClass f2)
        {
            return new MyFracClass(f1.nom * f2.nom, f1.denom * f2.denom);
        }
        public static MyFracClass Divide(MyFracClass f1, MyFracClass f2)
        {
            return new MyFracClass(f1.nom * f2.denom, f1.denom * f2.nom);
        }
        public void Input()
        {
            Console.WriteLine("Input values: ");
            long nom = long.Parse(Console.ReadLine());
            long denom = long.Parse(Console.ReadLine());

            if (denom == 0)
            {
                throw new ArgumentException("Знаменник не може дорівнювати нулю.");
            }
            if (denom < 0)
            {
                nom *= -1; denom *= -1;
                this.nom = nom;
                this.denom = denom;
            }
            else
            {
                this.nom = nom;
                this.denom = denom;
            }
            Reduce();
        }
        public static MyFracClass CalcExpr1(int n)
        {
            MyFracClass res = new MyFracClass(0, 1);
            for (int i = 1; i <= n; i++)
            {
                MyFracClass add = new MyFracClass(1, i * (i + 1));
                res = Plus(res, add);
            }
            return res;
        }
        public static MyFracClass CalcExpr2(int n)
        {
            MyFracClass res = new MyFracClass(1, 1);
            for (int i = 2; i <= n; i++)
            {
                MyFracClass add = new MyFracClass(1 - 1, i * i);
                res = Multiply(res, add);
            }
            return res;
        }
    }
}   

