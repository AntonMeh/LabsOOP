using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Rhomb : Figure
    {
        int horDiagLen;
        int vertDiagLength;

        public Rhomb(int coordinateX, int coordinateY, int horDiagLen, int vertDiagLength)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.horDiagLen = horDiagLen;
            this.vertDiagLength = vertDiagLength;
        }
        public override Point[] GetVertices()
        {
            return new Point[]
            {
                new Point(coordinateX, coordinateY - vertDiagLength / 2),
                new Point(coordinateX + horDiagLen / 2, coordinateY),
                new Point(coordinateX, coordinateY + vertDiagLength / 2),
                new Point(coordinateX - horDiagLen / 2, coordinateY)
            };
        }
        private Point[] DrawPentagon()
        {
            Point[] points = new Point[5];

            double angle = 72 * Math.PI / 180;

            for (int i = 0; i < 5; i++)
            {
                double x = coordinateX + 50 * Math.Cos(i * angle);
                double y = coordinateY + 50 * Math.Sin(i * angle);
                points[i] = new Point((int)x, (int)y);
            }
            return points;
        }
        public override void DrawBlack()
        {
            if (IsInCircle())
            {
                draw.FillPolygon(new SolidBrush(Color.Olive), DrawPentagon());
            }else
                draw.FillPolygon(new SolidBrush(Color.Olive), GetVertices());

        }
        public override void HideDrawingBackground()
        {
            if (IsInCircle())
            {
                draw.FillPolygon(new SolidBrush(Form1.DefaultBackColor), DrawPentagon());
            }
            else
            draw.FillPolygon(new SolidBrush(Form1.DefaultBackColor), GetVertices());
        }
       
    }
}
