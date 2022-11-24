﻿using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
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
            Application.Run(this.preus);
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
        }

        private void Copiar_B_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Esborrar_B_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
