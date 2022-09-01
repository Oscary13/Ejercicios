
namespace Empleado
{
    partial class FromsEmpleado
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
            this.lblUsuario_E = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra_E = new System.Windows.Forms.Label();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario_E
            // 
            this.lblUsuario_E.AutoSize = true;
            this.lblUsuario_E.Location = new System.Drawing.Point(23, 29);
            this.lblUsuario_E.Name = "lblUsuario_E";
            this.lblUsuario_E.Size = new System.Drawing.Size(62, 13);
            this.lblUsuario_E.TabIndex = 0;
            this.lblUsuario_E.Text = "USUARIO :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(116, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContra_E
            // 
            this.lblContra_E.AutoSize = true;
            this.lblContra_E.Location = new System.Drawing.Point(23, 68);
            this.lblContra_E.Name = "lblContra_E";
            this.lblContra_E.Size = new System.Drawing.Size(87, 13);
            this.lblContra_E.TabIndex = 2;
            this.lblContra_E.Text = "CONTRASEÑA :";
            // 
            // txt_Contra
            // 
            this.txt_Contra.Location = new System.Drawing.Point(116, 65);
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.PasswordChar = '*';
            this.txt_Contra.Size = new System.Drawing.Size(139, 20);
            this.txt_Contra.TabIndex = 3;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(273, 44);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 25);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // FromsEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 138);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.lblContra_E);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario_E);
            this.Name = "FromsEmpleado";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.FromsEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario_E;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContra_E;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.Button btn_Ingresar;
    }
}

