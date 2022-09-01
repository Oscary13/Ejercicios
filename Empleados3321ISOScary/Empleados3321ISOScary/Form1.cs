using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados3321ISOScary
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
        private void CargarTurnos(object sender, EventArgs e)
        {
            CboTurno.Items.Add("Mañana");
            CboTurno.Items.Add("Noche");
        }

        private void HabilitarTurno(object sender, EventArgs e)
        {
            CboTurno.Enabled = TxtNombre.Text != "";
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

        private void MoverUnoNoche(object sender, EventArgs e)
        {
            if (LstMañana.SelectedIndex > -1)
            {
                LstNoche.Items.Add(LstMañana.SelectedItem);
                LstMañana.Items.Remove(LstMañana.SelectedItem);
                MostrarTotales();
            }
        }

        private void MoverTodosNoche(object sender, EventArgs e)
        {
            if (LstMañana.Items.Count > 0)
            {
                LstNoche.Items.AddRange(LstMañana.Items);
                LstMañana.Items.Clear();
                MostrarTotales();
            }
        }

        private void MoverUnoMañana(object sender, EventArgs e)
        {
            if (LstNoche.SelectedIndex > -1)
            {
                LstMañana.Items.Add(LstNoche.SelectedItem);
                LstNoche.Items.Remove(LstNoche.SelectedItem);
                MostrarTotales();
            }
        }

        private void MoverTodosMañana(object sender, EventArgs e)
        {
            if (LstNoche.Items.Count > 0)
            {
                LstMañana.Items.AddRange(LstNoche.Items);
                LstNoche.Items.Clear();
                MostrarTotales();

            }
        }
    }
}
