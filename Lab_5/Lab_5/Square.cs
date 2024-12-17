using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Square : Figure
    {
        int sideLength;

        public Square(int centerX, int centerY, int size)
        {
            coordinateX = centerX;
            coordinateY = centerY;
            sideLength = size;
        }
        public override Point[] GetVertices()
        {
            return new Point[] {
                new Point(coordinateX - sideLength,  coordinateY - sideLength),
                new Point(coordinateX - sideLength,  coordinateY + sideLength),
                new Point(coordinateX + sideLength,  coordinateY + sideLength),
                new Point(coordinateX + sideLength,  coordinateY - sideLength),
           };
        }
        private Point[] GetCurrPointsStar()
        {
            int outerRadius = 50;
            int innerRadius = 25;

            int pointsCount = 10; 
            Point[] points = new Point[pointsCount];

            double angleStep = Math.PI / 5; 

            for (int i = 0; i < pointsCount; i++)
            {
                int radius = (i % 2 == 0) ? outerRadius : innerRadius; 
                double angle = i * angleStep;

                int x = coordinateX + (int)(radius * Math.Sin(angle));
                int y = coordinateY - (int)(radius * Math.Cos(angle)); 

                points[i] = new Point(x, y);
            }

            return points;
        }
        public override void DrawBlack()
        {
            if (IsInCircle()) 
            { 
                draw.FillPolygon(new SolidBrush(Color.Red), GetCurrPointsStar());
            }
            else
            draw.FillPolygon(new SolidBrush(Color.Red), GetVertices());
        }

        public override void HideDrawingBackground()
        {
            if (IsInCircle())
            {
                draw.FillPolygon(new SolidBrush(Form1.DefaultBackColor), GetCurrPointsStar());
            }
            else
                draw.FillPolygon(new SolidBrush(Form1.DefaultBackColor), GetVertices());
        }
    }
}
