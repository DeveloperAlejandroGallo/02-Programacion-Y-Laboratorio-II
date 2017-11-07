namespace Ej62
{
    partial class frmEj62
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
            this.components = new System.ComponentModel.Container();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(12, 41);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(449, 307);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // frmEj62
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 360);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "frmEj62";
            this.Text = "Ej62";
            this.Load += new System.EventHandler(this.frmEj62_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Timer time;
    }
}

