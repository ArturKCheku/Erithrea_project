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
            this.service = service;
        }

        

        private void LoginB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor, introduce usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                service.Login(txtId.Text, txtPassword.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }
    }
}
