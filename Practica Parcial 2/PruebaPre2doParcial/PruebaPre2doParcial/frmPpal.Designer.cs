namespace PruebaPre2doParcial
{
    partial class frmPpal
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
            this.lbxIngreso = new System.Windows.Forms.ListBox();
            this.lbxEnCurso = new System.Windows.Forms.ListBox();
            this.lbxFinalizado = new System.Windows.Forms.ListBox();
            this.lbxListar = new System.Windows.Forms.ListBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxIngreso
            // 
            this.lbxIngreso.FormattingEnabled = true;
            this.lbxIngreso.Location = new System.Drawing.Point(12, 12);
            this.lbxIngreso.Name = "lbxIngreso";
            this.lbxIngreso.Size = new System.Drawing.Size(160, 147);
            this.lbxIngreso.TabIndex = 0;
            // 
            // lbxEnCurso
            // 
            this.lbxEnCurso.FormattingEnabled = true;
            this.lbxEnCurso.Location = new System.Drawing.Point(206, 12);
            this.lbxEnCurso.Name = "lbxEnCurso";
            this.lbxEnCurso.Size = new System.Drawing.Size(160, 147);
            this.lbxEnCurso.TabIndex = 1;
            // 
            // lbxFinalizado
            // 
            this.lbxFinalizado.FormattingEnabled = true;
            this.lbxFinalizado.Location = new System.Drawing.Point(402, 12);
            this.lbxFinalizado.Name = "lbxFinalizado";
            this.lbxFinalizado.Size = new System.Drawing.Size(160, 147);
            this.lbxFinalizado.TabIndex = 2;
            // 
            // lbxListar
            // 
            this.lbxListar.FormattingEnabled = true;
            this.lbxListar.Location = new System.Drawing.Point(12, 180);
            this.lbxListar.Name = "lbxListar";
            this.lbxListar.Size = new System.Drawing.Size(160, 147);
            this.lbxListar.TabIndex = 3;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(206, 248);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(160, 20);
            this.txtNro.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(402, 246);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 350);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lbxListar);
            this.Controls.Add(this.lbxFinalizado);
            this.Controls.Add(this.lbxEnCurso);
            this.Controls.Add(this.lbxIngreso);
            this.MaximizeBox = false;
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba Pre parcial";
            this.Load += new System.EventHandler(this.frmPpal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIngreso;
        private System.Windows.Forms.ListBox lbxEnCurso;
        private System.Windows.Forms.ListBox lbxFinalizado;
        private System.Windows.Forms.ListBox lbxListar;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Button btnIniciar;
    }
}

