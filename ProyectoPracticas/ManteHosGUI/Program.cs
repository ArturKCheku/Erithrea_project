using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Services;
using ManteHos.Persistence;
using ManteHos.Entities;

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

            bool userExit = false;

            while (!userExit)
            {
                LoginForm login = new LoginForm(service);

                if(login.ShowDialog() == DialogResult.OK)
                {
                    MainGUI main = new MainGUI(service);
                    main.ShowDialog();

                    if(main.LogoutRequested == false)
                    {
                        userExit = true;
                    }
                    
                }
                else
                {
                    userExit = true;
                }
            }

            Application.Run(new MainGUI(service));
        }
    }
}
