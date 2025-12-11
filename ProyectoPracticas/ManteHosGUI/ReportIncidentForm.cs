using ManteHos.Entities;
using ManteHos.Persistence;
using ManteHos.Services;
using ManteHosGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosGUI
{
    public partial class ReportIncidentForm : Form
    {
        private IManteHosService service;
        public ReportIncidentForm(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
            ReportB.Enabled = false;
        }

        private void ButtonState()
        {
            bool isDepartFull = !string.IsNullOrWhiteSpace(txtDepartment.Text);
            bool isDescFull = !string.IsNullOrEmpty(txtDescripcio.Text);

            ReportB.Enabled = isDepartFull && isDescFull;
        }

        private void ReportB_Click(object sender, EventArgs e)
        {
            Incident incident = new Incident()
            {
                Department = txtDepartment.Text,
                Description = txtDescripcio.Text

            };
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
            catch (DbEntityValidationException ex) // <--- AQUÍ ESTÁ LA MAGIA
            {
                // Este código recorre los errores ocultos de Entity Framework
                string errores = "";
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errores += $"- Propiedad: {validationError.PropertyName}\n  Error: {validationError.ErrorMessage}\n";
                    }
                }
                MessageBox.Show("Error de validación en BD:\n" + errores, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarTexto(object sender, EventArgs e)
        {
            ButtonState();
        }
    }
}
