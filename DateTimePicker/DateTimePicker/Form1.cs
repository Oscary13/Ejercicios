using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            lblFecha.Text = fecha.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dias = Convert.ToInt32(txtDias.Text);
            dateTimePicker1.Value = DateTime.Today.AddDays(dias);

        }
    }
}
