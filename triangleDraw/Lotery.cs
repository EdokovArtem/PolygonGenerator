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
        private PointF[,] points = new PointF[4, 3];
        private PointF[] pointsNow = new PointF[3];
        private int a;
        public dynamic[] colors = new dynamic[4];
        public dynamic brush;
        private double figure;
        public Lotery()
        {
            this.points[0, 0] = new PointF(10.0f,100.0f);
            this.points[0, 1] = new PointF(10.0f,300.0f);
            this.points[0, 2] = new PointF(210.0f,100.0f);

            this.points[1, 0] = new PointF(600.0f,100.0f);
            this.points[1, 1] = new PointF(800.0f,100.0f);
            this.points[1, 2] = new PointF(800.0f,300.0f);

            this.points[2, 0] = new PointF(10.0f,400.0f);
            this.points[2, 1] = new PointF(210.0f,600.0f);
            this.points[2, 2] = new PointF(10.0f,600.0f);

            this.points[3, 0] = new PointF(800.0f,600.0f);
            this.points[3, 1] = new PointF(600.0f,600.0f);
            this.points[3, 2] = new PointF(800.0f,400.0f);


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
                figure = rand.NextDouble();
                if (figure < 0.5)
                {
                    g.FillRectangle(this.brush, angles[rand.Next(0, 4), 0], angles[rand.Next(0, 4), 1], 200, 200);
                }
                else
                {
                    a = rand.Next(0, 4);
                    for (int l = 0;l < 3; l++)
                    {
                        pointsNow[l] = points[a, l]; 
                    }
                    g.FillPolygon(this.brush,pointsNow );
                }
                
            }
        }
    }
}
