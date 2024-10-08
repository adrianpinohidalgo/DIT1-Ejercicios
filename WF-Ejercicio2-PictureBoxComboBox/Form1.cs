using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ejercicio2_PictureBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            pictureBox1.Top -= 10;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 10;
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void btnMasAncho_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += 10;
        }

        private void btnMenosAncho_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= 10;
        }

        private void btnMasAlto_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += 10;
        }

        private void btnMenosAlto_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= 10;
        }
    }
}
