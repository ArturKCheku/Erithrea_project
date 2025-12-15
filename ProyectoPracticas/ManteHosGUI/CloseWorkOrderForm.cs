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
    public partial class CloseWorkOrderForm : Form
    {
        private IManteHosService service;
        private List<WorkOrder> loadOrders;

        public CloseWorkOrderForm(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void CloseWorkOrderForm_Load(object sender, EventArgs e)
        {
            CargarOrdresPendents();
        }

        private void CargarOrdresPendents()
        {
            loadOrders = service.GetWorkOrders().ToList();

            dgvWorkOrders.DataSource = loadOrders.Select(wo => new
            {
                Id = wo.Id,
                Incident = wo.Incident.Description + " (" + wo.Incident.Department  + ")",
                StartDate = wo.StartDate
            }).ToList();

            if (dgvWorkOrders.Columns["Id"] != null) dgvWorkOrders.Columns["Id"].Width = 50;
            if (dgvWorkOrders.Columns["Incident"] != null)
            {
               dgvWorkOrders.Columns["Incident"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            actualizarDgvWO();
            
        }

        private void actualizarDgvWO()
        {
            dgvUsedParts.DataSource = null;
            lblCost.Text = "Cost Total: 0.00€";
            txtRepairReport.Clear();
        }

        private void dgvWorkOrders_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvWorkOrders.SelectedRows.Count == 0)
            {
                actualizarDgvWO();
                return;
            }

            int selectedId = (int)dgvWorkOrders.SelectedRows[0].Cells["Id"].Value;
            WorkOrder selectedOrder = loadOrders.FirstOrDefault(wo  => wo.Id == selectedId);

            if (selectedOrder != null)
            {
                actualitzarDgvUP(selectedOrder);
            }

        }

        private void actualitzarDgvUP(WorkOrder wo)
        {
            var partsData = wo.UsedParts.Select(up => new
            {
                Pesa = up.Part.Description,
                Quantitat = up.Quantity,
                PreuUnitat = up.Part.UnitPrice + " €",
                Necessaria = up.Needed ? "Si (!)" : "No"
            }).ToList();

            dgvUsedParts.DataSource = partsData;

            double totalCost = wo.UsedParts.Sum(up => up.Quantity * up.Part.UnitPrice);
            lblCost.Text = $"Cost Total:{totalCost:F2} €";

        }

    }
}
