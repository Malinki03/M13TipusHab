using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13TipusHab.Controller
{
    internal class CalendariController
    {
        private Calendari calendari;
        private Repository repo;
        public CalendariController()
        {
            this.calendari = new Calendari();
            this.repo = new Repository();
            Application.Run(this.calendari);
        }
    }
}
