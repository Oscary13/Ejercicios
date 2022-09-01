
namespace Empleado
{
    partial class EMPLEADO
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
            this.lbl_Rge_E = new System.Windows.Forms.Label();
            this.lbl_nombre_e = new System.Windows.Forms.Label();
            this.lbl_ApellidoP_e = new System.Windows.Forms.Label();
            this.lbl_Apellidim_e = new System.Windows.Forms.Label();
            this.lblDireccion_e = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidop = new System.Windows.Forms.TextBox();
            this.txt_Apellidom = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mts_Menu_opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Genero_e = new System.Windows.Forms.Label();
            this.lst_EmpleadosRegistrados = new System.Windows.Forms.ListBox();
            this.cbo_Genero = new System.Windows.Forms.ComboBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.lst_ApellidoP = new System.Windows.Forms.ListBox();
            this.lst_ApellodoM = new System.Windows.Forms.ListBox();
            this.lst_ApellidoM = new System.Windows.Forms.ListBox();
            this.lst_Direccion = new System.Windows.Forms.ListBox();
            this.lst_Genero = new System.Windows.Forms.ListBox();
            this.lblApaterno_e = new System.Windows.Forms.Label();
            this.lblnombre_e = new System.Windows.Forms.Label();
            this.lblAmaterno = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lblGenero_e = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularEdadDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Rge_E
            // 
            this.lbl_Rge_E.AutoSize = true;
            this.lbl_Rge_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rge_E.Location = new System.Drawing.Point(232, 24);
            this.lbl_Rge_E.Name = "lbl_Rge_E";
            this.lbl_Rge_E.Size = new System.Drawing.Size(267, 24);
            this.lbl_Rge_E.TabIndex = 0;
            this.lbl_Rge_E.Text = "REGISTRO DE EMPLEADO";
            // 
            // lbl_nombre_e
            // 
            this.lbl_nombre_e.AutoSize = true;
            this.lbl_nombre_e.Location = new System.Drawing.Point(48, 74);
            this.lbl_nombre_e.Name = "lbl_nombre_e";
            this.lbl_nombre_e.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre_e.TabIndex = 1;
            this.lbl_nombre_e.Text = "Nombre: ";
            // 
            // lbl_ApellidoP_e
            // 
            this.lbl_ApellidoP_e.AutoSize = true;
            this.lbl_ApellidoP_e.Location = new System.Drawing.Point(253, 74);
            this.lbl_ApellidoP_e.Name = "lbl_ApellidoP_e";
            this.lbl_ApellidoP_e.Size = new System.Drawing.Size(90, 13);
            this.lbl_ApellidoP_e.TabIndex = 2;
            this.lbl_ApellidoP_e.Text = "Apellido Paterno: ";
            // 
            // lbl_Apellidim_e
            // 
            this.lbl_Apellidim_e.AutoSize = true;
            this.lbl_Apellidim_e.Location = new System.Drawing.Point(489, 74);
            this.lbl_Apellidim_e.Name = "lbl_Apellidim_e";
            this.lbl_Apellidim_e.Size = new System.Drawing.Size(89, 13);
            this.lbl_Apellidim_e.TabIndex = 4;
            this.lbl_Apellidim_e.Text = "Apellido Materno:";
            this.lbl_Apellidim_e.Click += new System.EventHandler(this.lbl_Apellidim_e_Click);
            // 
            // lblDireccion_e
            // 
            this.lblDireccion_e.AutoSize = true;
            this.lblDireccion_e.Location = new System.Drawing.Point(48, 126);
            this.lblDireccion_e.Name = "lblDireccion_e";
            this.lblDireccion_e.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion_e.TabIndex = 5;
            this.lblDireccion_e.Text = "Dirección: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.HabilitarGenero);
            // 
            // txt_Apellidop
            // 
            this.txt_Apellidop.Location = new System.Drawing.Point(340, 71);
            this.txt_Apellidop.Name = "txt_Apellidop";
            this.txt_Apellidop.Size = new System.Drawing.Size(132, 20);
            this.txt_Apellidop.TabIndex = 7;
            // 
            // txt_Apellidom
            // 
            this.txt_Apellidom.Location = new System.Drawing.Point(584, 71);
            this.txt_Apellidom.Name = "txt_Apellidom";
            this.txt_Apellidom.Size = new System.Drawing.Size(132, 20);
            this.txt_Apellidom.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(113, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(123, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mts_Menu_opciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mts_Menu_opciones
            // 
            this.mts_Menu_opciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAplicaciónToolStripMenuItem,
            this.calcularEdadDeEmpleadoToolStripMenuItem});
            this.mts_Menu_opciones.Name = "mts_Menu_opciones";
            this.mts_Menu_opciones.Size = new System.Drawing.Size(69, 20);
            this.mts_Menu_opciones.Text = "Opciones";
            // 
            // lbl_Genero_e
            // 
            this.lbl_Genero_e.AutoSize = true;
            this.lbl_Genero_e.Location = new System.Drawing.Point(270, 129);
            this.lbl_Genero_e.Name = "lbl_Genero_e";
            this.lbl_Genero_e.Size = new System.Drawing.Size(48, 13);
            this.lbl_Genero_e.TabIndex = 11;
            this.lbl_Genero_e.Text = "Genero :";
            // 
            // lst_EmpleadosRegistrados
            // 
            this.lst_EmpleadosRegistrados.FormattingEnabled = true;
            this.lst_EmpleadosRegistrados.Location = new System.Drawing.Point(12, 301);
            this.lst_EmpleadosRegistrados.Name = "lst_EmpleadosRegistrados";
            this.lst_EmpleadosRegistrados.Size = new System.Drawing.Size(167, 95);
            this.lst_EmpleadosRegistrados.TabIndex = 14;
            // 
            // cbo_Genero
            // 
            this.cbo_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Genero.Enabled = false;
            this.cbo_Genero.FormattingEnabled = true;
            this.cbo_Genero.Location = new System.Drawing.Point(324, 126);
            this.cbo_Genero.Name = "cbo_Genero";
            this.cbo_Genero.Size = new System.Drawing.Size(121, 21);
            this.cbo_Genero.TabIndex = 15;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(492, 126);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(112, 23);
            this.btn_Registrar.TabIndex = 16;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lst_ApellidoP
            // 
            this.lst_ApellidoP.FormattingEnabled = true;
            this.lst_ApellidoP.Location = new System.Drawing.Point(179, 301);
            this.lst_ApellidoP.Name = "lst_ApellidoP";
            this.lst_ApellidoP.Size = new System.Drawing.Size(146, 95);
            this.lst_ApellidoP.TabIndex = 18;
            this.lst_ApellidoP.SelectedIndexChanged += new System.EventHandler(this.lst_ApellidoP_SelectedIndexChanged);
            // 
            // lst_ApellodoM
            // 
            this.lst_ApellodoM.FormattingEnabled = true;
            this.lst_ApellodoM.Location = new System.Drawing.Point(928, 421);
            this.lst_ApellodoM.Name = "lst_ApellodoM";
            this.lst_ApellodoM.Size = new System.Drawing.Size(120, 95);
            this.lst_ApellodoM.TabIndex = 19;
            // 
            // lst_ApellidoM
            // 
            this.lst_ApellidoM.FormattingEnabled = true;
            this.lst_ApellidoM.Location = new System.Drawing.Point(321, 301);
            this.lst_ApellidoM.Name = "lst_ApellidoM";
            this.lst_ApellidoM.Size = new System.Drawing.Size(148, 95);
            this.lst_ApellidoM.TabIndex = 20;
            // 
            // lst_Direccion
            // 
            this.lst_Direccion.FormattingEnabled = true;
            this.lst_Direccion.Location = new System.Drawing.Point(466, 301);
            this.lst_Direccion.Name = "lst_Direccion";
            this.lst_Direccion.Size = new System.Drawing.Size(162, 95);
            this.lst_Direccion.TabIndex = 21;
            // 
            // lst_Genero
            // 
            this.lst_Genero.FormattingEnabled = true;
            this.lst_Genero.Location = new System.Drawing.Point(626, 301);
            this.lst_Genero.Name = "lst_Genero";
            this.lst_Genero.Size = new System.Drawing.Size(101, 95);
            this.lst_Genero.TabIndex = 22;
            // 
            // lblApaterno_e
            // 
            this.lblApaterno_e.AutoSize = true;
            this.lblApaterno_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApaterno_e.Location = new System.Drawing.Point(182, 282);
            this.lblApaterno_e.Name = "lblApaterno_e";
            this.lblApaterno_e.Size = new System.Drawing.Size(128, 16);
            this.lblApaterno_e.TabIndex = 23;
            this.lblApaterno_e.Text = "Apellido Paterno:";
            // 
            // lblnombre_e
            // 
            this.lblnombre_e.AutoSize = true;
            this.lblnombre_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre_e.Location = new System.Drawing.Point(9, 282);
            this.lblnombre_e.Name = "lblnombre_e";
            this.lblnombre_e.Size = new System.Drawing.Size(67, 16);
            this.lblnombre_e.TabIndex = 24;
            this.lblnombre_e.Text = "Nombre:";
            // 
            // lblAmaterno
            // 
            this.lblAmaterno.AutoSize = true;
            this.lblAmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmaterno.Location = new System.Drawing.Point(326, 282);
            this.lblAmaterno.Name = "lblAmaterno";
            this.lblAmaterno.Size = new System.Drawing.Size(130, 16);
            this.lblAmaterno.TabIndex = 25;
            this.lblAmaterno.Text = "Apellido Materno:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(470, 282);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(78, 16);
            this.lbl_direccion.TabIndex = 26;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lblGenero_e
            // 
            this.lblGenero_e.AutoSize = true;
            this.lblGenero_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero_e.Location = new System.Drawing.Point(631, 282);
            this.lblGenero_e.Name = "lblGenero_e";
            this.lblGenero_e.Size = new System.Drawing.Size(63, 16);
            this.lblGenero_e.TabIndex = 27;
            this.lblGenero_e.Text = "Genero:";
            this.lblGenero_e.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "EMPLEADOS REGISTRADOS";
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación";
            this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // calcularEdadDeEmpleadoToolStripMenuItem
            // 
            this.calcularEdadDeEmpleadoToolStripMenuItem.Name = "calcularEdadDeEmpleadoToolStripMenuItem";
            this.calcularEdadDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.calcularEdadDeEmpleadoToolStripMenuItem.Text = "Calcular Edad de empleado";
            this.calcularEdadDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.calcularEdadDeEmpleadoToolStripMenuItem_Click);
            // 
            // EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGenero_e);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lblAmaterno);
            this.Controls.Add(this.lblnombre_e);
            this.Controls.Add(this.lblApaterno_e);
            this.Controls.Add(this.lst_Genero);
            this.Controls.Add(this.lst_Direccion);
            this.Controls.Add(this.lst_ApellidoM);
            this.Controls.Add(this.lst_ApellodoM);
            this.Controls.Add(this.lst_ApellidoP);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.cbo_Genero);
            this.Controls.Add(this.lst_EmpleadosRegistrados);
            this.Controls.Add(this.lbl_Genero_e);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txt_Apellidom);
            this.Controls.Add(this.txt_Apellidop);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion_e);
            this.Controls.Add(this.lbl_Apellidim_e);
            this.Controls.Add(this.lbl_ApellidoP_e);
            this.Controls.Add(this.lbl_nombre_e);
            this.Controls.Add(this.lbl_Rge_E);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EMPLEADO";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.EMPLEADO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rge_E;
        private System.Windows.Forms.Label lbl_nombre_e;
        private System.Windows.Forms.Label lbl_ApellidoP_e;
        private System.Windows.Forms.Label lbl_Apellidim_e;
        private System.Windows.Forms.Label lblDireccion_e;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txt_Apellidop;
        private System.Windows.Forms.TextBox txt_Apellidom;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mts_Menu_opciones;
        private System.Windows.Forms.Label lbl_Genero_e;
        private System.Windows.Forms.ListBox lst_EmpleadosRegistrados;
        private System.Windows.Forms.ComboBox cbo_Genero;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.ListBox lst_ApellidoP;
        private System.Windows.Forms.ListBox lst_ApellodoM;
        private System.Windows.Forms.ListBox lst_ApellidoM;
        private System.Windows.Forms.ListBox lst_Direccion;
        private System.Windows.Forms.ListBox lst_Genero;
        private System.Windows.Forms.Label lblApaterno_e;
        private System.Windows.Forms.Label lblnombre_e;
        private System.Windows.Forms.Label lblAmaterno;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lblGenero_e;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularEdadDeEmpleadoToolStripMenuItem;
    }
}