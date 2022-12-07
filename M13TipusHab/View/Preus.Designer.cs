namespace M13TipusHab.View
{
    partial class Preus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datesInicialsDisponibles_L = new System.Windows.Forms.Label();
            this.novaDataInicial_L = new System.Windows.Forms.Label();
            this.copiar_B = new System.Windows.Forms.Button();
            this.preus_L = new System.Windows.Forms.Label();
            this.esborrar_B = new System.Windows.Forms.Button();
            this.modificar_B = new System.Windows.Forms.Button();
            this.ok_B = new System.Windows.Forms.Button();
            this.cancel_B = new System.Windows.Forms.Button();
            this.datesInicialsDisponibles_CB = new System.Windows.Forms.ComboBox();
            this.preus_DGV = new System.Windows.Forms.DataGridView();
            this.nodaDataInicial_DT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.preus_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // datesInicialsDisponibles_L
            // 
            this.datesInicialsDisponibles_L.AutoSize = true;
            this.datesInicialsDisponibles_L.Location = new System.Drawing.Point(9, 12);
            this.datesInicialsDisponibles_L.Name = "datesInicialsDisponibles_L";
            this.datesInicialsDisponibles_L.Size = new System.Drawing.Size(124, 13);
            this.datesInicialsDisponibles_L.TabIndex = 0;
            this.datesInicialsDisponibles_L.Text = "Dates inicials disponibles";
            // 
            // novaDataInicial_L
            // 
            this.novaDataInicial_L.AutoSize = true;
            this.novaDataInicial_L.Location = new System.Drawing.Point(173, 11);
            this.novaDataInicial_L.Name = "novaDataInicial_L";
            this.novaDataInicial_L.Size = new System.Drawing.Size(92, 13);
            this.novaDataInicial_L.TabIndex = 1;
            this.novaDataInicial_L.Text = "NOVA Data inicial";
            // 
            // copiar_B
            // 
            this.copiar_B.Location = new System.Drawing.Point(283, 24);
            this.copiar_B.Name = "copiar_B";
            this.copiar_B.Size = new System.Drawing.Size(103, 23);
            this.copiar_B.TabIndex = 4;
            this.copiar_B.Text = "Copiar preus";
            this.copiar_B.UseVisualStyleBackColor = true;
            // 
            // preus_L
            // 
            this.preus_L.AutoSize = true;
            this.preus_L.Location = new System.Drawing.Point(12, 71);
            this.preus_L.Name = "preus_L";
            this.preus_L.Size = new System.Drawing.Size(34, 13);
            this.preus_L.TabIndex = 5;
            this.preus_L.Text = "Preus";
            // 
            // esborrar_B
            // 
            this.esborrar_B.Location = new System.Drawing.Point(70, 66);
            this.esborrar_B.Name = "esborrar_B";
            this.esborrar_B.Size = new System.Drawing.Size(90, 23);
            this.esborrar_B.TabIndex = 6;
            this.esborrar_B.Text = "Esborrar preus";
            this.esborrar_B.UseVisualStyleBackColor = true;
            // 
            // modificar_B
            // 
            this.modificar_B.Location = new System.Drawing.Point(176, 66);
            this.modificar_B.Name = "modificar_B";
            this.modificar_B.Size = new System.Drawing.Size(92, 23);
            this.modificar_B.TabIndex = 7;
            this.modificar_B.Text = "Modificar preus";
            this.modificar_B.UseVisualStyleBackColor = true;
            // 
            // ok_B
            // 
            this.ok_B.Enabled = false;
            this.ok_B.Location = new System.Drawing.Point(283, 66);
            this.ok_B.Name = "ok_B";
            this.ok_B.Size = new System.Drawing.Size(36, 23);
            this.ok_B.TabIndex = 8;
            this.ok_B.Text = "OK";
            this.ok_B.UseVisualStyleBackColor = true;
            // 
            // cancel_B
            // 
            this.cancel_B.Enabled = false;
            this.cancel_B.Location = new System.Drawing.Point(325, 66);
            this.cancel_B.Name = "cancel_B";
            this.cancel_B.Size = new System.Drawing.Size(61, 23);
            this.cancel_B.TabIndex = 9;
            this.cancel_B.Text = "Cancel";
            this.cancel_B.UseVisualStyleBackColor = true;
            // 
            // datesInicialsDisponibles_CB
            // 
            this.datesInicialsDisponibles_CB.FormattingEnabled = true;
            this.datesInicialsDisponibles_CB.Location = new System.Drawing.Point(12, 27);
            this.datesInicialsDisponibles_CB.Name = "datesInicialsDisponibles_CB";
            this.datesInicialsDisponibles_CB.Size = new System.Drawing.Size(148, 21);
            this.datesInicialsDisponibles_CB.TabIndex = 10;
            // 
            // preus_DGV
            // 
            this.preus_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preus_DGV.Location = new System.Drawing.Point(12, 95);
            this.preus_DGV.Name = "preus_DGV";
            this.preus_DGV.Size = new System.Drawing.Size(472, 395);
            this.preus_DGV.TabIndex = 12;
            // 
            // nodaDataInicial_DT
            // 
            this.nodaDataInicial_DT.CustomFormat = "";
            this.nodaDataInicial_DT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nodaDataInicial_DT.Location = new System.Drawing.Point(176, 27);
            this.nodaDataInicial_DT.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.nodaDataInicial_DT.Name = "nodaDataInicial_DT";
            this.nodaDataInicial_DT.Size = new System.Drawing.Size(89, 20);
            this.nodaDataInicial_DT.TabIndex = 13;
            this.nodaDataInicial_DT.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Preus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 502);
            this.Controls.Add(this.nodaDataInicial_DT);
            this.Controls.Add(this.preus_DGV);
            this.Controls.Add(this.datesInicialsDisponibles_CB);
            this.Controls.Add(this.cancel_B);
            this.Controls.Add(this.ok_B);
            this.Controls.Add(this.modificar_B);
            this.Controls.Add(this.esborrar_B);
            this.Controls.Add(this.preus_L);
            this.Controls.Add(this.copiar_B);
            this.Controls.Add(this.novaDataInicial_L);
            this.Controls.Add(this.datesInicialsDisponibles_L);
            this.Name = "Preus";
            this.Text = "Preus";
            ((System.ComponentModel.ISupportInitialize)(this.preus_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label datesInicialsDisponibles_L;
        public System.Windows.Forms.Label novaDataInicial_L;
        public System.Windows.Forms.Button copiar_B;
        public System.Windows.Forms.Label preus_L;
        public System.Windows.Forms.Button esborrar_B;
        public System.Windows.Forms.Button modificar_B;
        public System.Windows.Forms.Button ok_B;
        public System.Windows.Forms.Button cancel_B;
        public System.Windows.Forms.ComboBox datesInicialsDisponibles_CB;
        public System.Windows.Forms.DataGridView preus_DGV;
        public System.Windows.Forms.DateTimePicker nodaDataInicial_DT;
    }
}