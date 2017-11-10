namespace _20170727_Final
{
    partial class fmFinal
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
            this.btnEspecialista = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEspecialista
            // 
            this.btnEspecialista.Location = new System.Drawing.Point(12, 148);
            this.btnEspecialista.Name = "btnEspecialista";
            this.btnEspecialista.Size = new System.Drawing.Size(260, 130);
            this.btnEspecialista.TabIndex = 1;
            this.btnEspecialista.Text = "Atender Medico Especialista";
            this.btnEspecialista.UseVisualStyleBackColor = true;
            this.btnEspecialista.Click += new System.EventHandler(this.btnEspecialista_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(12, 12);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(260, 130);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "Atender Medico General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // fmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnEspecialista);
            this.MaximizeBox = false;
            this.Name = "fmFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final 20170727";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmFinal_FormClosing);
            this.Load += new System.EventHandler(this.fmFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEspecialista;
        private System.Windows.Forms.Button btnGeneral;
    }
}

