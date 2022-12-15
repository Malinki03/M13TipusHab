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
        private int tarifa;
        public CalendariController()
        {
            this.calendari = new Calendari();
            this.repo = new Repository();
            InitListeners();
            CalendarConfig();
            this.calendari.tarifaCombo.DataSource = this.repo.GetTarifas();
            this.calendari.tarifaCombo.DisplayMember = "nom";
            calendari.Show();
        }

        private void InitListeners()
        {
            this.calendari.submButton1.Click += SubmButton1_Click;
            this.calendari.submButton2.Click += SubmButton2_Click;
        }

        private void SubmButton2_Click(object sender, EventArgs e)
        {
            tarifa tarif = (tarifa)this.calendari.tarifaCombo.SelectedItem;
            this.tarifa = tarif.codi;
        }

        private void SubmButton1_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.calendari.desdeDT.Value;
            DateTime endDate = this.calendari.finsaDT.Value;
            this.repo.InsertarDates(startDate, endDate);
            this.repo.ActualitzarTarifes(startDate, endDate, tarifa);
        }

        private void CalendarConfig()
        {
            this.calendari.calendar.ActiveMonth.Month = DateTime.Now.Month;
            this.calendari.calendar.ActiveMonth.Year = DateTime.Now.Year;
            this.calendari.desdeDT.Value = DateTime.Now;
            this.calendari.finsaDT.Value = DateTime.Now;
        }
    }
}
