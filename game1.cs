using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1Form
{
    public partial class game1 : Form
    {
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool isDrawing = false;
        public game1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(panel2.BackColor);
            myGraphics = panel1.CreateGraphics();
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
                myBrush.Color = panel2.BackColor;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paint for Igloo project", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Choose the size of the brush in the Track Bar.\n2. Choose the color in the color box.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
