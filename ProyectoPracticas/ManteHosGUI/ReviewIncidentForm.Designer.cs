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
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
            this.grpAcceptData.SuspendLayout();
            this.grpRejectData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncidents
            // 
            this.dgvIncidents.AllowUserToAddRows = false;
            this.dgvIncidents.AllowUserToDeleteRows = false;
            this.dgvIncidents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidents.Location = new System.Drawing.Point(11, 59);
            this.dgvIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIncidents.MultiSelect = false;
            this.dgvIncidents.Name = "dgvIncidents";
            this.dgvIncidents.ReadOnly = true;
            this.dgvIncidents.RowHeadersWidth = 51;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(703, 314);
            this.dgvIncidents.TabIndex = 0;
            // 
            // grpAcceptData
            // 
            this.grpAcceptData.Controls.Add(this.cbPriority);
            this.grpAcceptData.Controls.Add(this.label2);
            this.grpAcceptData.Controls.Add(this.cbArea);
            this.grpAcceptData.Controls.Add(this.label1);
            this.grpAcceptData.Location = new System.Drawing.Point(16, 489);
            this.grpAcceptData.Margin = new System.Windows.Forms.Padding(4);
            this.grpAcceptData.Name = "grpAcceptData";
            this.grpAcceptData.Padding = new System.Windows.Forms.Padding(4);
            this.grpAcceptData.Size = new System.Drawing.Size(320, 143);
            this.grpAcceptData.TabIndex = 1;
            this.grpAcceptData.TabStop = false;
            this.grpAcceptData.Text = "Aceptar";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(88, 74);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(160, 24);
            this.cbPriority.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prioritat";
            // 
            // cbArea
            // 
            this.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(88, 31);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(160, 24);
            this.cbArea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // rdbAccept
            // 
            this.rdbAccept.AutoSize = true;
            this.rdbAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbAccept.Location = new System.Drawing.Point(90, 409);
            this.rdbAccept.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAccept.Name = "rdbAccept";
            this.rdbAccept.Size = new System.Drawing.Size(174, 29);
            this.rdbAccept.TabIndex = 5;
            this.rdbAccept.Text = "Aceptar Incident";
            this.rdbAccept.UseVisualStyleBackColor = true;
            this.rdbAccept.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtReject
            // 
            this.rbtReject.AutoSize = true;
            this.rbtReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtReject.Location = new System.Drawing.Point(440, 409);
            this.rbtReject.Margin = new System.Windows.Forms.Padding(4);
            this.rbtReject.Name = "rbtReject";
            this.rbtReject.Size = new System.Drawing.Size(178, 29);
            this.rbtReject.TabIndex = 6;
            this.rbtReject.Text = "Rebutjar Incident";
            this.rbtReject.UseVisualStyleBackColor = true;
            this.rbtReject.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // grpRejectData
            // 
            this.grpRejectData.Controls.Add(this.txtRejectReason);
            this.grpRejectData.Controls.Add(this.label4);
            this.grpRejectData.Location = new System.Drawing.Point(369, 489);
            this.grpRejectData.Margin = new System.Windows.Forms.Padding(4);
            this.grpRejectData.Name = "grpRejectData";
            this.grpRejectData.Padding = new System.Windows.Forms.Padding(4);
            this.grpRejectData.Size = new System.Drawing.Size(349, 143);
            this.grpRejectData.TabIndex = 7;
            this.grpRejectData.TabStop = false;
            this.grpRejectData.Text = "Rebutjar";
            // 
            // txtRejectReason
            // 
            this.txtRejectReason.Location = new System.Drawing.Point(91, 37);
            this.txtRejectReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtRejectReason.Multiline = true;
            this.txtRejectReason.Name = "txtRejectReason";
            this.txtRejectReason.Size = new System.Drawing.Size(188, 83);
            this.txtRejectReason.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motiu";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProcess.Location = new System.Drawing.Point(460, 668);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(203, 44);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Processar Incidencia";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelBtn.Location = new System.Drawing.Point(69, 668);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(195, 44);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReviewIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(729, 754);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rbtReject);
            this.Controls.Add(this.grpRejectData);
            this.Controls.Add(this.rdbAccept);
            this.Controls.Add(this.grpAcceptData);
            this.Controls.Add(this.dgvIncidents);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtRejectReason;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button CancelBtn;
    }
}