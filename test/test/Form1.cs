using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            Bitmap image = new Bitmap(535, 271);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Black, 0, 0, 400,200);
            g.FillEllipse(Brushes.White, 100,0 , 200, 200); //(Pens.Red, 0, 0, 200, 200);
            pictureBox1.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
