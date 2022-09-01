using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Formulario_3321IS
{
    public partial class Form_Escuela : Form
    {
        public Form_Escuela()
        {
            InitializeComponent();
        }

        private void cbx_aleman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_costo_Click(object sender, EventArgs e)
        {
            int costo = 0;
            if (cbx_ingles.Checked==true)
            {
                costo = costo + 200;
            }
            if (cbx_frances.Checked == true)
            {
                costo = costo +300;
            }
            if (cbx_aleman.Checked == true)
            {
                costo = costo + 250;
            }
            if (cbx_chinoma.Checked == true)
            {

            }
            string turno = "";
            if (rbt_Matutino.Checked == true)
            {
                turno = rbt_Matutino.Text;
            }
            else if (rbt_Vespertino.Checked == true)
            {
                turno = rbt_Vespertino.Text;

            }
            else if (rbt_Sabatino.Checked == true)
            {
                turno = rbt_Sabatino.Text;
            }
            else
            {
                MessageBox.Show($"Alumno:" + txt_nombre + "No elegiste ningun Turno :");
                limpiar();
            }

            if (costo == 0)
            {
                MessageBox.Show($"Alumno:" + "txt_nombre" + "No elegiste ningun curso :");
            }
            else
            {
                lbl_costo.Text = $"EL COSTO DE LOS CURSOS SELECCIONADOS ES:  ${costo}   Turno: {turno}" ;
            }
          
            
        }
        public void limpiar()
        {
            txt_nombre.Text = "";
            cbx_aleman.Checked = false;
            cbx_chinoma.Checked = false;
            cbx_frances.Checked = false;
            cbx_ingles.Checked = false;
            lbl_costo.Text = "";
            rbt_Matutino.Checked = false;
            rbt_Vespertino.Checked = false;
            rbt_Sabatino.Checked = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ingresatunombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Limpia tus controles");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void lbl_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbx_cursos_Enter(object sender, EventArgs e)
        {

        }
    }
}
