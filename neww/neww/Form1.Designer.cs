
namespace neww
{
    partial class frm_Conversores
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
            this.gbx_Covercionmonedas = new System.Windows.Forms.GroupBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lbl_Pesos = new System.Windows.Forms.Label();
            this.txt_Dolares = new System.Windows.Forms.TextBox();
            this.txt_Pesos = new System.Windows.Forms.TextBox();
            this.rbt_DolaresPesos = new System.Windows.Forms.RadioButton();
            this.rbt_PesoDolares = new System.Windows.Forms.RadioButton();
            this.btn_Conversor1 = new System.Windows.Forms.Button();
            this.gbx_Covercionmonedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Covercionmonedas
            // 
            this.gbx_Covercionmonedas.BackColor = System.Drawing.Color.DarkGray;
            this.gbx_Covercionmonedas.Controls.Add(this.btn_Conversor1);
            this.gbx_Covercionmonedas.Controls.Add(this.lblDolares);
            this.gbx_Covercionmonedas.Controls.Add(this.lbl_Pesos);
            this.gbx_Covercionmonedas.Controls.Add(this.txt_Dolares);
            this.gbx_Covercionmonedas.Controls.Add(this.txt_Pesos);
            this.gbx_Covercionmonedas.Controls.Add(this.rbt_DolaresPesos);
            this.gbx_Covercionmonedas.Controls.Add(this.rbt_PesoDolares);
            this.gbx_Covercionmonedas.Location = new System.Drawing.Point(38, 87);
            this.gbx_Covercionmonedas.Name = "gbx_Covercionmonedas";
            this.gbx_Covercionmonedas.Size = new System.Drawing.Size(290, 250);
            this.gbx_Covercionmonedas.TabIndex = 0;
            this.gbx_Covercionmonedas.TabStop = false;
            this.gbx_Covercionmonedas.Text = "CONVERCION DE MONEDADS";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(38, 160);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(64, 20);
            this.lblDolares.TabIndex = 4;
            this.lblDolares.Text = "DOLARES";
            // 
            // lbl_Pesos
            // 
            this.lbl_Pesos.AutoSize = true;
            this.lbl_Pesos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pesos.Location = new System.Drawing.Point(38, 129);
            this.lbl_Pesos.Name = "lbl_Pesos";
            this.lbl_Pesos.Size = new System.Drawing.Size(49, 20);
            this.lbl_Pesos.TabIndex = 1;
            this.lbl_Pesos.Text = "PESOS";
            // 
            // txt_Dolares
            // 
            this.txt_Dolares.Location = new System.Drawing.Point(125, 160);
            this.txt_Dolares.Name = "txt_Dolares";
            this.txt_Dolares.Size = new System.Drawing.Size(50, 20);
            this.txt_Dolares.TabIndex = 3;
            // 
            // txt_Pesos
            // 
            this.txt_Pesos.Location = new System.Drawing.Point(125, 126);
            this.txt_Pesos.Name = "txt_Pesos";
            this.txt_Pesos.Size = new System.Drawing.Size(50, 20);
            this.txt_Pesos.TabIndex = 2;
            // 
            // rbt_DolaresPesos
            // 
            this.rbt_DolaresPesos.AutoSize = true;
            this.rbt_DolaresPesos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_DolaresPesos.Location = new System.Drawing.Point(41, 81);
            this.rbt_DolaresPesos.Name = "rbt_DolaresPesos";
            this.rbt_DolaresPesos.Size = new System.Drawing.Size(129, 24);
            this.rbt_DolaresPesos.TabIndex = 1;
            this.rbt_DolaresPesos.Text = "Dolares - Pesos";
            this.rbt_DolaresPesos.UseVisualStyleBackColor = true;
            // 
            // rbt_PesoDolares
            // 
            this.rbt_PesoDolares.AutoSize = true;
            this.rbt_PesoDolares.Checked = true;
            this.rbt_PesoDolares.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_PesoDolares.Location = new System.Drawing.Point(41, 46);
            this.rbt_PesoDolares.Name = "rbt_PesoDolares";
            this.rbt_PesoDolares.Size = new System.Drawing.Size(121, 24);
            this.rbt_PesoDolares.TabIndex = 0;
            this.rbt_PesoDolares.TabStop = true;
            this.rbt_PesoDolares.Text = "Peso - Dolares";
            this.rbt_PesoDolares.UseVisualStyleBackColor = true;
            // 
            // btn_Conversor1
            // 
            this.btn_Conversor1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conversor1.Location = new System.Drawing.Point(98, 220);
            this.btn_Conversor1.Name = "btn_Conversor1";
            this.btn_Conversor1.Size = new System.Drawing.Size(99, 24);
            this.btn_Conversor1.TabIndex = 5;
            this.btn_Conversor1.Text = "CONVERTIR";
            this.btn_Conversor1.UseVisualStyleBackColor = true;
            // 
            // frm_Conversores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::neww.Properties.Resources.depositphotos_191075396_stock_photo_gold_coins_bitcoin_on_white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_Covercionmonedas);
            this.Name = "frm_Conversores";
            this.Text = "CONVERSOR";
            this.gbx_Covercionmonedas.ResumeLayout(false);
            this.gbx_Covercionmonedas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Covercionmonedas;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lbl_Pesos;
        private System.Windows.Forms.TextBox txt_Dolares;
        private System.Windows.Forms.TextBox txt_Pesos;
        private System.Windows.Forms.RadioButton rbt_DolaresPesos;
        private System.Windows.Forms.RadioButton rbt_PesoDolares;
        private System.Windows.Forms.Button btn_Conversor1;
    }
}

