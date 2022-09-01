using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas_Botones_3321IS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MOSTRAR_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Visible = true;
            btn_MOSTRAR.Enabled = false;


        }

        private void btn_MouseEnter_MouseEnter(object sender, EventArgs e)
        {
            lbl_mensaje.Visible = true;
        }


        private void btn_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_MouseDown.Visible = true;
        }

        private void btn_MouseEnter_MouseLeave(object sender, EventArgs e)
        {
            lbl_mensaje.Visible = false;
        }

        private void btn_MouseHover_MouseHover(object sender, EventArgs e)
        {
            lbl_MouseDown.Visible = false;

        }

        private void btn_MouseDown_MouseUp(object sender, MouseEventArgs e)
        {
            lbl_MouseDown.Visible = false;
        }

        private void btn_MouseMove_MouseMove(object sender, MouseEventArgs e)
        {
            btn_MouseMove.BackColor = Color.Chocolate;
        }
    }
}
