namespace M13TipusHab.View
{
    partial class TipusHab
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
            this.persCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llitCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balcCombo = new System.Windows.Forms.ComboBox();
            this.banyeraLabel = new System.Windows.Forms.Label();
            this.banyCheck = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.habDGV = new System.Windows.Forms.DataGridView();
            this.modButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.habDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // persCombo
            // 
            this.persCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.persCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.persCombo.FormattingEnabled = true;
            this.persCombo.Location = new System.Drawing.Point(31, 29);
            this.persCombo.Name = "persCombo";
            this.persCombo.Size = new System.Drawing.Size(48, 21);
            this.persCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comb. llits";
            // 
            // llitCombo
            // 
            this.llitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.llitCombo.FormattingEnabled = true;
            this.llitCombo.Location = new System.Drawing.Point(97, 29);
            this.llitCombo.Name = "llitCombo";
            this.llitCombo.Size = new System.Drawing.Size(208, 21);
            this.llitCombo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipus Balcó";
            // 
            // balcCombo
            // 
            this.balcCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.balcCombo.FormattingEnabled = true;
            this.balcCombo.Location = new System.Drawing.Point(358, 29);
            this.balcCombo.Name = "balcCombo";
            this.balcCombo.Size = new System.Drawing.Size(121, 21);
            this.balcCombo.TabIndex = 4;
            // 
            // banyeraLabel
            // 
            this.banyeraLabel.AutoSize = true;
            this.banyeraLabel.Location = new System.Drawing.Point(512, 13);
            this.banyeraLabel.Name = "banyeraLabel";
            this.banyeraLabel.Size = new System.Drawing.Size(67, 13);
            this.banyeraLabel.TabIndex = 6;
            this.banyeraLabel.Text = "Té banyera?";
            // 
            // banyCheck
            // 
            this.banyCheck.AutoSize = true;
            this.banyCheck.Location = new System.Drawing.Point(538, 32);
            this.banyCheck.Name = "banyCheck";
            this.banyCheck.Size = new System.Drawing.Size(15, 14);
            this.banyCheck.TabIndex = 7;
            this.banyCheck.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(590, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Afegir";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(726, 27);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(62, 23);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "Esborra";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // habDGV
            // 
            this.habDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habDGV.Location = new System.Drawing.Point(31, 73);
            this.habDGV.Name = "habDGV";
            this.habDGV.ReadOnly = true;
            this.habDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.habDGV.Size = new System.Drawing.Size(757, 349);
            this.habDGV.TabIndex = 10;
            // 
            // TipusHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.habDGV);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.banyCheck);
            this.Controls.Add(this.banyeraLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balcCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llitCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.persCombo);
            this.Name = "TipusHab";
            this.Text = "Tipus d\'Habitacions";
            ((System.ComponentModel.ISupportInitialize)(this.habDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox persCombo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox llitCombo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox balcCombo;
        public System.Windows.Forms.Label banyeraLabel;
        public System.Windows.Forms.CheckBox banyCheck;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Button delButton;
        public System.Windows.Forms.DataGridView habDGV;
        public System.Windows.Forms.Button modButton;
    }
}

