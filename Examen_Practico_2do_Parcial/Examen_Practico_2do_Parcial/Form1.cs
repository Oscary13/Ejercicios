using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Practico_2do_Parcial
{
    public partial class Examen : Form
    {
        public Examen()
        {
            InitializeComponent();
        }

        private void btn_Calcu_AEsfera_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_Radio_Esfera.Text);

            if (a <= 0)
            {
                MessageBox.Show("ERROR: \n \n VALOR NEGATIVO");
            }
            else
            {
                a = Math.Pow(a, 2);
                double b = 4 * System.Math.PI;
                double c = b * a;
               
                lbl_resultado.Text = c.ToString();

            }
        }

        private void areaDeUnaCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Examen_Load(object sender, EventArgs e)
        {
            panel_AreaCircu.Hide();
            panel_AreaCilindr.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(txt_Area_circu.Text);

            if (a <= 0)
            {
                MessageBox.Show("ERROR: \n \n VALOR NEGATIVO");
            }
            else
            {
                a = Math.Pow(a, 2);
                double c =  System.Math.PI * a;
                lbl_Result_circu.Text = c.ToString();

            }
        }

        private void áreaDeUnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_AreaCilindr.Hide();
            panel_AreaCircu.Show();

            txt_Radio_Esfera.Clear();
            lbl_resultado.Text="";

            txt_radio_Cilin.Clear();
            txt_Altura_Cilin.Clear();
            lbl_Result_Cilin.Text= "";
        }

        private void áreaDeUNaEsferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel_AreaCircu.Hide();
            txt_Area_circu.Clear();
            lbl_Result_circu.Text = "";
            panel_AreaCilindr.Hide();
            txt_radio_Cilin.Clear();
            txt_Altura_Cilin.Clear();
            lbl_Result_Cilin.Text= "";

        }

        private void btn_Calcular_Ciln_Click(object sender, EventArgs e)
        {

            
                double r = Convert.ToDouble(txt_radio_Cilin.Text);
                double h = Convert.ToDouble(txt_Altura_Cilin.Text);
            
          

            if (r <= 0 || h <= 0)
            {
                MessageBox.Show("ERROR: \n \n VALOR NEGATIVO");
            }
            else
            {
                
                
                
                double c = 2 * System.Math.PI ;
                double d = r * h;
                double ee = c * d;

                double aa= Math.Pow(r, 2);
                double bb = c * aa;
                double cc = ee + bb;

                lbl_Result_Cilin.Text = cc.ToString();

            }
        }

        private void areaDeUnCilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_AreaCilindr.Show();
            txt_Radio_Esfera.Clear();
            lbl_resultado.Text = "";
            txt_Area_circu.Clear();
            lbl_Result_circu.Text = "";

        }

        private void areaDeUnCilindroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_AreaCilindr.Show();
        }
    }
}
