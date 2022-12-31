using M13TipusHab.Model;
using M13TipusHab.View;
using System.Windows.Forms;
using Menu = M13TipusHab.View.Menu;

namespace M13TipusHab.Controller
{
    internal class MenuController
    {
        private Menu menu;
        
        public MenuController()
        {
            this.menu = new Menu();
            InitListeners();
            Application.Run(this.menu);
        }

        private void InitListeners()
        {
            this.menu.tipusHab_B.Click += TipusHab_B_Click;
            this.menu.calendari_B.Click += Calendari_B_Click;
            this.menu.preus_B.Click += Preus_B_Click;
        }

        private void TipusHab_B_Click(object sender, System.EventArgs e)
        {
            new TipusHabController();
        }

        private void Calendari_B_Click(object sender, System.EventArgs e)
        {
            new CalendariController();
        }

        private void Preus_B_Click(object sender, System.EventArgs e)
        {
            new PreusController();
        }
    }
}
