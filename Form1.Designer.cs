namespace wAccesoDeDatos
{
    partial class Form1
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblFormativo = new System.Windows.Forms.Label();
            this.lblFormador = new System.Windows.Forms.Label();
            this.cmbFormativo = new System.Windows.Forms.ComboBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtFormador = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.asistenciaToolStripMenuItem.Text = "&Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(12, 95);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(97, 13);
            this.lblEvento.TabIndex = 1;
            this.lblEvento.Text = "Nombre del evento";
            // 
            // lblFormativo
            // 
            this.lblFormativo.AutoSize = true;
            this.lblFormativo.Location = new System.Drawing.Point(12, 52);
            this.lblFormativo.Name = "lblFormativo";
            this.lblFormativo.Size = new System.Drawing.Size(92, 13);
            this.lblFormativo.TabIndex = 2;
            this.lblFormativo.Text = "Proceso formativo";
            // 
            // lblFormador
            // 
            this.lblFormador.AutoSize = true;
            this.lblFormador.Location = new System.Drawing.Point(323, 52);
            this.lblFormador.Name = "lblFormador";
            this.lblFormador.Size = new System.Drawing.Size(51, 13);
            this.lblFormador.TabIndex = 3;
            this.lblFormador.Text = "Formador";
            // 
            // cmbFormativo
            // 
            this.cmbFormativo.FormattingEnabled = true;
            this.cmbFormativo.Location = new System.Drawing.Point(110, 49);
            this.cmbFormativo.Name = "cmbFormativo";
            this.cmbFormativo.Size = new System.Drawing.Size(207, 21);
            this.cmbFormativo.TabIndex = 4;
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(110, 92);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(201, 20);
            this.txtEvento.TabIndex = 5;
            // 
            // txtFormador
            // 
            this.txtFormador.Location = new System.Drawing.Point(380, 49);
            this.txtFormador.Name = "txtFormador";
            this.txtFormador.Size = new System.Drawing.Size(201, 20);
            this.txtFormador.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFormador);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.cmbFormativo);
            this.Controls.Add(this.lblFormador);
            this.Controls.Add(this.lblFormativo);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Procesos Formativos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblFormativo;
        private System.Windows.Forms.Label lblFormador;
        private System.Windows.Forms.ComboBox cmbFormativo;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtFormador;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

