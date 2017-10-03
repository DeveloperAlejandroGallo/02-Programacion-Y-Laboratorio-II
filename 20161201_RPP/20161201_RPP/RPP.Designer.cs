namespace _20161201_RPP
{
    partial class RPP
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
            this.btnPruebaClase = new System.Windows.Forms.Button();
            this.btnMostarSalida = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPruebaClase
            // 
            this.btnPruebaClase.Location = new System.Drawing.Point(0, 0);
            this.btnPruebaClase.Name = "btnPruebaClase";
            this.btnPruebaClase.Size = new System.Drawing.Size(500, 93);
            this.btnPruebaClase.TabIndex = 0;
            this.btnPruebaClase.Text = "Prueba Clases";
            this.btnPruebaClase.UseVisualStyleBackColor = true;
            this.btnPruebaClase.Click += new System.EventHandler(this.btnPruebaClase_Click);
            // 
            // btnMostarSalida
            // 
            this.btnMostarSalida.Location = new System.Drawing.Point(0, 99);
            this.btnMostarSalida.Name = "btnMostarSalida";
            this.btnMostarSalida.Size = new System.Drawing.Size(500, 88);
            this.btnMostarSalida.TabIndex = 1;
            this.btnMostarSalida.Text = "Mostrar Salida Por Pantalla";
            this.btnMostarSalida.UseVisualStyleBackColor = true;
            this.btnMostarSalida.Click += new System.EventHandler(this.btnMostarSalida_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(0, 193);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(500, 236);
            this.txtSalida.TabIndex = 2;
            // 
            // RPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 441);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnMostarSalida);
            this.Controls.Add(this.btnPruebaClase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RPP";
            this.Text = "RPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaClase;
        private System.Windows.Forms.Button btnMostarSalida;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

