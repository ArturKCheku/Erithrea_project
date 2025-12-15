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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jefesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarIncidenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarOrdreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tancarOrdresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.empleatsToolStripMenuItem,
            this.jefesToolStripMenuItem,
            this.maestreToolStripMenuItem,
            this.operarisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleatsToolStripMenuItem
            // 
            this.empleatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarIncidentToolStripMenuItem});
            this.empleatsToolStripMenuItem.Name = "empleatsToolStripMenuItem";
            this.empleatsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.empleatsToolStripMenuItem.Text = "Empleats";
            // 
            // reportarIncidentToolStripMenuItem
            // 
            this.reportarIncidentToolStripMenuItem.Name = "reportarIncidentToolStripMenuItem";
            this.reportarIncidentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.reportarIncidentToolStripMenuItem.Text = "Reportar Incident";
            this.reportarIncidentToolStripMenuItem.Click += new System.EventHandler(this.reportarIncidentToolStripMenuItem_Click);
            // 
            // jefesToolStripMenuItem
            // 
            this.jefesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarIncidenciesToolStripMenuItem});
            this.jefesToolStripMenuItem.Name = "jefesToolStripMenuItem";
            this.jefesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jefesToolStripMenuItem.Text = "Jefes";
            // 
            // revisarIncidenciesToolStripMenuItem
            // 
            this.revisarIncidenciesToolStripMenuItem.Name = "revisarIncidenciesToolStripMenuItem";
            this.revisarIncidenciesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.revisarIncidenciesToolStripMenuItem.Text = "Revisar Incidencies";
            this.revisarIncidenciesToolStripMenuItem.Click += new System.EventHandler(this.revisarIncidenciesToolStripMenuItem_Click);
            // 
            // maestreToolStripMenuItem
            // 
            this.maestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarOrdreToolStripMenuItem});
            this.maestreToolStripMenuItem.Name = "maestreToolStripMenuItem";
            this.maestreToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.maestreToolStripMenuItem.Text = "Maestre";
            // 
            // asignarOrdreToolStripMenuItem
            // 
            this.asignarOrdreToolStripMenuItem.Name = "asignarOrdreToolStripMenuItem";
            this.asignarOrdreToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.asignarOrdreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignarOrdreToolStripMenuItem.Text = "Asignar Ordres";
            this.asignarOrdreToolStripMenuItem.Click += new System.EventHandler(this.asignarOrdreToolStripMenuItem_Click);
            // 
            // operarisToolStripMenuItem
            // 
            this.operarisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tancarOrdresToolStripMenuItem});
            this.operarisToolStripMenuItem.Name = "operarisToolStripMenuItem";
            this.operarisToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.operarisToolStripMenuItem.Text = "Operaris";
            // 
            // tancarOrdresToolStripMenuItem
            // 
            this.tancarOrdresToolStripMenuItem.Name = "tancarOrdresToolStripMenuItem";
            this.tancarOrdresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tancarOrdresToolStripMenuItem.Text = "Tancar Ordres";
            this.tancarOrdresToolStripMenuItem.Click += new System.EventHandler(this.tancarOrdresToolStripMenuItem_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 424);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGUI";
            this.Text = "ManteHos App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jefesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarIncidenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarOrdreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tancarOrdresToolStripMenuItem;
    }
}

