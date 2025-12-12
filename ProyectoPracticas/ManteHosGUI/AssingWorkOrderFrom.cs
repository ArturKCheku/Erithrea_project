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
            cbOperators.DataSource = service.GetAllOperators();
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

                asignedOperators = (i.WorkOrder != null && i.WorkOrder.Operators.Count > 0)
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

    }
}
