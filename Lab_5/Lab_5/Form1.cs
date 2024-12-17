using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        Random rs = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = rs.Next(100,600);
            int y = rs.Next(100,300);
            Circle ellipse = new Circle(100, 100, 80);
            ellipse.MoveRight(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = rs.Next(20, 600);
            int y = rs.Next(20, 300);
            Rhomb rhomb = new Rhomb(100, 100, 60,80);
            rhomb.MoveRight(20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = rs.Next(40, 500);
            int y = rs.Next(40, 300);
            Square sq = new Square(x,y,40);
            sq.MoveRight(20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }
    }
}
