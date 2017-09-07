namespace Ej23
{
    partial class frmConversorDinero
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
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEur = new System.Windows.Forms.TextBox();
            this.btnConvertEur = new System.Windows.Forms.Button();
            this.txtEurToEur = new System.Windows.Forms.TextBox();
            this.txtEurToDls = new System.Windows.Forms.TextBox();
            this.txtEurToPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDlsToPeso = new System.Windows.Forms.TextBox();
            this.txtDlsToDls = new System.Windows.Forms.TextBox();
            this.txtDlsToEur = new System.Windows.Forms.TextBox();
            this.btnConvertDls = new System.Windows.Forms.Button();
            this.txtDls = new System.Windows.Forms.TextBox();
            this.txtPesoToPeso = new System.Windows.Forms.TextBox();
            this.txtPesoToDls = new System.Windows.Forms.TextBox();
            this.txtPesoToEur = new System.Windows.Forms.TextBox();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(12, 27);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 65);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 107);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // txtEur
            // 
            this.txtEur.Location = new System.Drawing.Point(47, 24);
            this.txtEur.Name = "txtEur";
            this.txtEur.Size = new System.Drawing.Size(100, 20);
            this.txtEur.TabIndex = 3;
            // 
            // btnConvertEur
            // 
            this.btnConvertEur.Location = new System.Drawing.Point(153, 22);
            this.btnConvertEur.Name = "btnConvertEur";
            this.btnConvertEur.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEur.TabIndex = 4;
            this.btnConvertEur.Text = "->";
            this.btnConvertEur.UseVisualStyleBackColor = true;
            this.btnConvertEur.Click += new System.EventHandler(this.btnConvertEur_Click);
            // 
            // txtEurToEur
            // 
            this.txtEurToEur.Enabled = false;
            this.txtEurToEur.Location = new System.Drawing.Point(234, 24);
            this.txtEurToEur.Name = "txtEurToEur";
            this.txtEurToEur.ReadOnly = true;
            this.txtEurToEur.Size = new System.Drawing.Size(100, 20);
            this.txtEurToEur.TabIndex = 5;
            // 
            // txtEurToDls
            // 
            this.txtEurToDls.Enabled = false;
            this.txtEurToDls.Location = new System.Drawing.Point(340, 24);
            this.txtEurToDls.Name = "txtEurToDls";
            this.txtEurToDls.ReadOnly = true;
            this.txtEurToDls.Size = new System.Drawing.Size(100, 20);
            this.txtEurToDls.TabIndex = 6;
            // 
            // txtEurToPeso
            // 
            this.txtEurToPeso.Enabled = false;
            this.txtEurToPeso.Location = new System.Drawing.Point(446, 24);
            this.txtEurToPeso.Name = "txtEurToPeso";
            this.txtEurToPeso.ReadOnly = true;
            this.txtEurToPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEurToPeso.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Peso";
            // 
            // txtDlsToPeso
            // 
            this.txtDlsToPeso.Enabled = false;
            this.txtDlsToPeso.Location = new System.Drawing.Point(446, 65);
            this.txtDlsToPeso.Name = "txtDlsToPeso";
            this.txtDlsToPeso.ReadOnly = true;
            this.txtDlsToPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDlsToPeso.TabIndex = 15;
            // 
            // txtDlsToDls
            // 
            this.txtDlsToDls.Enabled = false;
            this.txtDlsToDls.Location = new System.Drawing.Point(340, 65);
            this.txtDlsToDls.Name = "txtDlsToDls";
            this.txtDlsToDls.ReadOnly = true;
            this.txtDlsToDls.Size = new System.Drawing.Size(100, 20);
            this.txtDlsToDls.TabIndex = 14;
            // 
            // txtDlsToEur
            // 
            this.txtDlsToEur.Enabled = false;
            this.txtDlsToEur.Location = new System.Drawing.Point(234, 65);
            this.txtDlsToEur.Name = "txtDlsToEur";
            this.txtDlsToEur.ReadOnly = true;
            this.txtDlsToEur.Size = new System.Drawing.Size(100, 20);
            this.txtDlsToEur.TabIndex = 13;
            // 
            // btnConvertDls
            // 
            this.btnConvertDls.Location = new System.Drawing.Point(153, 63);
            this.btnConvertDls.Name = "btnConvertDls";
            this.btnConvertDls.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDls.TabIndex = 12;
            this.btnConvertDls.Text = "->";
            this.btnConvertDls.UseVisualStyleBackColor = true;
            this.btnConvertDls.Click += new System.EventHandler(this.btnConvertDls_Click);
            // 
            // txtDls
            // 
            this.txtDls.Location = new System.Drawing.Point(47, 65);
            this.txtDls.Name = "txtDls";
            this.txtDls.Size = new System.Drawing.Size(100, 20);
            this.txtDls.TabIndex = 11;
            // 
            // txtPesoToPeso
            // 
            this.txtPesoToPeso.Enabled = false;
            this.txtPesoToPeso.Location = new System.Drawing.Point(446, 104);
            this.txtPesoToPeso.Name = "txtPesoToPeso";
            this.txtPesoToPeso.ReadOnly = true;
            this.txtPesoToPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoToPeso.TabIndex = 20;
            // 
            // txtPesoToDls
            // 
            this.txtPesoToDls.Enabled = false;
            this.txtPesoToDls.Location = new System.Drawing.Point(340, 104);
            this.txtPesoToDls.Name = "txtPesoToDls";
            this.txtPesoToDls.ReadOnly = true;
            this.txtPesoToDls.Size = new System.Drawing.Size(100, 20);
            this.txtPesoToDls.TabIndex = 19;
            // 
            // txtPesoToEur
            // 
            this.txtPesoToEur.Enabled = false;
            this.txtPesoToEur.Location = new System.Drawing.Point(234, 104);
            this.txtPesoToEur.Name = "txtPesoToEur";
            this.txtPesoToEur.ReadOnly = true;
            this.txtPesoToEur.Size = new System.Drawing.Size(100, 20);
            this.txtPesoToEur.TabIndex = 18;
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(153, 102);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 17;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(47, 104);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 16;
            // 
            // frmConversorDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 153);
            this.Controls.Add(this.txtPesoToPeso);
            this.Controls.Add(this.txtPesoToDls);
            this.Controls.Add(this.txtPesoToEur);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDlsToPeso);
            this.Controls.Add(this.txtDlsToDls);
            this.Controls.Add(this.txtDlsToEur);
            this.Controls.Add(this.btnConvertDls);
            this.Controls.Add(this.txtDls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEurToPeso);
            this.Controls.Add(this.txtEurToDls);
            this.Controls.Add(this.txtEurToEur);
            this.Controls.Add(this.btnConvertEur);
            this.Controls.Add(this.txtEur);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Name = "frmConversorDinero";
            this.Text = "Conversor Dinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtEur;
        private System.Windows.Forms.Button btnConvertEur;
        private System.Windows.Forms.TextBox txtEurToEur;
        private System.Windows.Forms.TextBox txtEurToDls;
        private System.Windows.Forms.TextBox txtEurToPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDlsToPeso;
        private System.Windows.Forms.TextBox txtDlsToDls;
        private System.Windows.Forms.TextBox txtDlsToEur;
        private System.Windows.Forms.Button btnConvertDls;
        private System.Windows.Forms.TextBox txtDls;
        private System.Windows.Forms.TextBox txtPesoToPeso;
        private System.Windows.Forms.TextBox txtPesoToDls;
        private System.Windows.Forms.TextBox txtPesoToEur;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox txtPeso;
    }
}

