
namespace Empleado
{
    partial class CalculadorDeEdadesDeEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFechadNacimiento_e = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEdaddeempleadoses_e = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechadNacimiento_e
            // 
            this.lblFechadNacimiento_e.AutoSize = true;
            this.lblFechadNacimiento_e.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadNacimiento_e.Location = new System.Drawing.Point(24, 33);
            this.lblFechadNacimiento_e.Name = "lblFechadNacimiento_e";
            this.lblFechadNacimiento_e.Size = new System.Drawing.Size(272, 31);
            this.lblFechadNacimiento_e.TabIndex = 1;
            this.lblFechadNacimiento_e.Text = "FECHA DE NACIMIENTO";
            this.lblFechadNacimiento_e.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(327, 33);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(141, 29);
            this.dtpFechaDeNacimiento.TabIndex = 2;
            this.dtpFechaDeNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaDeNacimiento_ValueChanged);
            // 
            // lblEdaddeempleadoses_e
            // 
            this.lblEdaddeempleadoses_e.AutoSize = true;
            this.lblEdaddeempleadoses_e.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdaddeempleadoses_e.Location = new System.Drawing.Point(24, 100);
            this.lblEdaddeempleadoses_e.Name = "lblEdaddeempleadoses_e";
            this.lblEdaddeempleadoses_e.Size = new System.Drawing.Size(341, 31);
            this.lblEdaddeempleadoses_e.TabIndex = 3;
            this.lblEdaddeempleadoses_e.Text = "LA EDAD DEL EMPLEADO ES : ";
            this.lblEdaddeempleadoses_e.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(362, 100);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(26, 31);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAplicaciónToolStripMenuItem,
            this.registrarEmpleadosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación";
            this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // registrarEmpleadosToolStripMenuItem
            // 
            this.registrarEmpleadosToolStripMenuItem.Name = "registrarEmpleadosToolStripMenuItem";
            this.registrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarEmpleadosToolStripMenuItem.Text = "Registrar empleados";
            this.registrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadosToolStripMenuItem_Click);
            // 
            // CalculadorDeEdadesDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 203);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEdaddeempleadoses_e);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblFechadNacimiento_e);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalculadorDeEdadesDeEmpleados";
            this.Text = "CalculadorDeEdadesDeEmpleados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechadNacimiento_e;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label lblEdaddeempleadoses_e;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadosToolStripMenuItem;
    }
}