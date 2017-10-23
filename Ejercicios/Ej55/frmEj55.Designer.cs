namespace Ej55
{
    partial class frmArchivos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statCantidadCaracteres = new System.Windows.Forms.StatusStrip();
            this.rtbtexto = new System.Windows.Forms.RichTextBox();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statCantidadCaracteres.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrir,
            this.mnuGuardar,
            this.mnuGuardarComo});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.ShortcutKeyDisplayString = "Ctrl + A";
            this.mnuAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAbrir.Size = new System.Drawing.Size(243, 22);
            this.mnuAbrir.Text = "&Abrir";
            this.mnuAbrir.Click += new System.EventHandler(this.mnuAbrir_Click);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.ShortcutKeyDisplayString = "Ctrl + S";
            this.mnuGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuGuardar.Size = new System.Drawing.Size(243, 22);
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuGuardarComo
            // 
            this.mnuGuardarComo.Name = "mnuGuardarComo";
            this.mnuGuardarComo.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            this.mnuGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuGuardarComo.Size = new System.Drawing.Size(243, 22);
            this.mnuGuardarComo.Text = "Gaurdar como...";
            this.mnuGuardarComo.Click += new System.EventHandler(this.mnuGuardarComo_Click);
            // 
            // statCantidadCaracteres
            // 
            this.statCantidadCaracteres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statCantidadCaracteres.Location = new System.Drawing.Point(0, 302);
            this.statCantidadCaracteres.Name = "statCantidadCaracteres";
            this.statCantidadCaracteres.Size = new System.Drawing.Size(380, 22);
            this.statCantidadCaracteres.TabIndex = 1;
            // 
            // rtbtexto
            // 
            this.rtbtexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbtexto.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbtexto.Location = new System.Drawing.Point(0, 24);
            this.rtbtexto.Name = "rtbtexto";
            this.rtbtexto.Size = new System.Drawing.Size(380, 278);
            this.rtbtexto.TabIndex = 2;
            this.rtbtexto.Text = "";
            this.rtbtexto.TextChanged += new System.EventHandler(this.rtbtexto_TextChanged);
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // frmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 324);
            this.Controls.Add(this.rtbtexto);
            this.Controls.Add(this.statCantidadCaracteres);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmArchivos";
            this.Text = "Ej55";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statCantidadCaracteres.ResumeLayout(false);
            this.statCantidadCaracteres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarComo;
        private System.Windows.Forms.StatusStrip statCantidadCaracteres;
        private System.Windows.Forms.RichTextBox rtbtexto;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
    }
}

