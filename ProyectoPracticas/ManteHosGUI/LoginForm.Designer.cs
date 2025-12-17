namespace ManteHosGUI
{
    partial class LoginForm
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
            this.ExitB = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RestriccioUser = new System.Windows.Forms.Label();
            this.RestriccioPassw = new System.Windows.Forms.Label();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitB
            // 
            this.ExitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitB.Location = new System.Drawing.Point(115, 393);
            this.ExitB.Margin = new System.Windows.Forms.Padding(4);
            this.ExitB.MinimumSize = new System.Drawing.Size(119, 44);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(119, 44);
            this.ExitB.TabIndex = 2;
            this.ExitB.Text = "Salir";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoginB.Location = new System.Drawing.Point(325, 393);
            this.LoginB.Margin = new System.Windows.Forms.Padding(4);
            this.LoginB.MinimumSize = new System.Drawing.Size(119, 44);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(119, 44);
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "Login ->";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(48, 0);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(280, 30);
            this.txtId.TabIndex = 4;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(156, 107);
            this.SignIn.Margin = new System.Windows.Forms.Padding(0);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(203, 33);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "  Iniciar Sessió  ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(115, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 32);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ManteHosGUI.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(115, 228);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 32);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::ManteHosGUI.Properties.Resources.image_removebg_preview__4_;
            this.pictureBox3.Location = new System.Drawing.Point(287, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(48, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 30);
            this.txtPassword.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ManteHosGUI.Properties.Resources.image_removebg_preview__3_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // RestriccioUser
            // 
            this.RestriccioUser.AutoSize = true;
            this.RestriccioUser.ForeColor = System.Drawing.Color.Red;
            this.RestriccioUser.Location = new System.Drawing.Point(111, 207);
            this.RestriccioUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccioUser.Name = "RestriccioUser";
            this.RestriccioUser.Size = new System.Drawing.Size(72, 16);
            this.RestriccioUser.TabIndex = 9;
            this.RestriccioUser.Text = "Restricció*";
            this.RestriccioUser.Visible = false;
            // 
            // RestriccioPassw
            // 
            this.RestriccioPassw.AutoSize = true;
            this.RestriccioPassw.ForeColor = System.Drawing.Color.Red;
            this.RestriccioPassw.Location = new System.Drawing.Point(111, 263);
            this.RestriccioPassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestriccioPassw.Name = "RestriccioPassw";
            this.RestriccioPassw.Size = new System.Drawing.Size(72, 16);
            this.RestriccioPassw.TabIndex = 10;
            this.RestriccioPassw.Text = "Restricció*";
            this.RestriccioPassw.Visible = false;
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RememberMe.Location = new System.Drawing.Point(115, 284);
            this.RememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(96, 20);
            this.RememberMe.TabIndex = 11;
            this.RememberMe.Text = "Recorda\'m";
            this.RememberMe.UseVisualStyleBackColor = true;
            this.RememberMe.CheckedChanged += new System.EventHandler(this.RememberMe_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ManteHosGUI.Properties.Resources.logo2;
            this.pictureBox4.Location = new System.Drawing.Point(163, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(243, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(539, 492);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.RestriccioPassw);
            this.Controls.Add(this.RestriccioUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.ExitB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RestriccioUser;
        private System.Windows.Forms.Label RestriccioPassw;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}