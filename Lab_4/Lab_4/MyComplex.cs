using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class MyComplex : IMyNumber<MyComplex>
    {
        private double re;
        public double im;
        public MyComplex(double real, double imaginary)
        {
            re = real;
            im = imaginary;
        }
        public MyComplex()
        {
            re = 3.14;
            im = -1;
        }

        public MyComplex Add(MyComplex another)
        {
            return new MyComplex(re + another.re, im + another.im);
        }

        public MyComplex Subtract(MyComplex another)
        {
            return new MyComplex(re - another.re, im - another.im);
        }

        public MyComplex Multiply(MyComplex another)
        {
            return new MyComplex(re * another.re - im * another.im,re * another.im + im * another.re);
        }

        public MyComplex Divide(MyComplex another)
        {
            double denom = Math.Pow(another.re, 2) + Math.Pow(another.im, 2);

            return new MyComplex((re * another.re + im * another.im) / denom,(im * another.re - re * another.im) / denom);
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
