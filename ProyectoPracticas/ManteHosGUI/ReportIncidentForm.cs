using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosGUI
{
    public partial class ReportIncidentForm : Form
    {
        public ReportIncidentForm()
        {
            InitializeComponent();
        }

        private void ReportB_Click(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
