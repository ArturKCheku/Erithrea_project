namespace ManteHosGUI
{
    partial class MainGUI
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarIncidenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarIncidenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarWorkOrdresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tancarWorkOrdresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.reportarIncidenciaToolStripMenuItem1,
            this.revisarIncidenciaToolStripMenuItem1,
            this.asignarWorkOrdresToolStripMenuItem1,
            this.tancarWorkOrdresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1356, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportarIncidenciaToolStripMenuItem1
            // 
            this.reportarIncidenciaToolStripMenuItem1.Name = "reportarIncidenciaToolStripMenuItem1";
            this.reportarIncidenciaToolStripMenuItem1.Size = new System.Drawing.Size(179, 29);
            this.reportarIncidenciaToolStripMenuItem1.Text = "Reportar Incidencia";
            this.reportarIncidenciaToolStripMenuItem1.Click += new System.EventHandler(this.reportarIncidenciaToolStripMenuItem_Click);
            // 
            // revisarIncidenciaToolStripMenuItem1
            // 
            this.revisarIncidenciaToolStripMenuItem1.Name = "revisarIncidenciaToolStripMenuItem1";
            this.revisarIncidenciaToolStripMenuItem1.Size = new System.Drawing.Size(166, 29);
            this.revisarIncidenciaToolStripMenuItem1.Text = "Revisar Incidencia";
            this.revisarIncidenciaToolStripMenuItem1.Click += new System.EventHandler(this.revisarIncidenciaToolStripMenuItem_Click);
            // 
            // asignarWorkOrdresToolStripMenuItem1
            // 
            this.asignarWorkOrdresToolStripMenuItem1.Name = "asignarWorkOrdresToolStripMenuItem1";
            this.asignarWorkOrdresToolStripMenuItem1.Size = new System.Drawing.Size(189, 29);
            this.asignarWorkOrdresToolStripMenuItem1.Text = "Asignar WorkOrdres";
            this.asignarWorkOrdresToolStripMenuItem1.Click += new System.EventHandler(this.asignarWorkOrdresToolStripMenuItem_Click);
            // 
            // tancarWorkOrdresToolStripMenuItem1
            // 
            this.tancarWorkOrdresToolStripMenuItem1.Name = "tancarWorkOrdresToolStripMenuItem1";
            this.tancarWorkOrdresToolStripMenuItem1.Size = new System.Drawing.Size(178, 29);
            this.tancarWorkOrdresToolStripMenuItem1.Text = "Tancar WorkOrdres";
            this.tancarWorkOrdresToolStripMenuItem1.Click += new System.EventHandler(this.tancarWorkOrdresToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F);
            this.lblWelcome.Location = new System.Drawing.Point(29, 205);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(483, 124);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F);
            this.lblRol.Location = new System.Drawing.Point(29, 367);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(202, 124);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1155, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(203, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Estat de la Xarxa: Conectat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::ManteHosGUI.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(808, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3495, 2995);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 652);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGUI";
            this.Text = "ManteHos App";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarIncidenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revisarIncidenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignarWorkOrdresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tancarWorkOrdresToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

