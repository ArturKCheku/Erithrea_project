namespace ManteHosGUI
{
    partial class ReportIncidentForm
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
            this.descrLabel = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.DepLabel = new System.Windows.Forms.Label();
            this.txtDescripcio = new System.Windows.Forms.TextBox();
            this.ReportB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.RestriccioDep = new System.Windows.Forms.Label();
            this.RestriccioDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descrLabel
            // 
            this.descrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descrLabel.AutoSize = true;
            this.descrLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrLabel.Location = new System.Drawing.Point(50, 194);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(158, 31);
            this.descrLabel.TabIndex = 0;
            this.descrLabel.Text = "Descripció*:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDepartment.Location = new System.Drawing.Point(54, 114);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.MinimumSize = new System.Drawing.Size(237, 20);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(415, 30);
            this.txtDepartment.TabIndex = 1;
            this.txtDepartment.TextChanged += new System.EventHandler(this.ValidarTexto);
            // 
            // DepLabel
            // 
            this.DepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepLabel.AutoSize = true;
            this.DepLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepLabel.Location = new System.Drawing.Point(50, 78);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(194, 31);
            this.DepLabel.TabIndex = 2;
            this.DepLabel.Text = "Departament*:";
            this.DepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcio
            // 
            this.txtDescripcio.AllowDrop = true;
            this.txtDescripcio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcio.Location = new System.Drawing.Point(54, 231);
            this.txtDescripcio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcio.MinimumSize = new System.Drawing.Size(237, 73);
            this.txtDescripcio.Multiline = true;
            this.txtDescripcio.Name = "txtDescripcio";
            this.txtDescripcio.Size = new System.Drawing.Size(597, 238);
            this.txtDescripcio.TabIndex = 3;
            this.txtDescripcio.TextChanged += new System.EventHandler(this.ValidarTexto);
            // 
            // ReportB
            // 
            this.ReportB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReportB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ReportB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReportB.ForeColor = System.Drawing.Color.Black;
            this.ReportB.Location = new System.Drawing.Point(496, 526);
            this.ReportB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportB.MinimumSize = new System.Drawing.Size(134, 55);
            this.ReportB.Name = "ReportB";
            this.ReportB.Size = new System.Drawing.Size(134, 55);
            this.ReportB.TabIndex = 4;
            this.ReportB.Text = "Reportar";
            this.ReportB.UseVisualStyleBackColor = false;
            this.ReportB.TextChanged += new System.EventHandler(this.ValidarTexto);
            this.ReportB.Click += new System.EventHandler(this.ReportB_Click);
            // 
            // CancelB
            // 
            this.CancelB.BackColor = System.Drawing.Color.White;
            this.CancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelB.Location = new System.Drawing.Point(104, 526);
            this.CancelB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelB.MinimumSize = new System.Drawing.Size(134, 55);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(134, 55);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancelar";
            this.CancelB.UseVisualStyleBackColor = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // RestriccioDep
            // 
            this.RestriccioDep.AutoSize = true;
            this.RestriccioDep.ForeColor = System.Drawing.Color.Red;
            this.RestriccioDep.Location = new System.Drawing.Point(55, 152);
            this.RestriccioDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccioDep.Name = "RestriccioDep";
            this.RestriccioDep.Size = new System.Drawing.Size(85, 20);
            this.RestriccioDep.TabIndex = 6;
            this.RestriccioDep.Text = "Restricció*";
            this.RestriccioDep.Visible = false;
            // 
            // RestriccioDesc
            // 
            this.RestriccioDesc.AutoSize = true;
            this.RestriccioDesc.ForeColor = System.Drawing.Color.Red;
            this.RestriccioDesc.Location = new System.Drawing.Point(55, 474);
            this.RestriccioDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccioDesc.Name = "RestriccioDesc";
            this.RestriccioDesc.Size = new System.Drawing.Size(85, 20);
            this.RestriccioDesc.TabIndex = 7;
            this.RestriccioDesc.Text = "Restricció*";
            this.RestriccioDesc.Visible = false;
            // 
            // ReportIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(708, 615);
            this.Controls.Add(this.RestriccioDesc);
            this.Controls.Add(this.RestriccioDep);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.ReportB);
            this.Controls.Add(this.txtDescripcio);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.descrLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportIncidentForm";
            this.Text = "ReportIncidentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.TextBox txtDescripcio;
        private System.Windows.Forms.Button ReportB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label RestriccioDep;
        private System.Windows.Forms.Label RestriccioDesc;
    }
}