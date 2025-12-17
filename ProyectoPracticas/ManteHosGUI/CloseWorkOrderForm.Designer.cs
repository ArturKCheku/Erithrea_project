namespace ManteHosGUI
{
    partial class CloseWorkOrderForm
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
            this.dgvWorkOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsedParts = new System.Windows.Forms.DataGridView();
            this.lblCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepairReport = new System.Windows.Forms.TextBox();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkOrders
            // 
            this.dgvWorkOrders.AllowUserToAddRows = false;
            this.dgvWorkOrders.AllowUserToDeleteRows = false;
            this.dgvWorkOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWorkOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrders.Location = new System.Drawing.Point(16, 15);
            this.dgvWorkOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWorkOrders.MultiSelect = false;
            this.dgvWorkOrders.Name = "dgvWorkOrders";
            this.dgvWorkOrders.ReadOnly = true;
            this.dgvWorkOrders.RowHeadersWidth = 51;
            this.dgvWorkOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkOrders.Size = new System.Drawing.Size(547, 185);
            this.dgvWorkOrders.TabIndex = 0;
            this.dgvWorkOrders.SelectionChanged += new System.EventHandler(this.dgvWorkOrders_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(11, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalls de l\'ordre (Peces Utiliitzades)";
            // 
            // dgvUsedParts
            // 
            this.dgvUsedParts.AllowUserToAddRows = false;
            this.dgvUsedParts.AllowUserToDeleteRows = false;
            this.dgvUsedParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsedParts.Location = new System.Drawing.Point(16, 274);
            this.dgvUsedParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsedParts.MultiSelect = false;
            this.dgvUsedParts.Name = "dgvUsedParts";
            this.dgvUsedParts.ReadOnly = true;
            this.dgvUsedParts.RowHeadersWidth = 51;
            this.dgvUsedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsedParts.Size = new System.Drawing.Size(547, 185);
            this.dgvUsedParts.TabIndex = 2;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblCost.Location = new System.Drawing.Point(392, 539);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(171, 27);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost Total: 0.00€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label3.Location = new System.Drawing.Point(13, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe de Reparació";
            // 
            // txtRepairReport
            // 
            this.txtRepairReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRepairReport.Location = new System.Drawing.Point(16, 507);
            this.txtRepairReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepairReport.Multiline = true;
            this.txtRepairReport.Name = "txtRepairReport";
            this.txtRepairReport.Size = new System.Drawing.Size(368, 126);
            this.txtRepairReport.TabIndex = 5;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCloseOrder.Location = new System.Drawing.Point(363, 677);
            this.btnCloseOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(200, 42);
            this.btnCloseOrder.TabIndex = 6;
            this.btnCloseOrder.Text = "Tancar Ordre";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.White;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelBtn.Location = new System.Drawing.Point(38, 677);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(200, 42);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CloseWorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(609, 770);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.btnCloseOrder);
            this.Controls.Add(this.txtRepairReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.dgvUsedParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWorkOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CloseWorkOrderForm";
            this.Text = "CloseWorkOrderForm";
            this.Load += new System.EventHandler(this.CloseWorkOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsedParts;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepairReport;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Button CancelBtn;
    }
}