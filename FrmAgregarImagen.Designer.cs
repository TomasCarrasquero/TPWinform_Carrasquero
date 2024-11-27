namespace TPWinform_Carrasquero
{
    partial class FrmAgregarImagen
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
            this.lblImagen1 = new System.Windows.Forms.Label();
            this.lblImagen2 = new System.Windows.Forms.Label();
            this.lblImagen3 = new System.Windows.Forms.Label();
            this.txtBoxImagen1 = new System.Windows.Forms.TextBox();
            this.txtBoxImagen2 = new System.Windows.Forms.TextBox();
            this.txtBoxImagen3 = new System.Windows.Forms.TextBox();
            this.btnGuardarImagenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImagen1
            // 
            this.lblImagen1.AutoSize = true;
            this.lblImagen1.Location = new System.Drawing.Point(38, 52);
            this.lblImagen1.Name = "lblImagen1";
            this.lblImagen1.Size = new System.Drawing.Size(62, 16);
            this.lblImagen1.TabIndex = 4;
            this.lblImagen1.Text = "Imagen 1";
            // 
            // lblImagen2
            // 
            this.lblImagen2.AutoSize = true;
            this.lblImagen2.Location = new System.Drawing.Point(38, 94);
            this.lblImagen2.Name = "lblImagen2";
            this.lblImagen2.Size = new System.Drawing.Size(62, 16);
            this.lblImagen2.TabIndex = 5;
            this.lblImagen2.Text = "Imagen 2";
            this.lblImagen2.Click += new System.EventHandler(this.lblImagen2_Click);
            // 
            // lblImagen3
            // 
            this.lblImagen3.AutoSize = true;
            this.lblImagen3.Location = new System.Drawing.Point(38, 141);
            this.lblImagen3.Name = "lblImagen3";
            this.lblImagen3.Size = new System.Drawing.Size(62, 16);
            this.lblImagen3.TabIndex = 6;
            this.lblImagen3.Text = "Imagen 3";
            // 
            // txtBoxImagen1
            // 
            this.txtBoxImagen1.Location = new System.Drawing.Point(131, 49);
            this.txtBoxImagen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxImagen1.Name = "txtBoxImagen1";
            this.txtBoxImagen1.Size = new System.Drawing.Size(657, 22);
            this.txtBoxImagen1.TabIndex = 7;
            // 
            // txtBoxImagen2
            // 
            this.txtBoxImagen2.Location = new System.Drawing.Point(131, 94);
            this.txtBoxImagen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxImagen2.Name = "txtBoxImagen2";
            this.txtBoxImagen2.Size = new System.Drawing.Size(657, 22);
            this.txtBoxImagen2.TabIndex = 8;
            this.txtBoxImagen2.TextChanged += new System.EventHandler(this.txtBoxImagen2_TextChanged);
            // 
            // txtBoxImagen3
            // 
            this.txtBoxImagen3.Location = new System.Drawing.Point(131, 141);
            this.txtBoxImagen3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxImagen3.Name = "txtBoxImagen3";
            this.txtBoxImagen3.Size = new System.Drawing.Size(657, 22);
            this.txtBoxImagen3.TabIndex = 9;
            // 
            // btnGuardarImagenes
            // 
            this.btnGuardarImagenes.Location = new System.Drawing.Point(313, 182);
            this.btnGuardarImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarImagenes.Name = "btnGuardarImagenes";
            this.btnGuardarImagenes.Size = new System.Drawing.Size(91, 23);
            this.btnGuardarImagenes.TabIndex = 10;
            this.btnGuardarImagenes.Text = "Guardar";
            this.btnGuardarImagenes.UseVisualStyleBackColor = true;
            this.btnGuardarImagenes.Click += new System.EventHandler(this.btnGuardarImagenes_Click);
            // 
            // FrmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.btnGuardarImagenes);
            this.Controls.Add(this.txtBoxImagen3);
            this.Controls.Add(this.txtBoxImagen2);
            this.Controls.Add(this.txtBoxImagen1);
            this.Controls.Add(this.lblImagen3);
            this.Controls.Add(this.lblImagen2);
            this.Controls.Add(this.lblImagen1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 273);
            this.MinimumSize = new System.Drawing.Size(818, 273);
            this.Name = "FrmAgregarImagen";
            this.Text = "FrmAgregarImagen";
            this.Load += new System.EventHandler(this.FrmAgregarImagen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImagen1;
        private System.Windows.Forms.Label lblImagen2;
        private System.Windows.Forms.Label lblImagen3;
        private System.Windows.Forms.TextBox txtBoxImagen1;
        private System.Windows.Forms.TextBox txtBoxImagen2;
        private System.Windows.Forms.TextBox txtBoxImagen3;
        private System.Windows.Forms.Button btnGuardarImagenes;
    }
}