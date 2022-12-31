namespace M13TipusHab.View
{
    partial class Menu
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
            this.tipusHab_B = new System.Windows.Forms.Button();
            this.calendari_B = new System.Windows.Forms.Button();
            this.preus_B = new System.Windows.Forms.Button();
            this.menu_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipusHab_B
            // 
            this.tipusHab_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipusHab_B.Location = new System.Drawing.Point(118, 119);
            this.tipusHab_B.MinimumSize = new System.Drawing.Size(79, 54);
            this.tipusHab_B.Name = "tipusHab_B";
            this.tipusHab_B.Size = new System.Drawing.Size(259, 54);
            this.tipusHab_B.TabIndex = 0;
            this.tipusHab_B.Text = "Tipus d\'habitacions";
            this.tipusHab_B.UseVisualStyleBackColor = true;
            // 
            // calendari_B
            // 
            this.calendari_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendari_B.Location = new System.Drawing.Point(118, 179);
            this.calendari_B.MinimumSize = new System.Drawing.Size(79, 54);
            this.calendari_B.Name = "calendari_B";
            this.calendari_B.Size = new System.Drawing.Size(259, 54);
            this.calendari_B.TabIndex = 1;
            this.calendari_B.Text = "Calendari";
            this.calendari_B.UseVisualStyleBackColor = true;
            // 
            // preus_B
            // 
            this.preus_B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preus_B.Location = new System.Drawing.Point(118, 239);
            this.preus_B.MinimumSize = new System.Drawing.Size(79, 54);
            this.preus_B.Name = "preus_B";
            this.preus_B.Size = new System.Drawing.Size(259, 54);
            this.preus_B.TabIndex = 2;
            this.preus_B.Text = "Preus";
            this.preus_B.UseVisualStyleBackColor = true;
            // 
            // menu_L
            // 
            this.menu_L.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menu_L.AutoSize = true;
            this.menu_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_L.Location = new System.Drawing.Point(121, 26);
            this.menu_L.Name = "menu_L";
            this.menu_L.Size = new System.Drawing.Size(255, 76);
            this.menu_L.TabIndex = 3;
            this.menu_L.Text = "HOTEL";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 355);
            this.Controls.Add(this.menu_L);
            this.Controls.Add(this.preus_B);
            this.Controls.Add(this.calendari_B);
            this.Controls.Add(this.tipusHab_B);
            this.MinimumSize = new System.Drawing.Size(334, 394);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button tipusHab_B;
        public System.Windows.Forms.Button calendari_B;
        public System.Windows.Forms.Button preus_B;
        public System.Windows.Forms.Label menu_L;
    }
}