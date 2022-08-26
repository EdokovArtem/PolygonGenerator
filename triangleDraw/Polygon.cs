using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace triangleDraw
{
    public partial class Polygon
    {
        public PointF[] points { get; private set; } = new PointF[3];
        public dynamic[] colors = new dynamic[4];
        public dynamic brush;
        public static int width = 10;
        public Pen pen = new Pen(Color.Black, width);
        
        
        public Polygon()
        {
            this.colors[0] = Brushes.Black;
            this.colors[1] = Brushes.Red;
            this.colors[2] = Brushes.Green;
            this.colors[3] = Brushes.Blue;
        }
        
        public void generate()
        {
            Random rand = new Random();
            this.brush = colors[rand.Next(0, 4)];
            for (int i = 0; i < 3; i++)
            {
                this.points[i] = new PointF((float)rand.Next(200, 800), (float)rand.Next(200, 400));
            }
            
        }
        
        public void draw(Graphics g)
        {

            g.FillPolygon(brush, points);
        }
    }
}
