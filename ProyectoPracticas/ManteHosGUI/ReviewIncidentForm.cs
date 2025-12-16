using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Entities;

namespace ManteHosGUI
{
    public partial class ReviewIncidentForm : Form
    {
        private IManteHosService service;

        public ReviewIncidentForm(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void ReviewIncidentForm_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarListaIncidents();


            rdbAccept.Checked = false;
            rbtReject.Checked = false;
            UpdateUIState();
        }

        private void CargarCombos()
        {
            BindingSource bsAreas = new BindingSource();
            bsAreas.DataSource = service.GetAllAreas().ToList();
            cbArea.DataSource = bsAreas;
            cbArea.DisplayMember = "Name";
            cbArea.ValueMember = "Id";

            cbPriority.DataSource = Enum.GetValues(typeof(Priority));
        }

        private void CargarListaIncidents()
        {
            BindingSource bsIncidents = new BindingSource();

            bsIncidents.DataSource = service.getPendingIncidents().Select(i => new {
                Id = i.Id,
                Department = i.Department,
                Description = i.Description,
                Date = i.ReportDate,
                Reporter = i.Reporter.FullName
            }).ToList();

            dgvIncidents.DataSource = bsIncidents;
        }

        

        private void ProcesarAceptacio(int id)
        {
            if (cbArea.SelectedItem == null) throw new Exception("Cal seleccionar un Àrea.");

            int areaId = (int)cbArea.SelectedValue;
            Priority priority = (Priority)cbPriority.SelectedItem;

            service.AcceptIncident(id, areaId, priority);
        }

        private void ProcesarRebutj(int id)
        {
            if (string.IsNullOrWhiteSpace(txtRejectReason.Text)) throw new Exception("Cal escriure una raó per al rebutj.");

            service.RejectIncident(id, txtRejectReason.Text);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(dgvIncidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Per favor selecciona una llista", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int incidentId = (int)dgvIncidents.SelectedRows[0].Cells["Id"].Value;

            if (!rdbAccept.Checked && !rbtReject.Checked)
            {
                MessageBox.Show("Por favor, selecciona si deseas Aceptar o Rechazar el incidente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (rdbAccept.Checked)
                {
                    ProcesarAceptacio(incidentId);
                }
                if(rbtReject.Checked)
                {
                    ProcesarRebutj(incidentId);
                }

                MessageBox.Show("Operació realizada amb exit.", "Correcte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaIncidents();
                txtRejectReason.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al procesar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateUIState()
        {
            grpAcceptData.Enabled = rdbAccept.Checked;
            grpRejectData.Enabled = rbtReject.Checked;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIState();
        }
    }
}
