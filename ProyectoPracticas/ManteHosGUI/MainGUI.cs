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
using ManteHos.Entities;

namespace ManteHosGUI
{
    public partial class MainGUI : Form
    {
        private IManteHosService service;
        public MainGUI(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(service);

            DialogResult result = loginForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                Employee usuario = service.GetLoggedEmployee();

                this.Text = "ManteHos App -Usuario: " + usuario.FullName;

                MessageBox.Show("Bienvenide " + usuario.FullName, "Sesión Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportarIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null)
            {
                MessageBox.Show("Cal iniciar sesió .", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ReportIncidentForm form = new ReportIncidentForm(service);
            form.ShowDialog();
        }

        private void revisarIncidenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null)
            {
                MessageBox.Show("Cal iniciar sesió .", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!(service.GetLoggedEmployee() is Head))
            {
                MessageBox.Show("Acces denegat. No tens suficients permisos", "Seguretat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            ReviewIncidentForm form = new ReviewIncidentForm(service);
            form.ShowDialog();

        }
    }
}
