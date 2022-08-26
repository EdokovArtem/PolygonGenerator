using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangleDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Polygon triangle = new Polygon();
        Rectangle rect = new Rectangle();
        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            triangle.generate();
            triangle.draw(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            rect.generate();
            rect.draw(g);
        }
    }
}
