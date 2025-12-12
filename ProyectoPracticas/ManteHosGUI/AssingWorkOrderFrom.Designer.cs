namespace ManteHosGUI
{
    partial class AssingWorkOrderFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOperators = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
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
            this.dgvIncidents.RowHeadersVisible = false;
            this.dgvIncidents.RowHeadersWidth = 51;
            this.dgvIncidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncidents.Size = new System.Drawing.Size(499, 211);
            this.dgvIncidents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar:";
            // 
            // cbOperators
            // 
            this.cbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperators.FormattingEnabled = true;
            this.cbOperators.Location = new System.Drawing.Point(240, 317);
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.Size = new System.Drawing.Size(121, 21);
            this.cbOperators.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(137, 395);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnQuit.Size = new System.Drawing.Size(113, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Retirar Operari";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(285, 395);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(113, 23);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Asignar Operari";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asignar operari al incident seleccionat:";
            // 
            // AssingWorkOrderFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cbOperators);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIncidents);
            this.Name = "AssingWorkOrderFrom";
            this.Text = "AssingWorkOrderFrom";
            this.Load += new System.EventHandler(this.AssingWorkOrderFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOperators;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label2;
    }
}