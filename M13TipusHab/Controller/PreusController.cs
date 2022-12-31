using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations.Infrastructure;
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
        private enum buttonPressed
        {
            Copiar,
            Modificar,
            Esborrar
        };
        buttonPressed buttonP;

        
        public PreusController()
        {
            this.preus = new Preus();
            this.repo = new Repository();
            buttonP = new buttonPressed();
            loadWidgets();
            initListeners();
            dgvCongif();
            this.preus.Show();
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
                this.preus.preus_DGV.DataSource = this.repo.GetCostasPerData((DateTime) this.preus.datesInicialsDisponibles_CB.SelectedItem);
                this.preus.preus_DGV.Columns["Desde"].Visible = false;
                this.preus.preus_DGV.Columns["Finsa"].Visible = false;
                this.preus.preus_DGV.Columns["TipusHab_codi"].Visible = false;
                this.preus.preus_DGV.Columns["Tarifa_codi"].Visible = false;
                this.preus.preus_DGV.Columns["tarifa"].Width = 60;
                this.preus.preus_DGV.Columns["preu"].Width = 60;
                this.preus.preus_DGV.Columns["tipusHab"].DisplayIndex = 0;
                this.preus.preus_DGV.Columns["tarifa"].DisplayIndex = 1;
                this.preus.preus_DGV.Columns["preu"].DisplayIndex = 2; 
                this.preus.preus_DGV.Columns["tipusHab"].ReadOnly = true;
                this.preus.preus_DGV.Columns["tarifa"].ReadOnly = true;
                this.preus.preus_DGV.Columns["preu"].ReadOnly = true;
        }

        private void loadWidgets()
        {
            this.preus.nodaDataInicial_DT.Value = DateTime.Now;
            this.preus.datesInicialsDisponibles_CB.DataSource = this.repo.GetDatesDisponibles();
        }

        private void dgvCongif()
        {
            if(this.preus.datesInicialsDisponibles_CB.SelectedItem != null)
            {
                updateDGV();
            }
            else
            {
                this.preus.preus_DGV.DataSource = null;
            }
        }

        private void initListeners()
        {
            this.preus.esborrar_B.Click += Esborrar_B_Click;
            this.preus.copiar_B.Click += Copiar_B_Click;
            this.preus.ok_B.Click += Ok_B_Click;
            this.preus.cancel_B.Click += Cancel_B_Click;
            this.preus.modificar_B.Click += Modificar_B_Click;
            this.preus.datesInicialsDisponibles_CB.SelectedIndexChanged += DatesInicialsDisponibles_CB_SelectedIndexChanged;
        }

        private void DatesInicialsDisponibles_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preus.preus_DGV.DataSource = this.repo.GetCostasPerData((DateTime) this.preus.datesInicialsDisponibles_CB.SelectedItem);
        }

        private void Modificar_B_Click(object sender, EventArgs e)
        {
            this.buttonP = buttonPressed.Modificar;
            this.preus.preus_DGV.Columns["preu"].ReadOnly = false;
            enableButtons();
        }

        private void Ok_B_Click(object sender, EventArgs e)
        {
            switch(buttonP)
            {
                case buttonPressed.Copiar:
                    this.repo.addCosta0(this.preus.nodaDataInicial_DT.Value);
                    List<costa> costos = this.repo.GetCostasPerData(this.preus.nodaDataInicial_DT.Value);
                    for(int i = 0; i < this.preus.preus_DGV.Rows.Count; i++)
                    {
                        try
                        {
                            costos[i].preu = ((costa)this.preus.preus_DGV.Rows[i].DataBoundItem).preu;
                        } catch(ArgumentOutOfRangeException ex) {}
                    }
                    this.repo.GrabarCostos(costos);
                    break;
                case buttonPressed.Modificar:
                    foreach(DataGridViewRow row in this.preus.preus_DGV.Rows)
                    {
                        costa costa = this.repo.GetCostasById(((costa) row.DataBoundItem).TipusHab_codi, ((costa) row.DataBoundItem).Tarifa_codi, ((costa)row.DataBoundItem).preu);
                    }
                    updateDGV();
                    break;
                case buttonPressed.Esborrar:
                    this.repo.eliminarCostos((DateTime) this.preus.datesInicialsDisponibles_CB.SelectedItem);
                    break;
            }
            disableButtons();
            this.preus.preus_DGV.DataSource = this.repo.GetCostasPerData((DateTime) this.preus.datesInicialsDisponibles_CB.SelectedItem);
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            updateDGV();
            disableButtons();
        }

        private void Copiar_B_Click(object sender, EventArgs e)
        {
            this.buttonP = buttonPressed.Copiar;
            enableButtons();
            updateDGV();
        }

        private void Esborrar_B_Click(object sender, EventArgs e)
        {
            this.buttonP = buttonPressed.Esborrar;
            enableButtons();
            updateDGV();
        }
    }
}