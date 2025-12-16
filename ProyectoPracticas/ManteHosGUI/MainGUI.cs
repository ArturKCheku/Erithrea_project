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

        public bool LogoutRequested { get; private set; } = false;
        public MainGUI(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            Employee emp = service.GetLoggedEmployee();
            if(emp != null)
            {
                lblWelcome.Text = "Benvingut, " + emp.FullName;
                /*La vaina del string del rol*/
                
                
                string role = emp.GetType().Name;
                int index = role.IndexOf("_");
                if (index >= 0)
                    role = role.Substring(0, index);

                lblRol.Text = "Rol actual: " + role;

                lblStatus.Text = $"Conectat com {emp.Id} Data: {DateTime.Now.ToShortDateString()}";

            }
        }

        private void reportarIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null)
            {
                MessageBox.Show("Cal iniciar sesió .", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ReportIncidentForm form = new ReportIncidentForm(service);
            form.ShowDialog();
        }

        private void revisarIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null)
            {
                MessageBox.Show("Cal iniciar sesió .", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(service.GetLoggedEmployee() is Head))
            {
                MessageBox.Show("Acces denegat. No tens suficients permisos", "Seguretat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            ReviewIncidentForm form = new ReviewIncidentForm(service);
            form.ShowDialog();
        }

        private void asignarWorkOrdresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null)
            {
                return;
            }

            if (!(service.GetLoggedEmployee() is Master))
            {
                MessageBox.Show("Acceso denegado. Solo para Maestros de Área.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            AssingWorkOrderFrom form = new AssingWorkOrderFrom(service);
            form.ShowDialog();
        }

        private void tancarWorkOrdresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (service.GetLoggedEmployee() == null) { return; }

            if (!(service.GetLoggedEmployee() is Operator))
            {
                MessageBox.Show("Acces denegat. Solos per a Operaris.", "Seguritat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            CloseWorkOrderForm form = new CloseWorkOrderForm(service);
            form.ShowDialog();
        }


        private void salirB_Click(object sender, EventArgs e)
        {
            this.LogoutRequested = false;
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar sesión y volver al login?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.Logout();
                this.LogoutRequested = true;
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LogoutRequested = false;
            this.Close();
            Application.Exit();
        }
    }
}
