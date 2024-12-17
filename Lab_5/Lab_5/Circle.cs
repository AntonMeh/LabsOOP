using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Circle : Figure
    {
        int radius;

        public Circle(int CircleX, int CircleY, int size)
        {
            CircleCoordinateX = CircleX;
            CircleCoordinateY = CircleY;
            radius = size;
        }
        public override void DrawBlack()
        {
            draw.DrawEllipse(Pens.Black, GetCurrPoints());
        }
        public override void HideDrawingBackground()
        {
            draw.DrawEllipse(new Pen(Form1.DefaultBackColor), GetCurrPoints());
        }
        private Rectangle GetCurrPoints()
        {
            return new Rectangle(CircleCoordinateX - radius, CircleCoordinateY - radius, radius * 2, radius * 2);
        }

         public override Point[] GetVertices()
        {
            return new Point[]
            {
                new Point(CircleCoordinateX, CircleCoordinateY)
            };
        }
    }
}
