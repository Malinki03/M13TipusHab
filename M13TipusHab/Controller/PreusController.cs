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
            InitListeners();
            DgvCongif();
            LoadWidgets();
            preus.Show();
        }

        private void EnableButtons()
        {
            this.preus.ok_B.Enabled = true;
            this.preus.ok_B.ForeColor = Color.Green;
            this.preus.cancel_B.Enabled = true;
            this.preus.cancel_B.ForeColor = Color.Red;
        }
        private void DisableButtons()
        {
            this.preus.ok_B.Enabled = false;
            this.preus.ok_B.ForeColor = Color.Black;
            this.preus.cancel_B.Enabled = false;
            this.preus.cancel_B.ForeColor = Color.Black;
        }

        private void UpdateDGV()
        {
            this.preus.preus_DGV.DataSource = this.repo.GetCostas();
        }

        private void LoadWidgets()
        {
//            this.preus.nodaDataInicial_DT.Value = DateTime.Now; (ya he puesto minDate: Today en sus propiedades)
        }

        private void DgvCongif()
        {
            this.preus.preus_DGV.DataSource = this.repo.GetCostas();
            this.preus.preus_DGV.Columns["Desde"].Visible = false;
            this.preus.preus_DGV.Columns["Finsa"].Visible = false;
            this.preus.preus_DGV.Columns["tarifa"].DisplayIndex = 2;
            this.preus.preus_DGV.Columns["tarifa"].Width = 60;
            this.preus.preus_DGV.Columns["preu"].Width = 60;
            this.preus.preus_DGV.Columns["tipusHab"].DisplayIndex = 3;
        }

        private void InitListeners()
        {
            this.preus.esborrar_B.Click += Esborrar_B_Click;
            this.preus.copiar_B.Click += Copiar_B_Click;
            this.preus.ok_B.Click += Ok_B_Click;
            this.preus.cancel_B.Click += Cancel_B_Click;
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void Ok_B_Click(object sender, EventArgs e)
        {
            DisableButtons();
            DgvCongif();
        }

        private void Copiar_B_Click(object sender, EventArgs e)
        {
            EnableButtons();
            this.repo.AddCosta0(this.preus.nodaDataInicial_DT.Value); 
        }

        private void Esborrar_B_Click(object sender, EventArgs e)
        {
            this.repo.EliminarCostos();
            UpdateDGV();
        }
    }
}
