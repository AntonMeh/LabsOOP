using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lab_5
{
     abstract class Figure
    {
        protected int coordinateX;
        protected int coordinateY;
        //protected int CircleCoordinateX;
        //protected int CircleCoordinateY;
        protected Graphics draw = Form.ActiveForm.CreateGraphics();

        public static int CircleCoordinateX { get; set; }
        public static int CircleCoordinateY { get; set; }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackground();
        public abstract Point[] GetVertices();

        public void MoveRight(int pixels)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < pixels; i++, coordinateX++, CircleCoordinateX++)
                {
                    DrawBlack();
                    Thread.Sleep(50);
                    HideDrawingBackground();
                }
            });
        }

        public bool IsInCircle()
        {
            foreach (var vertex in GetVertices())
            {
                double distance = Math.Sqrt(Math.Pow(vertex.X - CircleCoordinateX, 2) + Math.Pow(vertex.Y - CircleCoordinateY, 2));

                // Перевіряємо чи відстань до центру більше за радіус
                if (distance > 100)
                {
                    return false; // Якщо хоча б одна вершина за межами кола
                }
            }
            return true;
        }
    }
}
