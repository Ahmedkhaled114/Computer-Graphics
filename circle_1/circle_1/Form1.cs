using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace circle_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(1200, 600);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Black, 0, 0,1200,600);
            g.DrawEllipse(Pens.White,600-150,300-150  , 300, 300);

            g.DrawEllipse(Pens.White, 600 - 150 - 45,300-45, 90,90);
            g.DrawEllipse(Pens.White, 600 + 150 - 45 , 300 - 45, 90, 90);
            g.DrawEllipse(Pens.White, 600 - 45 , 300 - 150 - 45, 90, 90);
            g.DrawEllipse(Pens.White, 600 - 45 , 300 + 150 - 45, 90, 90);

            g.DrawEllipse(Pens.White, 600 + 106 - 45, 300 - 106 - 45, 90, 90);
            g.DrawEllipse(Pens.White, 600 - 106 - 45, 300 - 106 - 45, 90, 90);
            g.DrawEllipse(Pens.White, 600 + 106 - 45, 300 + 106 - 45, 90, 90);
            g.DrawEllipse(Pens.White, 600 - 106 - 45, 300 + 106 - 45, 90, 90);


            pictureBox1.Image = image;

        }
    }
}
