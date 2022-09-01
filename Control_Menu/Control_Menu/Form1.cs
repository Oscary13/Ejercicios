using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Menu
{
    public partial class from_Calculadora_menu : Form
    {
        public from_Calculadora_menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_A.Text);
            double b = Convert.ToDouble(txt_B.Text);
            double r = a + b;
            lbl_Resultado.Text = r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_A.Text);
            double b = Convert.ToDouble(txt_B.Text);
            double r = a - b;
            lbl_Resultado.Text = r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_A.Text);
            double b = Convert.ToDouble(txt_B.Text);
            double r = a * b;
            lbl_Resultado.Text = r.ToString();
        }

        private void diviciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_A.Text);
            double b = Convert.ToDouble(txt_B.Text);
            double r = a / b;
            lbl_Resultado.Text = r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txt_A.Enabled = habilitarToolStripMenuItem.Checked;
            txt_B.Enabled = habilitarToolStripMenuItem.Checked;
        }
    }
}
