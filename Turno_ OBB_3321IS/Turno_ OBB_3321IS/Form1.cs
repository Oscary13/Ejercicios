using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turno__OBB_3321IS
{
    public partial class FrmTurno : Form
    {

        public FrmTurno()
        {
            InitializeComponent();

        }
        private void MostrarTotales()
        {
            TxtTotalMañana.BackColor = Color.YellowGreen;
            TxtTotalMañana.Text = LstMañana.Items.Count.ToString();
            TxtTotalNoche.BackColor = Color.YellowGreen;
            TxtTotalNoche.Text = LstNoche.Items.Count.ToString();
        }
        private void CargarTurnos_Load(object sender, EventArgs e)
        {
            CboTurno.Items.Add("Mañana");
            CboTurno.Items.Add("Noche");
        } 
        private void HabilitarTurno(object sender, EventArgs e)
        {
            CboTurno.Enabled = TxtNombre.Text != ""; 
        }
        private void CboTurno_TextChanged(object sender, EventArgs e)
        {
        }



        private void FrmTurno_Load(object sender, EventArgs e)
        {

        }

        private void AsignarTurno(object sender, EventArgs e)
        {
            if (CboTurno.SelectedIndex == 0)
            {
                LstMañana.Items.Add(TxtNombre.Text.Trim());
                
            }
            else
            {
                LstNoche.Items.Add(TxtNombre.Text.Trim());
            }
            MostrarTotales();
            TxtNombre.Clear();
            TxtNombre.Focus();

        }
    }
}
