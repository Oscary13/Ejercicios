using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class EMPLEADO : Form
    {
        
        public EMPLEADO()
        {
            InitializeComponent();
        }

        private void EMPLEADO_Load(object sender, EventArgs e)
        {
            cbo_Genero.Items.Add("Masculino");
            cbo_Genero.Items.Add("Femenino");
            

        }

        private void lbl_Apellidim_e_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
           

            lst_EmpleadosRegistrados.Items.Add(txtNombre.Text.Trim());
            lst_ApellidoP.Items.Add(txt_Apellidop.Text.Trim());
            lst_ApellidoM.Items.Add(txt_Apellidom.Text.Trim());
            lst_Direccion.Items.Add(txtDireccion.Text.Trim());
            if (cbo_Genero.SelectedIndex == 0)
            {
                lst_Genero.Items.Add("Masculino");

            }
            else if (cbo_Genero.SelectedIndex == 1)
            {
                lst_Genero.Items.Add("Femenino");
            }
            txtNombre.Clear();
            txt_Apellidom.Clear();
            txt_Apellidop.Clear();
            txtDireccion.Clear();
            
        }

        private void lst_ApellidoP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HabilitarGenero(object sender, EventArgs e)
        {
            cbo_Genero.Enabled = txtNombre.Text != "";
        }
        CalculadorDeEdadesDeEmpleados calcular = new CalculadorDeEdadesDeEmpleados();
        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void calcularEdadDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            calcular.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
