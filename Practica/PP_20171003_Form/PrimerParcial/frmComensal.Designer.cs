namespace PrimerParcial
{
    partial class frmComensal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.rdoMayor = new System.Windows.Forms.RadioButton();
            this.rdoMenor = new System.Windows.Forms.RadioButton();
            this.cmbEnum = new System.Windows.Forms.ComboBox();
            this.lblEnum = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ctnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // rdoMayor
            // 
            this.rdoMayor.AutoSize = true;
            this.rdoMayor.Checked = true;
            this.rdoMayor.Location = new System.Drawing.Point(29, 89);
            this.rdoMayor.Name = "rdoMayor";
            this.rdoMayor.Size = new System.Drawing.Size(54, 17);
            this.rdoMayor.TabIndex = 4;
            this.rdoMayor.TabStop = true;
            this.rdoMayor.Text = "Mayor";
            this.rdoMayor.UseVisualStyleBackColor = true;
            // 
            // rdoMenor
            // 
            this.rdoMenor.AutoSize = true;
            this.rdoMenor.Location = new System.Drawing.Point(140, 89);
            this.rdoMenor.Name = "rdoMenor";
            this.rdoMenor.Size = new System.Drawing.Size(55, 17);
            this.rdoMenor.TabIndex = 5;
            this.rdoMenor.Text = "Menor";
            this.rdoMenor.UseVisualStyleBackColor = true;
            this.rdoMenor.CheckedChanged += new System.EventHandler(this.rdoMenor_CheckedChanged);
            // 
            // cmbEnum
            // 
            this.cmbEnum.FormattingEnabled = true;
            this.cmbEnum.Location = new System.Drawing.Point(62, 127);
            this.cmbEnum.Name = "cmbEnum";
            this.cmbEnum.Size = new System.Drawing.Size(184, 21);
            this.cmbEnum.TabIndex = 6;
            // 
            // lblEnum
            // 
            this.lblEnum.AutoSize = true;
            this.lblEnum.Location = new System.Drawing.Point(16, 130);
            this.lblEnum.Name = "lblEnum";
            this.lblEnum.Size = new System.Drawing.Size(40, 13);
            this.lblEnum.TabIndex = 7;
            this.lblEnum.Text = "Bebida";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(171, 187);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ctnCancelar
            // 
            this.ctnCancelar.Location = new System.Drawing.Point(19, 187);
            this.ctnCancelar.Name = "ctnCancelar";
            this.ctnCancelar.Size = new System.Drawing.Size(75, 23);
            this.ctnCancelar.TabIndex = 9;
            this.ctnCancelar.Text = "cancelar";
            this.ctnCancelar.UseVisualStyleBackColor = true;
            this.ctnCancelar.Click += new System.EventHandler(this.ctnCancelar_Click);
            // 
            // frmComensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 247);
            this.Controls.Add(this.ctnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEnum);
            this.Controls.Add(this.cmbEnum);
            this.Controls.Add(this.rdoMenor);
            this.Controls.Add(this.rdoMayor);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmComensal";
            this.Text = "Comensal";
            this.Load += new System.EventHandler(this.frmComensal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.RadioButton rdoMayor;
        private System.Windows.Forms.RadioButton rdoMenor;
        private System.Windows.Forms.ComboBox cmbEnum;
        private System.Windows.Forms.Label lblEnum;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button ctnCancelar;
    }
}