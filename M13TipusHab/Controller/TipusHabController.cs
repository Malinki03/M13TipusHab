using M13TipusHab.Model;
using M13TipusHab.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace M13TipusHab.Controller
{
    // Clase controladora principal
    internal class TipusHabController
    {
        View.TipusHab tipusHab;
        Repository r;

        public TipusHabController()
        {
            tipusHab = new View.TipusHab();
            r = new Repository();
            LoadData();
            InitListener();
            tipusHab.Show();
        }

        // Método que carga todos los datos de la aplicación
        void LoadData()
        {
            tipusHab.persCombo.DataSource = new List<String>() { " ", "1", "2", "3" };
            LoadComboBox2(null, null);
            tipusHab.balcCombo.DataSource = r.GetTipusBalco();
            tipusHab.balcCombo.DisplayMember = "nomTipusBalco";
            tipusHab.habDGV.DataSource = r.GetTipusHabs();
        }

        void ReloadDataGridView()
        {
            tipusHab.habDGV.DataSource = r.GetTipusHabs();
        }

        // Evento que carga el contenido del combo box de tipos de combinaciones de cama, cambiando cuando se altere la combo box de número de personas
        void LoadComboBox2(object sender, EventArgs e)
        {
            List<String> lLlits = new List<String>() { "1 llit individual", "2 llits individuals", "1 llit matrimonial", "3 llits individuals", "1 llit matrimonial i 1 llit individual" }; ;
            tipusHab.llitCombo.DataSource = LlistaLlits(lLlits, tipusHab.persCombo.SelectedIndex);
        }

        // Método que inicializa los listeners
        void InitListener()
        {
            tipusHab.persCombo.SelectedIndexChanged += LoadComboBox2;
            tipusHab.addButton.Click += AddButton_Click;
            tipusHab.delButton.Click += DelButton_Click;
            tipusHab.modButton.Click += ModButton_Click;
            tipusHab.habDGV.SelectionChanged += HabDGV_SelectionChanged;
        }

        private void HabDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (tipusHab.habDGV.SelectedRows.Count > 0) {
                tipusHab.persCombo.SelectedIndex = int.Parse(tipusHab.habDGV.SelectedRows[0].Cells[4].Value.ToString());
                if (tipusHab.habDGV.SelectedRows[0].Cells[2].Value.ToString() + tipusHab.habDGV.SelectedRows[0].Cells[3].Value.ToString() == "10")
                    tipusHab.llitCombo.SelectedIndex = 0;
                if (tipusHab.habDGV.SelectedRows[0].Cells[2].Value.ToString() + tipusHab.habDGV.SelectedRows[0].Cells[3].Value.ToString() == "01")
                    tipusHab.llitCombo.SelectedIndex = 1;
                if (tipusHab.habDGV.SelectedRows[0].Cells[2].Value.ToString() + tipusHab.habDGV.SelectedRows[0].Cells[3].Value.ToString() == "20")
                    tipusHab.llitCombo.SelectedIndex = 0;
                if (tipusHab.habDGV.SelectedRows[0].Cells[2].Value.ToString() + tipusHab.habDGV.SelectedRows[0].Cells[3].Value.ToString() == "30")
                    tipusHab.llitCombo.SelectedIndex = 0;
                if (tipusHab.habDGV.SelectedRows[0].Cells[2].Value.ToString() + tipusHab.habDGV.SelectedRows[0].Cells[3].Value.ToString() == "11")
                    tipusHab.llitCombo.SelectedIndex = 1;
                if (tipusHab.habDGV.SelectedRows[0].Cells[5].Value.ToString() == "bal0")
                    tipusHab.balcCombo.SelectedIndex = 0;
                if (tipusHab.habDGV.SelectedRows[0].Cells[5].Value.ToString() == "balN")
                    tipusHab.balcCombo.SelectedIndex = 1;
                if (tipusHab.habDGV.SelectedRows[0].Cells[5].Value.ToString() == "balP")
                    tipusHab.balcCombo.SelectedIndex = 2;
                if (tipusHab.habDGV.SelectedRows[0].Cells[6].Value.ToString() == "0")
                    tipusHab.banyCheck.Checked = false;
                if (tipusHab.habDGV.SelectedRows[0].Cells[6].Value.ToString() == "1")
                    tipusHab.banyCheck.Checked = true;
                    
            }
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            r.ModTipusHab(new Model.TipusHab(
                new TipusLlits(ComboBox2Index(tipusHab.llitCombo.Text)),
                FormatTipusBalco(tipusHab.balcCombo.SelectedIndex),
                tipusHab.banyCheck.Checked));
        }

        // Método que numeraliza 
        short? ComboBox2Index(String comboBoxIndex)
        {
            if (comboBoxIndex.Equals("1 llit individual")) return 0;
            else if (comboBoxIndex.Equals("2 llits individuals")) return 1;
            else if (comboBoxIndex.Equals("1 llit matrimonial")) return 2;
            else if (comboBoxIndex.Equals("3 llits individuals")) return 3;
            else if (comboBoxIndex.Equals("1 llit matrimonial i 1 llit individual")) return 4;
            else return null;
        }

        String FormatTipusBalco(int tipusBalco)
        {
            if (tipusBalco == 0)
            {
                return "bal0";
            }
            else if (tipusBalco == 1)
            {
                return "balN";
            }
            else
            {
                return "balP";
            }
        }

        // Evento que añade el tipo de habitación a la base de datos
        private void AddButton_Click(object sender, EventArgs e)
        {
            r.AddTipusHab(new Model.TipusHab(
                new TipusLlits(ComboBox2Index(tipusHab.llitCombo.Text)),
                FormatTipusBalco(tipusHab.balcCombo.SelectedIndex),
                tipusHab.banyCheck.Checked));
            LoadData();
        }

            private void DelButton_Click(object sender, EventArgs e)
            {
            r.DelTipusHab((tipusHab.habDGV.SelectedRows[0].DataBoundItem as Model.TipusHab));
                ReloadDataGridView();
            }

            // Método que elige que opciones expone en el combo box de tipos de combinaciones de camas
            private List<string> LlistaLlits(List<String> lL, int n)
            {
                switch (n)
                {
                    case 1:
                        return new List<string>() { "1 llit individual" };
                    case 2:
                        return new List<string>() { "2 llits individuals", "1 llit matrimonial" };
                    case 3:
                        return new List<string>() { "3 llits individuals", "1 llit matrimonial i 1 llit individual" };
                    default: return lL;
                }
            }
        }
    }
