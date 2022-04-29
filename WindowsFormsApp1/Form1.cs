using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float x1, y1, x2, y2;
        private Pen pen = new Pen(Color.LightBlue, 2);
        private void Form1_Load(object sender, EventArgs e)
        {
            y1 = 0;
            x1 = ClientSize.Height / 2;

            y2 = y1;
            x2 = x1 + 100 * (float)Math.Sin(y2 * Math.PI / 180);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen,x2,y2-15,x2,y2+15);
            g.DrawLine(pen, x2-15, y2 , x2+15, y2 );
            g.DrawLine(pen, x2-9, y2 - 9, x2+9, y2 + 9);
            g.DrawLine(pen, x2-9, y2 +9, x2+9, y2 - 9);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y1 += 1;
            y2 = y1;
            if (y2 == 600)
                y1 = 0;
            else
                x2 = x1 + 100 * (float)Math.Sin(y2 * Math.PI / 180);
            Invalidate();
        }

        
        
    }
    
}
