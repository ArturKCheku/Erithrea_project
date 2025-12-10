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
            this.SuspendLayout();
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Location = new System.Drawing.Point(238, 172);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(158, 16);
            this.descrLabel.TabIndex = 0;
            this.descrLabel.Text = "Descripcio del problema:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(412, 137);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 22);
            this.txtDepartment.TabIndex = 1;
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.Location = new System.Drawing.Point(300, 137);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(96, 16);
            this.DepLabel.TabIndex = 2;
            this.DepLabel.Text = "Departamento:";
            // 
            // txtDescripcio
            // 
            this.txtDescripcio.Location = new System.Drawing.Point(412, 172);
            this.txtDescripcio.Multiline = true;
            this.txtDescripcio.Name = "txtDescripcio";
            this.txtDescripcio.Size = new System.Drawing.Size(194, 59);
            this.txtDescripcio.TabIndex = 3;
            // 
            // ReportB
            // 
            this.ReportB.Location = new System.Drawing.Point(303, 272);
            this.ReportB.Name = "ReportB";
            this.ReportB.Size = new System.Drawing.Size(75, 23);
            this.ReportB.TabIndex = 4;
            this.ReportB.Text = "Reportar";
            this.ReportB.UseVisualStyleBackColor = true;
            this.ReportB.Click += new System.EventHandler(this.ReportB_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(437, 272);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 5;
            this.CancelB.Text = "Cancelar";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // ReportIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 412);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.ReportB);
            this.Controls.Add(this.txtDescripcio);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.descrLabel);
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
    }
}