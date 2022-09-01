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
    public partial class FromsEmpleado : Form
    {
        EMPLEADO Empleado = new EMPLEADO();
        public FromsEmpleado()
        {
            InitializeComponent();
        }

        private void FromsEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "OscaryBB" && txt_Contra.Text == "26obb2002")
            {
                this.Hide();
               Empleado.Show();
               
            }
            else
            {
                txtUsuario.Clear();
                txt_Contra.Clear();
            }
        }
    }
}
