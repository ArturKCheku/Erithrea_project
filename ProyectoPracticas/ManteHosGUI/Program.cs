using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Services;
using ManteHos.Persistence;
using ManteHosGUI;

namespace ManteHosGUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDAL dal = new EntityFrameworkDAL(new ManteHosDbContext());
            IManteHosService service = new ManteHosService(dal);

            Application.Run(new MainGUI(service));
        }
    }
}
