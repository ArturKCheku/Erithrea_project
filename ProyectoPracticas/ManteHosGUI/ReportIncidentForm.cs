using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHosGUI;
using ManteHos.Services;
using ManteHos.Entities;
using ManteHos.Persistence;

namespace ManteHosGUI
{
    public partial class ReportIncidentForm : Form
    {
        private IManteHosService service;
        public ReportIncidentForm(IManteHosService service)
        {
            InitializeComponent();
            
            this.service = service;
        }

        private void ReportB_Click(object sender, EventArgs e)
        {
            Incident incident = new Incident();
            {
                //Department = txtDepartment.Text;
                //Description = txtDescripcio.Text;

            }
            try
            {
                service.reportIncident(incident);

                MessageBox.Show("Incidencia reportada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
