using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAba_1
{
    class TTriangle
    {
        protected double side1;
        protected double side2;
        protected double side3;

        public TTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Сторони не повиннi бути вiдємними ");
            }
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else throw new ArgumentException("Такого трикутника не iснує :(");
        }
        public bool IsExist(double s1, double s2, double s3)
        {
            return (s1 < s2 + s3 && s2 < s1 + s3 && s3 < s1 + s2) ;
        } 
        public double Side1
        {
            get { return side1; }

            set {if(IsExist(value, side2, side3)) side1 = value; }
            
        }
        public double Side2
        {
            get { return side2; }

            set {if(IsExist(side1,value,side3)) side2 = value; }

        }
        public double Side3
        {
            get { return side3; }

            set {if(IsExist(side1, side2, value)) side3 = value; }

        }
        public double GetPerimeter()
        {
            return side1 + side2 + side3;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
}
