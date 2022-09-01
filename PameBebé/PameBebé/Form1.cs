using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PameBebé
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.Parent = pictureBox1;
            label1.Parent = pictureBox2;
            lbl3.Parent = pictureBox3;
            lbl3_1.Parent = pictureBox3;
            lbl4.Parent = pictureBox4;
            lbl5.Parent = pictureBox5;
            lbl6.Parent = pictureBox6;
            lbl7.Parent = pictureBox7;
            lbl8.Parent = pictureBox8;
            lbl_8_1.Parent = pictureBox8;
            lbl9.Parent = pictureBox9;
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            btnSi.TabStop = false;
            btnNo.TabStop = false;

        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNo.Width);
            int y = r.Next(0, this.Height - btnNo.Width);
            btnNo.Location = new Point(x, y);
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNo.Location == btnSi.Location || btnNo.Location == lblTitulo.Location )
            {
                MoverBoton();
            }
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void lbl3_1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            panel8.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
