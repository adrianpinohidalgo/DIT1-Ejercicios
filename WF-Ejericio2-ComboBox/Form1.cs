using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ejericio2_ComboBox
{
    public partial class Form1 : Form
    {
        public string[] windows = new string[] { "MS Office", "MS Visual Studio", "MS Dynamics" };
        public string[] linux = new string[] { "Libre Office", "GNU GCC", "Apache" };
        public string[] mac = new string[] { "iWork", "Xcode", "Light Speed" };

        public Form1()
        {
            InitializeComponent();
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            cbSoftware.SelectedIndex = -1;
            cbSoftware.Items.Clear();
            cbSoftware.Items.AddRange(windows);
        }

        private void rbLinux_CheckedChanged(object sender, EventArgs e)
        {
            cbSoftware.SelectedIndex = -1;
            cbSoftware.Items.Clear();
            cbSoftware.Items.AddRange(linux);
        }

        private void rbMac_CheckedChanged(object sender, EventArgs e)
        {
            cbSoftware.SelectedIndex = -1;
            cbSoftware.Items.Clear();
            cbSoftware.Items.AddRange(mac);
        }

        private void cbSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoftware.SelectedIndex != -1)
                MessageBox.Show("SO seleccionado: " + rbWindows.Text + " | Software seleccionado: " + cbSoftware.Text);
        }
    }
}
