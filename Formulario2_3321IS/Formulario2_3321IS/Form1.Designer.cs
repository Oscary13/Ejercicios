
namespace Formulario2_3321IS
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Ingresanombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(346, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(188, 13);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "BIENVENIDO A LA ESCUELA 3321IS";
            // 
            // lbl_Ingresanombre
            // 
            this.lbl_Ingresanombre.AutoSize = true;
            this.lbl_Ingresanombre.Location = new System.Drawing.Point(22, 62);
            this.lbl_Ingresanombre.Name = "lbl_Ingresanombre";
            this.lbl_Ingresanombre.Size = new System.Drawing.Size(126, 13);
            this.lbl_Ingresanombre.TabIndex = 1;
            this.lbl_Ingresanombre.Text = "INGRESA TU NOMBRE ";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(25, 78);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(163, 20);
            this.txt_nombre.TabIndex = 2;
            
            // 
            // Form_Escuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_Ingresanombre);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form_Escuela";
            this.Text = "ESCUELA 3321IS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Ingresanombre;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}

