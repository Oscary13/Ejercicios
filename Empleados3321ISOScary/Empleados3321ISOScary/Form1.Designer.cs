
namespace Empleados3321ISOScary
{
    partial class FrmTurno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurno));
            this.IblNombre = new System.Windows.Forms.Label();
            this.blTurno = new System.Windows.Forms.Label();
            this.IblTurnoMañana = new System.Windows.Forms.Label();
            this.blTurnoNoche = new System.Windows.Forms.Label();
            this.IblTotalMañana = new System.Windows.Forms.Label();
            this.IblTotalNoche = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTotalMañana = new System.Windows.Forms.TextBox();
            this.TxtTotalNoche = new System.Windows.Forms.TextBox();
            this.CboTurno = new System.Windows.Forms.ComboBox();
            this.LstMañana = new System.Windows.Forms.ListBox();
            this.LstNoche = new System.Windows.Forms.ListBox();
            this.BtnUnoNoche = new System.Windows.Forms.Button();
            this.BtnTodosNoche = new System.Windows.Forms.Button();
            this.BtnUnoMañana = new System.Windows.Forms.Button();
            this.btnTodosMañana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IblNombre
            // 
            this.IblNombre.AutoSize = true;
            this.IblNombre.Location = new System.Drawing.Point(24, 28);
            this.IblNombre.Name = "IblNombre";
            this.IblNombre.Size = new System.Drawing.Size(114, 13);
            this.IblNombre.TabIndex = 0;
            this.IblNombre.Text = "Nombre del Empleado:";
            // 
            // blTurno
            // 
            this.blTurno.AutoSize = true;
            this.blTurno.Location = new System.Drawing.Point(24, 64);
            this.blTurno.Name = "blTurno";
            this.blTurno.Size = new System.Drawing.Size(75, 13);
            this.blTurno.TabIndex = 1;
            this.blTurno.Text = "Elige el Turno:";
            // 
            // IblTurnoMañana
            // 
            this.IblTurnoMañana.AutoSize = true;
            this.IblTurnoMañana.Location = new System.Drawing.Point(28, 100);
            this.IblTurnoMañana.Name = "IblTurnoMañana";
            this.IblTurnoMañana.Size = new System.Drawing.Size(80, 13);
            this.IblTurnoMañana.TabIndex = 2;
            this.IblTurnoMañana.Text = "Turno Mañana:";
            // 
            // blTurnoNoche
            // 
            this.blTurnoNoche.AutoSize = true;
            this.blTurnoNoche.Location = new System.Drawing.Point(212, 100);
            this.blTurnoNoche.Name = "blTurnoNoche";
            this.blTurnoNoche.Size = new System.Drawing.Size(73, 13);
            this.blTurnoNoche.TabIndex = 3;
            this.blTurnoNoche.Text = "Turno Noche:";
            // 
            // IblTotalMañana
            // 
            this.IblTotalMañana.AutoSize = true;
            this.IblTotalMañana.Location = new System.Drawing.Point(32, 272);
            this.IblTotalMañana.Name = "IblTotalMañana";
            this.IblTotalMañana.Size = new System.Drawing.Size(76, 13);
            this.IblTotalMañana.TabIndex = 4;
            this.IblTotalMañana.Text = "Total Mañana:";
            // 
            // IblTotalNoche
            // 
            this.IblTotalNoche.AutoSize = true;
            this.IblTotalNoche.Location = new System.Drawing.Point(212, 272);
            this.IblTotalNoche.Name = "IblTotalNoche";
            this.IblTotalNoche.Size = new System.Drawing.Size(69, 13);
            this.IblTotalNoche.TabIndex = 5;
            this.IblTotalNoche.Text = "Total Noche:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(152, 24);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(180, 20);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextChanged += new System.EventHandler(this.HabilitarTurno);
            // 
            // TxtTotalMañana
            // 
            this.TxtTotalMañana.Location = new System.Drawing.Point(116, 268);
            this.TxtTotalMañana.Name = "TxtTotalMañana";
            this.TxtTotalMañana.ReadOnly = true;
            this.TxtTotalMañana.Size = new System.Drawing.Size(32, 20);
            this.TxtTotalMañana.TabIndex = 7;
            // 
            // TxtTotalNoche
            // 
            this.TxtTotalNoche.Location = new System.Drawing.Point(300, 268);
            this.TxtTotalNoche.Name = "TxtTotalNoche";
            this.TxtTotalNoche.ReadOnly = true;
            this.TxtTotalNoche.Size = new System.Drawing.Size(32, 20);
            this.TxtTotalNoche.TabIndex = 8;
            // 
            // CboTurno
            // 
            this.CboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTurno.Enabled = false;
            this.CboTurno.FormattingEnabled = true;
            this.CboTurno.Location = new System.Drawing.Point(152, 60);
            this.CboTurno.Name = "CboTurno";
            this.CboTurno.Size = new System.Drawing.Size(184, 21);
            this.CboTurno.TabIndex = 9;
            this.CboTurno.SelectedIndexChanged += new System.EventHandler(this.AsignarTurno);
            // 
            // LstMañana
            // 
            this.LstMañana.FormattingEnabled = true;
            this.LstMañana.Location = new System.Drawing.Point(28, 124);
            this.LstMañana.Name = "LstMañana";
            this.LstMañana.Size = new System.Drawing.Size(120, 134);
            this.LstMañana.TabIndex = 10;
            // 
            // LstNoche
            // 
            this.LstNoche.FormattingEnabled = true;
            this.LstNoche.Location = new System.Drawing.Point(212, 124);
            this.LstNoche.Name = "LstNoche";
            this.LstNoche.Size = new System.Drawing.Size(120, 134);
            this.LstNoche.TabIndex = 11;
            // 
            // BtnUnoNoche
            // 
            this.BtnUnoNoche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnoNoche.Location = new System.Drawing.Point(164, 128);
            this.BtnUnoNoche.Name = "BtnUnoNoche";
            this.BtnUnoNoche.Size = new System.Drawing.Size(32, 23);
            this.BtnUnoNoche.TabIndex = 12;
            this.BtnUnoNoche.Text = ">";
            this.BtnUnoNoche.UseVisualStyleBackColor = true;
            this.BtnUnoNoche.Click += new System.EventHandler(this.MoverUnoNoche);
            // 
            // BtnTodosNoche
            // 
            this.BtnTodosNoche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTodosNoche.Location = new System.Drawing.Point(164, 162);
            this.BtnTodosNoche.Name = "BtnTodosNoche";
            this.BtnTodosNoche.Size = new System.Drawing.Size(32, 23);
            this.BtnTodosNoche.TabIndex = 13;
            this.BtnTodosNoche.Text = "»";
            this.BtnTodosNoche.UseVisualStyleBackColor = true;
            this.BtnTodosNoche.Click += new System.EventHandler(this.MoverTodosNoche);
            // 
            // BtnUnoMañana
            // 
            this.BtnUnoMañana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnoMañana.Location = new System.Drawing.Point(164, 196);
            this.BtnUnoMañana.Name = "BtnUnoMañana";
            this.BtnUnoMañana.Size = new System.Drawing.Size(32, 23);
            this.BtnUnoMañana.TabIndex = 14;
            this.BtnUnoMañana.Text = "<";
            this.BtnUnoMañana.UseVisualStyleBackColor = true;
            this.BtnUnoMañana.Click += new System.EventHandler(this.MoverUnoMañana);
            // 
            // btnTodosMañana
            // 
            this.btnTodosMañana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosMañana.Location = new System.Drawing.Point(164, 230);
            this.btnTodosMañana.Name = "btnTodosMañana";
            this.btnTodosMañana.Size = new System.Drawing.Size(32, 23);
            this.btnTodosMañana.TabIndex = 15;
            this.btnTodosMañana.Text = "«";
            this.btnTodosMañana.UseVisualStyleBackColor = true;
            this.btnTodosMañana.Click += new System.EventHandler(this.MoverTodosMañana);
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Empleados3321ISOScary.Properties.Resources.depositphotos_6200159_stock_photo_digital_circuit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 301);
            this.Controls.Add(this.btnTodosMañana);
            this.Controls.Add(this.BtnUnoMañana);
            this.Controls.Add(this.BtnTodosNoche);
            this.Controls.Add(this.BtnUnoNoche);
            this.Controls.Add(this.LstNoche);
            this.Controls.Add(this.LstMañana);
            this.Controls.Add(this.CboTurno);
            this.Controls.Add(this.TxtTotalNoche);
            this.Controls.Add(this.TxtTotalMañana);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.IblTotalNoche);
            this.Controls.Add(this.IblTotalMañana);
            this.Controls.Add(this.blTurnoNoche);
            this.Controls.Add(this.IblTurnoMañana);
            this.Controls.Add(this.blTurno);
            this.Controls.Add(this.IblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Turnos a Empleados";
            this.Load += new System.EventHandler(this.CargarTurnos);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblNombre;
        private System.Windows.Forms.Label blTurno;
        private System.Windows.Forms.Label IblTurnoMañana;
        private System.Windows.Forms.Label blTurnoNoche;
        private System.Windows.Forms.Label IblTotalMañana;
        private System.Windows.Forms.Label IblTotalNoche;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTotalMañana;
        private System.Windows.Forms.TextBox TxtTotalNoche;
        private System.Windows.Forms.ComboBox CboTurno;
        private System.Windows.Forms.ListBox LstMañana;
        private System.Windows.Forms.ListBox LstNoche;
        private System.Windows.Forms.Button BtnUnoNoche;
        private System.Windows.Forms.Button BtnTodosNoche;
        private System.Windows.Forms.Button BtnUnoMañana;
        private System.Windows.Forms.Button btnTodosMañana;
    }
}

