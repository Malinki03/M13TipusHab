using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M13TipusHab.Controller
{
    internal static class Program
    {
        /// <summary>
        /// Ésta aplicación és un formulario para crear tipos de habitación
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new CalendariController();
        }
    }
}
