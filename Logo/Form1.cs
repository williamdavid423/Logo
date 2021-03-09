using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 1);
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            g.Clear(Color.White);

            g.DrawEllipse(redPen, 160, 160, 180, 180);
            g.FillEllipse(RedBrush, 160, 160, 180, 180);

            g.DrawEllipse(redPen, 190, 190, 120, 120);
            g.FillEllipse(whiteBrush, 190, 190, 120, 120);

            g.DrawEllipse(redPen, 220, 220, 60, 60);
            g.FillEllipse(RedBrush, 220, 220, 60, 60);

            g.DrawString("TARGET", drawFont, RedBrush, 160, 355);


        }
    }
}
