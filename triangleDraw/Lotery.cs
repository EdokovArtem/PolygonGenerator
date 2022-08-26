using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading;

namespace triangleDraw
{
    class Lotery
    {
        private int[,] angles = { { 10, 100 }, { 600, 100 }, { 10, 400 }, { 600, 400 } };
        public dynamic[] colors = new dynamic[4];
        public dynamic brush;
        public Lotery()
        {
            this.colors[0] = Brushes.Black;
            this.colors[1] = Brushes.Red;
            this.colors[2] = Brushes.Green;
            this.colors[3] = Brushes.Blue;
        }
        public void start(Graphics g)
        {
            Random rand = new Random();
            for (int i = 0; i < 10;i++)
            {
                Thread.Sleep(100);
                this.brush = colors[rand.Next(0, 4)];
                g.FillRectangle(this.brush, angles[rand.Next(0, 4), 0], angles[rand.Next(0, 4), 1], 200, 200);
            }
        }
       
    }
}
