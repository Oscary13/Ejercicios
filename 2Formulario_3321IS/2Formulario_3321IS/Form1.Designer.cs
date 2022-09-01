
namespace _2Formulario_3321IS
{
    partial class Form_Escuela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Escuela));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_ingresatunombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gbx_cursos = new System.Windows.Forms.GroupBox();
            this.cbx_chinoma = new System.Windows.Forms.CheckBox();
            this.cbx_frances = new System.Windows.Forms.CheckBox();
            this.cbx_aleman = new System.Windows.Forms.CheckBox();
            this.cbx_ingles = new System.Windows.Forms.CheckBox();
            this.lbl_seleccionacursos = new System.Windows.Forms.Label();
            this.btn_costo = new System.Windows.Forms.Button();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_limpiar = new System.Windows.Forms.Button();
            this.gbx_Horario = new System.Windows.Forms.GroupBox();
            this.rbt_Matutino = new System.Windows.Forms.RadioButton();
            this.rbt_Vespertino = new System.Windows.Forms.RadioButton();
            this.rbt_Sabatino = new System.Windows.Forms.RadioButton();
            this.gbx_cursos.SuspendLayout();
            this.gbx_Horario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Graffiti City", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(285, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(459, 39);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "BIENVENIDOS A LA ESCUELA 3321IS";
            // 
            // lbl_ingresatunombre
            // 
            this.lbl_ingresatunombre.AutoSize = true;
            this.lbl_ingresatunombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresatunombre.Location = new System.Drawing.Point(343, 72);
            this.lbl_ingresatunombre.Name = "lbl_ingresatunombre";
            this.lbl_ingresatunombre.Size = new System.Drawing.Size(142, 20);
            this.lbl_ingresatunombre.TabIndex = 1;
            this.lbl_ingresatunombre.Text = "INGRESA TU NOMBRE:";
            this.lbl_ingresatunombre.Click += new System.EventHandler(this.lbl_ingresatunombre_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(503, 72);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(136, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbx_cursos
            // 
            this.gbx_cursos.BackColor = System.Drawing.Color.GreenYellow;
            this.gbx_cursos.Controls.Add(this.cbx_chinoma);
            this.gbx_cursos.Controls.Add(this.cbx_frances);
            this.gbx_cursos.Controls.Add(this.cbx_aleman);
            this.gbx_cursos.Controls.Add(this.cbx_ingles);
            this.gbx_cursos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_cursos.Location = new System.Drawing.Point(79, 149);
            this.gbx_cursos.Name = "gbx_cursos";
            this.gbx_cursos.Size = new System.Drawing.Size(560, 168);
            this.gbx_cursos.TabIndex = 3;
            this.gbx_cursos.TabStop = false;
            this.gbx_cursos.Text = "CURSOS";
            this.gbx_cursos.Enter += new System.EventHandler(this.gbx_cursos_Enter);
            // 
            // cbx_chinoma
            // 
            this.cbx_chinoma.AutoSize = true;
            this.cbx_chinoma.Location = new System.Drawing.Point(396, 108);
            this.cbx_chinoma.Name = "cbx_chinoma";
            this.cbx_chinoma.Size = new System.Drawing.Size(138, 24);
            this.cbx_chinoma.TabIndex = 3;
            this.cbx_chinoma.Text = "CHINO MANDARIN";
            this.cbx_chinoma.UseVisualStyleBackColor = true;
            // 
            // cbx_frances
            // 
            this.cbx_frances.AutoSize = true;
            this.cbx_frances.Location = new System.Drawing.Point(396, 39);
            this.cbx_frances.Name = "cbx_frances";
            this.cbx_frances.Size = new System.Drawing.Size(83, 24);
            this.cbx_frances.TabIndex = 2;
            this.cbx_frances.Text = "FRANCÉS";
            this.cbx_frances.UseVisualStyleBackColor = true;
            // 
            // cbx_aleman
            // 
            this.cbx_aleman.AutoSize = true;
            this.cbx_aleman.Location = new System.Drawing.Point(137, 108);
            this.cbx_aleman.Name = "cbx_aleman";
            this.cbx_aleman.Size = new System.Drawing.Size(75, 24);
            this.cbx_aleman.TabIndex = 1;
            this.cbx_aleman.Text = "ALEMAN";
            this.cbx_aleman.UseVisualStyleBackColor = true;
            this.cbx_aleman.CheckedChanged += new System.EventHandler(this.cbx_aleman_CheckedChanged);
            // 
            // cbx_ingles
            // 
            this.cbx_ingles.AutoSize = true;
            this.cbx_ingles.Location = new System.Drawing.Point(137, 39);
            this.cbx_ingles.Name = "cbx_ingles";
            this.cbx_ingles.Size = new System.Drawing.Size(72, 24);
            this.cbx_ingles.TabIndex = 0;
            this.cbx_ingles.Text = "INGLÉS";
            this.cbx_ingles.UseVisualStyleBackColor = true;
            // 
            // lbl_seleccionacursos
            // 
            this.lbl_seleccionacursos.AutoSize = true;
            this.lbl_seleccionacursos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionacursos.Location = new System.Drawing.Point(240, 117);
            this.lbl_seleccionacursos.Name = "lbl_seleccionacursos";
            this.lbl_seleccionacursos.Size = new System.Drawing.Size(233, 20);
            this.lbl_seleccionacursos.TabIndex = 4;
            this.lbl_seleccionacursos.Text = "SELECCIONA LOS CURSOS DESEADOS";
            // 
            // btn_costo
            // 
            this.btn_costo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_costo.Location = new System.Drawing.Point(79, 320);
            this.btn_costo.Name = "btn_costo";
            this.btn_costo.Size = new System.Drawing.Size(84, 39);
            this.btn_costo.TabIndex = 5;
            this.btn_costo.Text = "COSTO";
            this.btn_costo.UseVisualStyleBackColor = true;
            this.btn_costo.Click += new System.EventHandler(this.btn_costo_Click);
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.Color.Chocolate;
            this.lbl_costo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_costo.Location = new System.Drawing.Point(209, 320);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(0, 22);
            this.lbl_costo.TabIndex = 6;
            // 
            // lbl_limpiar
            // 
            this.lbl_limpiar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limpiar.Location = new System.Drawing.Point(858, 307);
            this.lbl_limpiar.Name = "lbl_limpiar";
            this.lbl_limpiar.Size = new System.Drawing.Size(90, 39);
            this.lbl_limpiar.TabIndex = 7;
            this.lbl_limpiar.Text = "LIMPIAR";
            this.lbl_limpiar.UseVisualStyleBackColor = true;
            this.lbl_limpiar.Click += new System.EventHandler(this.lbl_limpiar_Click);
            // 
            // gbx_Horario
            // 
            this.gbx_Horario.Controls.Add(this.rbt_Sabatino);
            this.gbx_Horario.Controls.Add(this.rbt_Vespertino);
            this.gbx_Horario.Controls.Add(this.rbt_Matutino);
            this.gbx_Horario.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Horario.Location = new System.Drawing.Point(748, 133);
            this.gbx_Horario.Name = "gbx_Horario";
            this.gbx_Horario.Size = new System.Drawing.Size(200, 168);
            this.gbx_Horario.TabIndex = 8;
            this.gbx_Horario.TabStop = false;
            this.gbx_Horario.Text = "HORARIO";
            // 
            // rbt_Matutino
            // 
            this.rbt_Matutino.AutoSize = true;
            this.rbt_Matutino.Location = new System.Drawing.Point(65, 38);
            this.rbt_Matutino.Name = "rbt_Matutino";
            this.rbt_Matutino.Size = new System.Drawing.Size(90, 24);
            this.rbt_Matutino.TabIndex = 0;
            this.rbt_Matutino.TabStop = true;
            this.rbt_Matutino.Text = "MATUTINO";
            this.rbt_Matutino.UseVisualStyleBackColor = true;
            // 
            // rbt_Vespertino
            // 
            this.rbt_Vespertino.AutoSize = true;
            this.rbt_Vespertino.Location = new System.Drawing.Point(65, 72);
            this.rbt_Vespertino.Name = "rbt_Vespertino";
            this.rbt_Vespertino.Size = new System.Drawing.Size(103, 24);
            this.rbt_Vespertino.TabIndex = 1;
            this.rbt_Vespertino.TabStop = true;
            this.rbt_Vespertino.Text = "VESPERTINO";
            this.rbt_Vespertino.UseVisualStyleBackColor = true;
            // 
            // rbt_Sabatino
            // 
            this.rbt_Sabatino.AutoSize = true;
            this.rbt_Sabatino.Location = new System.Drawing.Point(65, 108);
            this.rbt_Sabatino.Name = "rbt_Sabatino";
            this.rbt_Sabatino.Size = new System.Drawing.Size(87, 24);
            this.rbt_Sabatino.TabIndex = 2;
            this.rbt_Sabatino.TabStop = true;
            this.rbt_Sabatino.Text = "SABATINO";
            this.rbt_Sabatino.UseVisualStyleBackColor = true;
            // 
            // Form_Escuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 368);
            this.Controls.Add(this.gbx_Horario);
            this.Controls.Add(this.lbl_limpiar);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.btn_costo);
            this.Controls.Add(this.lbl_seleccionacursos);
            this.Controls.Add(this.gbx_cursos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_ingresatunombre);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Escuela";
            this.Text = "Escuela de cursos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_cursos.ResumeLayout(false);
            this.gbx_cursos.PerformLayout();
            this.gbx_Horario.ResumeLayout(false);
            this.gbx_Horario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_ingresatunombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox gbx_cursos;
        private System.Windows.Forms.CheckBox cbx_chinoma;
        private System.Windows.Forms.CheckBox cbx_frances;
        private System.Windows.Forms.CheckBox cbx_aleman;
        private System.Windows.Forms.CheckBox cbx_ingles;
        private System.Windows.Forms.Label lbl_seleccionacursos;
        private System.Windows.Forms.Button btn_costo;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Button lbl_limpiar;
        private System.Windows.Forms.GroupBox gbx_Horario;
        private System.Windows.Forms.RadioButton rbt_Sabatino;
        private System.Windows.Forms.RadioButton rbt_Vespertino;
        private System.Windows.Forms.RadioButton rbt_Matutino;
    }
}

