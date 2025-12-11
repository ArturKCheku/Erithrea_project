namespace ManteHosGUI
{
    partial class ReviewIncidentForm
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
            this.dgvIncidents = new System.Windows.Forms.DataGridView();
            this.grpAcceptData = new System.Windows.Forms.GroupBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAccept = new System.Windows.Forms.RadioButton();
            this.rbtReject = new System.Windows.Forms.RadioButton();
            this.grpRejectData = new System.Windows.Forms.GroupBox();
            this.txtRejectReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
            this.grpAcceptData.SuspendLayout();
            this.grpRejectData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncidents
            // 
            this.dgvIncidents.AllowUserToAddRows = false;
            this.dgvIncidents.AllowUserToDeleteRows = false;
            this.dgvIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidents.Location = new System.Drawing.Point(12, 12);
            this.dgvIncidents.MultiSelect = false;
            this.dgvIncidents.Name = "dgvIncidents";
            this.dgvIncidents.ReadOnly = true;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(368, 436);
            this.dgvIncidents.TabIndex = 0;
            // 
            // grpAcceptData
            // 
            this.grpAcceptData.Controls.Add(this.cbPriority);
            this.grpAcceptData.Controls.Add(this.label2);
            this.grpAcceptData.Controls.Add(this.cbArea);
            this.grpAcceptData.Controls.Add(this.label1);
            this.grpAcceptData.Location = new System.Drawing.Point(396, 188);
            this.grpAcceptData.Name = "grpAcceptData";
            this.grpAcceptData.Size = new System.Drawing.Size(240, 116);
            this.grpAcceptData.TabIndex = 1;
            this.grpAcceptData.TabStop = false;
            this.grpAcceptData.Text = "Aceptar";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(66, 60);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 21);
            this.cbPriority.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prioritat";
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(66, 25);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // rdbAccept
            // 
            this.rdbAccept.AutoSize = true;
            this.rdbAccept.Location = new System.Drawing.Point(460, 123);
            this.rdbAccept.Name = "rdbAccept";
            this.rdbAccept.Size = new System.Drawing.Size(103, 17);
            this.rdbAccept.TabIndex = 5;
            this.rdbAccept.Text = "Aceptar Incident";
            this.rdbAccept.UseVisualStyleBackColor = true;
            this.rdbAccept.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtReject
            // 
            this.rbtReject.AutoSize = true;
            this.rbtReject.Location = new System.Drawing.Point(743, 123);
            this.rbtReject.Name = "rbtReject";
            this.rbtReject.Size = new System.Drawing.Size(106, 17);
            this.rbtReject.TabIndex = 6;
            this.rbtReject.Text = "Rebutjar Incident";
            this.rbtReject.UseVisualStyleBackColor = true;
            this.rbtReject.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // grpRejectData
            // 
            this.grpRejectData.Controls.Add(this.txtRejectReason);
            this.grpRejectData.Controls.Add(this.label4);
            this.grpRejectData.Location = new System.Drawing.Point(661, 188);
            this.grpRejectData.Name = "grpRejectData";
            this.grpRejectData.Size = new System.Drawing.Size(262, 116);
            this.grpRejectData.TabIndex = 7;
            this.grpRejectData.TabStop = false;
            this.grpRejectData.Text = "Rebutjar";
            // 
            // txtRejectReason
            // 
            this.txtRejectReason.Location = new System.Drawing.Point(82, 25);
            this.txtRejectReason.Multiline = true;
            this.txtRejectReason.Name = "txtRejectReason";
            this.txtRejectReason.Size = new System.Drawing.Size(142, 68);
            this.txtRejectReason.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motiu";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(577, 362);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(137, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Preocessar Incidencia";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ReviewIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 460);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rbtReject);
            this.Controls.Add(this.grpRejectData);
            this.Controls.Add(this.rdbAccept);
            this.Controls.Add(this.grpAcceptData);
            this.Controls.Add(this.dgvIncidents);
            this.Name = "ReviewIncidentForm";
            this.Text = "ReviewIncidentForm";
            this.Load += new System.EventHandler(this.ReviewIncidentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
            this.grpAcceptData.ResumeLayout(false);
            this.grpAcceptData.PerformLayout();
            this.grpRejectData.ResumeLayout(false);
            this.grpRejectData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidents;
        private System.Windows.Forms.GroupBox grpAcceptData;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAccept;
        private System.Windows.Forms.RadioButton rbtReject;
        private System.Windows.Forms.GroupBox grpRejectData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtRejectReason;
    }
}