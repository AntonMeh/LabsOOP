using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab_4
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
         BigInteger nom;
         BigInteger denom;

        public MyFrac()
        {
            nom = 1; denom = 1;
        }
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom == 0)
                throw new ArgumentException("The denominator cannot be zero");

            this.denom = denom;
            this.nom = nom; 
            Reduce();
        }
        public MyFrac(long nom, long denom)
        {
            if (denom == 0)
                throw new ArgumentException("The denominator cannot be zero");

            this.nom = nom;
            this.denom = denom;
            Reduce();
        }
        public MyFrac(int nom, int denom)
        {
            if (denom == 0)
                throw new ArgumentException("The denominator cannot be zero");

            this.nom = nom;
            this.denom = denom;
            Reduce();
        }
        private void Reduce()
        {
            int a = Math.Abs((int)nom);
            int b = Math.Abs((int)denom);
            int c = 0;

            while (a % b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            nom /= b;
            denom /= b;
        }
        public MyFrac Add(MyFrac another)
        {
            return new MyFrac(nom * another.denom + denom * another.nom, denom * another.denom);
        }
        public MyFrac Subtract(MyFrac another)
        {
            return new MyFrac(nom * another.denom - denom * another.nom, denom * another.denom);
        }
        public MyFrac Multiply(MyFrac another)
        {
            return new MyFrac(nom * another.nom, denom * another.denom);
        }
        public MyFrac Divide(MyFrac another)
        {
            try
            {
                return new MyFrac(nom * another.denom, denom * another.nom);
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("Attempt to divide by zero");
            }
        }
        public override string ToString()
        {
            return nom + "/" + denom;
        }

        public int CompareTo(MyFrac another)
        {
            if (another == null)
                throw new ArgumentNullException(nameof(another));

            BigInteger leftSide = nom * another.denom;
            BigInteger rightSide = another.nom * denom;

            return leftSide.CompareTo(rightSide);
        }
    }
}
