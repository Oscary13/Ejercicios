
namespace Turno__OBB_3321IS
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.IblTurno = new System.Windows.Forms.Label();
            this.IblTurnoMañana = new System.Windows.Forms.Label();
            this.IblTurnoNoche = new System.Windows.Forms.Label();
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Empleado:";
            // 
            // IblTurno
            // 
            this.IblTurno.AutoSize = true;
            this.IblTurno.Location = new System.Drawing.Point(26, 64);
            this.IblTurno.Name = "IblTurno";
            this.IblTurno.Size = new System.Drawing.Size(75, 13);
            this.IblTurno.TabIndex = 1;
            this.IblTurno.Text = "Elige el Turno:";
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
            // IblTurnoNoche
            // 
            this.IblTurnoNoche.AutoSize = true;
            this.IblTurnoNoche.Location = new System.Drawing.Point(212, 100);
            this.IblTurnoNoche.Name = "IblTurnoNoche";
            this.IblTurnoNoche.Size = new System.Drawing.Size(73, 13);
            this.IblTurnoNoche.TabIndex = 3;
            this.IblTurnoNoche.Text = "Turno Noche:";
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
            this.TxtNombre.ReadOnly = true;
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
            this.CboTurno.TextChanged += new System.EventHandler(this.CboTurno_TextChanged);
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
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Turno__OBB_3321IS.Properties.Resources.depositphotos_6200159_stock_photo_digital_circuit;
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
            this.Controls.Add(this.IblTurnoNoche);
            this.Controls.Add(this.IblTurnoMañana);
            this.Controls.Add(this.IblTurno);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Turnos a Empleados";
            this.Load += new System.EventHandler(this.CargarTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label IblTurno;
        private System.Windows.Forms.Label IblTurnoMañana;
        private System.Windows.Forms.Label IblTurnoNoche;
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

