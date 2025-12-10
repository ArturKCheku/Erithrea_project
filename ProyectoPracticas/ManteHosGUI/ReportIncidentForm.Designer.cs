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
            this.RestriccionsDep = new System.Windows.Forms.Label();
            this.RestriccionsDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descrLabel
            // 
            this.descrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descrLabel.AutoSize = true;
            this.descrLabel.Enabled = false;
            this.descrLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrLabel.Location = new System.Drawing.Point(44, 155);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(132, 27);
            this.descrLabel.TabIndex = 0;
            this.descrLabel.Text = "Descripció*:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDepartment.Location = new System.Drawing.Point(48, 91);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.MinimumSize = new System.Drawing.Size(211, 20);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(369, 26);
            this.txtDepartment.TabIndex = 1;
            // 
            // DepLabel
            // 
            this.DepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepLabel.AutoSize = true;
            this.DepLabel.Enabled = false;
            this.DepLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepLabel.Location = new System.Drawing.Point(44, 62);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(162, 27);
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
            this.txtDescripcio.Location = new System.Drawing.Point(48, 185);
            this.txtDescripcio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcio.MinimumSize = new System.Drawing.Size(211, 59);
            this.txtDescripcio.Multiline = true;
            this.txtDescripcio.Name = "txtDescripcio";
            this.txtDescripcio.Size = new System.Drawing.Size(531, 191);
            this.txtDescripcio.TabIndex = 3;
            // 
            // ReportB
            // 
            this.ReportB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportB.BackColor = System.Drawing.Color.Silver;
            this.ReportB.Cursor = System.Windows.Forms.Cursors.No;
            this.ReportB.Enabled = false;
            this.ReportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReportB.ForeColor = System.Drawing.Color.Gray;
            this.ReportB.Location = new System.Drawing.Point(441, 421);
            this.ReportB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportB.MinimumSize = new System.Drawing.Size(119, 44);
            this.ReportB.Name = "ReportB";
            this.ReportB.Size = new System.Drawing.Size(119, 44);
            this.ReportB.TabIndex = 4;
            this.ReportB.Text = "Reportar";
            this.ReportB.UseVisualStyleBackColor = false;
            this.ReportB.Click += new System.EventHandler(this.ReportB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelB.BackColor = System.Drawing.Color.White;
            this.CancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelB.Location = new System.Drawing.Point(92, 421);
            this.CancelB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelB.MinimumSize = new System.Drawing.Size(119, 44);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(119, 44);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancelar";
            this.CancelB.UseVisualStyleBackColor = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // RestriccionsDep
            // 
            this.RestriccionsDep.AutoSize = true;
            this.RestriccionsDep.ForeColor = System.Drawing.Color.Red;
            this.RestriccionsDep.Location = new System.Drawing.Point(49, 122);
            this.RestriccionsDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccionsDep.Name = "RestriccionsDep";
            this.RestriccionsDep.Size = new System.Drawing.Size(72, 16);
            this.RestriccionsDep.TabIndex = 6;
            this.RestriccionsDep.Text = "Restricció*";
            this.RestriccionsDep.Visible = false;
            // 
            // RestriccionsDesc
            // 
            this.RestriccionsDesc.AutoSize = true;
            this.RestriccionsDesc.ForeColor = System.Drawing.Color.Red;
            this.RestriccionsDesc.Location = new System.Drawing.Point(49, 379);
            this.RestriccionsDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccionsDesc.Name = "RestriccionsDesc";
            this.RestriccionsDesc.Size = new System.Drawing.Size(72, 16);
            this.RestriccionsDesc.TabIndex = 7;
            this.RestriccionsDesc.Text = "Restricció*";
            this.RestriccionsDesc.Visible = false;
            // 
            // ReportIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(629, 492);
            this.Controls.Add(this.RestriccionsDesc);
            this.Controls.Add(this.RestriccionsDep);
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
        private System.Windows.Forms.Label RestriccionsDep;
        private System.Windows.Forms.Label RestriccionsDesc;
    }
}