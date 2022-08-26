using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleDraw
{
    class Rectangle
    {
        private int x;
        private int y;
        private int height;
        private int width;
        public dynamic[] colors = new dynamic[4];
        public dynamic brush;

        public Rectangle()
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
            this.x = rand.Next(100, 800);
            this.y = rand.Next(200, 400);
            this.height = rand.Next(10, 200);
            if (this.x + this.height > 800)
            {
                this.x -= this.height;

            }
            this.width = rand.Next(10, 200);
            if (this.y + this.width > 400)
            {
                this.y -= this.width;
            }
        }
        public void draw(Graphics g)
        {
            g.FillRectangle(this.brush, this.x, this.y, this.height, this.width);
        }
    }
}
