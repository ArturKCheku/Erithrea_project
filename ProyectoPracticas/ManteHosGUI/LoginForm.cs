using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Services;

namespace ManteHosGUI
{
    public partial class LoginForm : Form
    {
        private IManteHosService service;

        public LoginForm(IManteHosService service)

        {

            InitializeComponent();

            RestriccioUser.Visible = false;

            RestriccioPassw.Visible = false;

            txtPassword.UseSystemPasswordChar = true;

            pictureBox3.Image = ManteHosGUI.Properties.Resources.image_removebg_preview__4_;

            this.service = service;



            if (Properties.Settings.Default.RememberMe)

            {

                txtId.Text = Properties.Settings.Default.UserName;

                txtPassword.Text = Properties.Settings.Default.UserPass;

                RememberMe.Checked = true;

            }

        }



        private void LoginB_Click(object sender, EventArgs e)

        {

            // Reiniciem estat

            RestriccioUser.Visible = false;

            RestriccioPassw.Visible = false;

            bool hayErrorCampos = false;



            // Validacions

            if (string.IsNullOrEmpty(txtId.Text))

            {

                RestriccioUser.Text = "El usuari és obligatori";

                RestriccioUser.Visible = true;

                hayErrorCampos = true;

            }



            if (string.IsNullOrEmpty(txtPassword.Text))

            {

                RestriccioPassw.Text = "La contrasenya és obligatoria";

                RestriccioPassw.Visible = true;

                hayErrorCampos = true;

            }



            if (hayErrorCampos)

            {

                return;

            }



            try

            {

                service.Login(txtId.Text, txtPassword.Text);



                if (RememberMe.Checked)

                {

                    Properties.Settings.Default.UserName = txtId.Text;

                    Properties.Settings.Default.UserPass = txtPassword.Text;

                    Properties.Settings.Default.RememberMe = true;

                }

                else

                {

                    Properties.Settings.Default.UserName = "";

                    Properties.Settings.Default.UserPass = "";

                    Properties.Settings.Default.RememberMe = false;

                }



                Properties.Settings.Default.Save();



                this.DialogResult = DialogResult.OK;

                this.Close();

            }

            catch (ServiceException)

            {

                RestriccioPassw.Text = "Usuari o contrasenya incorrectes";

                RestriccioPassw.Visible = true;



                txtPassword.Clear();

                txtPassword.Focus();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error del sistema: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ExitB_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Vols exir de la apliccació?", "Exit",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                this.DialogResult = DialogResult.Cancel;

                Application.Exit();

            }

        }

        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {

            //Mostrar contrasenya

            if (txtPassword.UseSystemPasswordChar)

            {

                txtPassword.UseSystemPasswordChar = false;

                txtPassword.PasswordChar = '\0';

                pictureBox3.Image = ManteHosGUI.Properties.Resources.image_removebg_preview__5_; //5

            }

            //Ocultar contraseña

            else

            {

                txtPassword.UseSystemPasswordChar = true;

                pictureBox3.Image = ManteHosGUI.Properties.Resources.image_removebg_preview__4_;

            }

            if (!string.IsNullOrEmpty(txtPassword.Text))

            {

                txtPassword.SelectionStart = txtPassword.Text.Length;

            }

        }
    }
}
