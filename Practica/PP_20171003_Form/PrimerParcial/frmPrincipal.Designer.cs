namespace PrimerParcial
{
    partial class frmPrincipal
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
            this.btnMesa = new System.Windows.Forms.Button();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.lstComensales = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesa
            // 
            this.btnMesa.Location = new System.Drawing.Point(171, 24);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(52, 23);
            this.btnMesa.TabIndex = 0;
            this.btnMesa.Text = "Nueva";
            this.btnMesa.UseVisualStyleBackColor = true;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // cmbMesas
            // 
            this.cmbMesas.FormattingEnabled = true;
            this.cmbMesas.Location = new System.Drawing.Point(35, 24);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.Size = new System.Drawing.Size(121, 21);
            this.cmbMesas.TabIndex = 1;
            this.cmbMesas.SelectedIndexChanged += new System.EventHandler(this.cmbMesas_SelectedIndexChanged);
            // 
            // lstComensales
            // 
            this.lstComensales.FormattingEnabled = true;
            this.lstComensales.Location = new System.Drawing.Point(35, 80);
            this.lstComensales.Name = "lstComensales";
            this.lstComensales.Size = new System.Drawing.Size(188, 173);
            this.lstComensales.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(35, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Comensal";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 284);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstComensales);
            this.Controls.Add(this.cmbMesas);
            this.Controls.Add(this.btnMesa);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.ListBox lstComensales;
        private System.Windows.Forms.Button btnAgregar;
    }
}