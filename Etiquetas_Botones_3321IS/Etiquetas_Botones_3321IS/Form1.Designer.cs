
namespace Etiquetas_Botones_3321IS
{
    partial class Form1
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
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_MOSTRAR = new System.Windows.Forms.Button();
            this.btn_MouseEnter = new System.Windows.Forms.Button();
            this.btn_MouseDown = new System.Windows.Forms.Button();
            this.lbl_MouseDown = new System.Windows.Forms.Label();
            this.btn_MouseHover = new System.Windows.Forms.Button();
            this.btn_MouseMove = new System.Windows.Forms.Button();
            this.btn_MouseWheel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensaje.Font = new System.Drawing.Font("Error", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(126, -1);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(564, 59);
            this.lbl_mensaje.TabIndex = 0;
            this.lbl_mensaje.Text = "BIENVENIDOS 3321IS";
            this.lbl_mensaje.Visible = false;
            this.lbl_mensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_MOSTRAR
            // 
            this.btn_MOSTRAR.Font = new System.Drawing.Font("Sunday Morning", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MOSTRAR.Location = new System.Drawing.Point(12, 174);
            this.btn_MOSTRAR.Name = "btn_MOSTRAR";
            this.btn_MOSTRAR.Size = new System.Drawing.Size(116, 41);
            this.btn_MOSTRAR.TabIndex = 1;
            this.btn_MOSTRAR.Text = "MOSTRAR";
            this.btn_MOSTRAR.UseVisualStyleBackColor = true;
            this.btn_MOSTRAR.Click += new System.EventHandler(this.btn_MOSTRAR_Click);
            // 
            // btn_MouseEnter
            // 
            this.btn_MouseEnter.BackColor = System.Drawing.Color.Yellow;
            this.btn_MouseEnter.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MouseEnter.Location = new System.Drawing.Point(12, 221);
            this.btn_MouseEnter.Name = "btn_MouseEnter";
            this.btn_MouseEnter.Size = new System.Drawing.Size(305, 41);
            this.btn_MouseEnter.TabIndex = 2;
            this.btn_MouseEnter.Text = "MouseEnter && MouseLeave";
            this.btn_MouseEnter.UseVisualStyleBackColor = false;
            this.btn_MouseEnter.MouseEnter += new System.EventHandler(this.btn_MouseEnter_MouseEnter);
            this.btn_MouseEnter.MouseLeave += new System.EventHandler(this.btn_MouseEnter_MouseLeave);
            // 
            // btn_MouseDown
            // 
            this.btn_MouseDown.BackColor = System.Drawing.Color.Olive;
            this.btn_MouseDown.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MouseDown.Location = new System.Drawing.Point(12, 268);
            this.btn_MouseDown.Name = "btn_MouseDown";
            this.btn_MouseDown.Size = new System.Drawing.Size(359, 41);
            this.btn_MouseDown.TabIndex = 3;
            this.btn_MouseDown.Text = "MouseDown && MouseUp";
            this.btn_MouseDown.UseVisualStyleBackColor = false;
            this.btn_MouseDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown_MouseDown);
            this.btn_MouseDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown_MouseUp);
            // 
            // lbl_MouseDown
            // 
            this.lbl_MouseDown.BackColor = System.Drawing.Color.White;
            this.lbl_MouseDown.Font = new System.Drawing.Font("GOOD PEOPLE", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MouseDown.Location = new System.Drawing.Point(524, 334);
            this.lbl_MouseDown.Name = "lbl_MouseDown";
            this.lbl_MouseDown.Size = new System.Drawing.Size(166, 37);
            this.lbl_MouseDown.TabIndex = 4;
            this.lbl_MouseDown.Text = "MouseDown";
            this.lbl_MouseDown.Visible = false;
            // 
            // btn_MouseHover
            // 
            this.btn_MouseHover.BackColor = System.Drawing.Color.Turquoise;
            this.btn_MouseHover.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MouseHover.Location = new System.Drawing.Point(12, 315);
            this.btn_MouseHover.Name = "btn_MouseHover";
            this.btn_MouseHover.Size = new System.Drawing.Size(190, 41);
            this.btn_MouseHover.TabIndex = 5;
            this.btn_MouseHover.Text = "MouseHover";
            this.btn_MouseHover.UseVisualStyleBackColor = false;
            this.btn_MouseHover.MouseHover += new System.EventHandler(this.btn_MouseHover_MouseHover);
            // 
            // btn_MouseMove
            // 
            this.btn_MouseMove.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_MouseMove.Font = new System.Drawing.Font("Karmatic Arcade", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MouseMove.Location = new System.Drawing.Point(12, 362);
            this.btn_MouseMove.Name = "btn_MouseMove";
            this.btn_MouseMove.Size = new System.Drawing.Size(190, 41);
            this.btn_MouseMove.TabIndex = 6;
            this.btn_MouseMove.Text = "MouseMove";
            this.btn_MouseMove.UseVisualStyleBackColor = false;
            this.btn_MouseMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove_MouseMove);
            // 
            // btn_MouseWheel
            // 
            this.btn_MouseWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_MouseWheel.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MouseWheel.Location = new System.Drawing.Point(136, 173);
            this.btn_MouseWheel.Name = "btn_MouseWheel";
            this.btn_MouseWheel.Size = new System.Drawing.Size(190, 41);
            this.btn_MouseWheel.TabIndex = 7;
            this.btn_MouseWheel.Text = "MouseWheel";
            this.btn_MouseWheel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etiquetas_Botones_3321IS.Properties.Resources._57711_gta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MouseWheel);
            this.Controls.Add(this.btn_MouseMove);
            this.Controls.Add(this.btn_MouseHover);
            this.Controls.Add(this.lbl_MouseDown);
            this.Controls.Add(this.btn_MouseDown);
            this.Controls.Add(this.btn_MouseEnter);
            this.Controls.Add(this.btn_MOSTRAR);
            this.Controls.Add(this.lbl_mensaje);
            this.Name = "Form1";
            this.Text = "INICIO_3321IS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button btn_MOSTRAR;
        private System.Windows.Forms.Button btn_MouseEnter;
        private System.Windows.Forms.Button btn_MouseDown;
        private System.Windows.Forms.Label lbl_MouseDown;
        private System.Windows.Forms.Button btn_MouseHover;
        private System.Windows.Forms.Button btn_MouseMove;
        private System.Windows.Forms.Button btn_MouseWheel;
    }
}

