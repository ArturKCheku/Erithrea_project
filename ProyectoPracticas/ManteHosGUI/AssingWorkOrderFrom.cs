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
    public partial class AssingWorkOrderFrom : Form
    {
        private IManteHosService service;

        public AssingWorkOrderFrom(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void CargarOperators()
        {
            cbOperators.DataSource = service.GetAllOperators().ToList();
            cbOperators.DisplayMember = "FullName";
            cbOperators.ValueMember = "Id";
        }

        private void CargarIncidents()
        {
            var incidents = service.GetIncidentsMaster();

            var gridData = incidents.Select(i => new
            {
                Id = i.Id,
                Description = i.Description,
                Priority = i.Priority,
                Status = i.Status,

                Operaris = (i.WorkOrder != null && i.WorkOrder.Operators.Count > 0)
                    ? string.Join(",", i.WorkOrder.Operators.Select(o => o.FullName))
                    : "Sense Asignar"
            }).ToList();

            dgvIncidents.DataSource = gridData;
        }

        private void AssingWorkOrderFrom_Load(object sender, EventArgs e)
        {
            CargarIncidents();
            CargarOperators();
        }

        private bool selectAlgo()
        {
            if (dgvIncidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una incidencia.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(cbOperators.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un operari del desplegable.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if(!selectAlgo()) return;

            int incidentId = (int)dgvIncidents.SelectedRows[0].Cells["Id"].Value;
            string operatorId = cbOperators.SelectedValue.ToString();

            try
            {
                service.AssignOperatorToIncident(incidentId, operatorId);

                MessageBox.Show("Operari asignat correctament.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarIncidents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (!selectAlgo()) return;

            int incidentId = (int)dgvIncidents.SelectedRows[0].Cells["Id"].Value;
            string operatorId = cbOperators.SelectedValue.ToString();

            try
            {
                service.UnassignOperatorToIncident(incidentId, operatorId);

                MessageBox.Show("Operari eliminat de la orden.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarIncidents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
