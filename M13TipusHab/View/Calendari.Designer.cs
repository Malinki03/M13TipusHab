namespace M13TipusHab.View
{
    partial class Calendari
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finsaDT = new System.Windows.Forms.DateTimePicker();
            this.desdeDT = new System.Windows.Forms.DateTimePicker();
            this.submButton1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.submButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tarifaCombo = new System.Windows.Forms.ComboBox();
            this.calendar = new Pabo.Calendar.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(212, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(158, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.finsaDT);
            this.tabPage1.Controls.Add(this.desdeDT);
            this.tabPage1.Controls.Add(this.submButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(150, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Afegir Dades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fins a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Des de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // finsaDT
            // 
            this.finsaDT.CustomFormat = "dd/MM/yyyy";
            this.finsaDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finsaDT.Location = new System.Drawing.Point(6, 77);
            this.finsaDT.Name = "finsaDT";
            this.finsaDT.Size = new System.Drawing.Size(138, 20);
            this.finsaDT.TabIndex = 3;
            this.finsaDT.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // desdeDT
            // 
            this.desdeDT.CustomFormat = "";
            this.desdeDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdeDT.Location = new System.Drawing.Point(6, 29);
            this.desdeDT.Name = "desdeDT";
            this.desdeDT.Size = new System.Drawing.Size(138, 20);
            this.desdeDT.TabIndex = 2;
            this.desdeDT.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // submButton1
            // 
            this.submButton1.Location = new System.Drawing.Point(28, 135);
            this.submButton1.Name = "submButton1";
            this.submButton1.Size = new System.Drawing.Size(97, 23);
            this.submButton1.TabIndex = 0;
            this.submButton1.Text = "Afegir Dades";
            this.submButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.submButton2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tarifaCombo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(150, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assignar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // submButton2
            // 
            this.submButton2.Location = new System.Drawing.Point(38, 104);
            this.submButton2.Name = "submButton2";
            this.submButton2.Size = new System.Drawing.Size(75, 23);
            this.submButton2.TabIndex = 2;
            this.submButton2.Text = "Assignar";
            this.submButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarifa";
            // 
            // tarifaCombo
            // 
            this.tarifaCombo.FormattingEnabled = true;
            this.tarifaCombo.Location = new System.Drawing.Point(6, 51);
            this.tarifaCombo.Name = "tarifaCombo";
            this.tarifaCombo.Size = new System.Drawing.Size(138, 21);
            this.tarifaCombo.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.ActiveMonth.Month = 1;
            this.calendar.ActiveMonth.Year = 2020;
            this.calendar.Culture = new System.Globalization.CultureInfo("es-ES");
            this.calendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendar.Header.TextColor = System.Drawing.Color.White;
            this.calendar.ImageList = null;
            this.calendar.Location = new System.Drawing.Point(12, 12);
            this.calendar.MaxDate = new System.DateTime(2032, 11, 3, 20, 22, 55, 746);
            this.calendar.MinDate = new System.DateTime(2012, 11, 3, 20, 22, 55, 746);
            this.calendar.Month.BackgroundImage = null;
            this.calendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendar.Name = "calendar";
            this.calendar.SelectTrailingDates = false;
            this.calendar.Size = new System.Drawing.Size(194, 197);
            this.calendar.TabIndex = 1;
            this.calendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // Calendari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 225);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Calendari";
            this.Text = "Assignar Tarifes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        public Pabo.Calendar.MonthCalendar calendar;
        public System.Windows.Forms.DateTimePicker finsaDT;
        public System.Windows.Forms.DateTimePicker desdeDT;
        public System.Windows.Forms.Button submButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button submButton2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox tarifaCombo;
    }
}