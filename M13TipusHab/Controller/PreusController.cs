using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M13TipusHab.Controller
{
    internal class PreusController
    {
        private Preus preus;
        private Repository repo;
        
        public PreusController()
        {
            this.preus = new Preus();
            this.repo = new Repository();
            initListeners();
            dgvCongif();
            loadWidgets();
            Application.Run(this.preus);
        }

        private void enableButtons()
        {
            this.preus.ok_B.Enabled = true;
            this.preus.ok_B.ForeColor = Color.Green;
            this.preus.cancel_B.Enabled = true;
            this.preus.cancel_B.ForeColor = Color.Red;
        }
        private void disableButtons()
        {
            this.preus.ok_B.Enabled = false;
            this.preus.ok_B.ForeColor = Color.Black;
            this.preus.cancel_B.Enabled = false;
            this.preus.cancel_B.ForeColor = Color.Black;
        }

        private void updateDGV()
        {
            this.preus.preus_DGV.DataSource = this.repo.GetCostas();
        }

        private void loadWidgets()
        {
            this.preus.nodaDataInicial_DT.Value = DateTime.Now;
        }

        private void dgvCongif()
        {
            this.preus.preus_DGV.DataSource = this.repo.GetCostas();
            this.preus.preus_DGV.Columns["Desde"].Visible = false;
            this.preus.preus_DGV.Columns["Finsa"].Visible = false;
            this.preus.preus_DGV.Columns["tarifa"].DisplayIndex = 2;
            this.preus.preus_DGV.Columns["tarifa"].Width = 60;
            this.preus.preus_DGV.Columns["preu"].Width = 60;
            this.preus.preus_DGV.Columns["tipusHab"].DisplayIndex = 3;
        }

        private void initListeners()
        {
            this.preus.esborrar_B.Click += Esborrar_B_Click;
            this.preus.copiar_B.Click += Copiar_B_Click;
            this.preus.ok_B.Click += Ok_B_Click;
            this.preus.cancel_B.Click += Cancel_B_Click;
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            disableButtons();
        }

        private void Ok_B_Click(object sender, EventArgs e)
        {
            disableButtons();
        }

        private void Copiar_B_Click(object sender, EventArgs e)
        {
            enableButtons();
//            this.repo.addCosta0(this.preus.nodaDataInicial_DT.Value); 
        }

        private void Esborrar_B_Click(object sender, EventArgs e)
        {
            this.repo.eliminarCostos();
            updateDGV();
        }
    }
}
