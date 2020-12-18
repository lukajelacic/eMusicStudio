namespace eMuzickiStudio.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacije1 = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikaziRezervacije = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije1);
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // dgvRezervacije1
            // 
            this.dgvRezervacije1.AllowUserToAddRows = false;
            this.dgvRezervacije1.AllowUserToDeleteRows = false;
            this.dgvRezervacije1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.BrojRezervacije,
            this.Datum,
            this.Otkazano,
            this.Klijent});
            this.dgvRezervacije1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije1.Location = new System.Drawing.Point(4, 19);
            this.dgvRezervacije1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRezervacije1.Name = "dgvRezervacije1";
            this.dgvRezervacije1.ReadOnly = true;
            this.dgvRezervacije1.RowHeadersWidth = 51;
            this.dgvRezervacije1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije1.Size = new System.Drawing.Size(592, 407);
            this.dgvRezervacije1.TabIndex = 0;
            this.dgvRezervacije1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRezervacije1_MouseDoubleClick);
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.MinimumWidth = 6;
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            this.RezervacijaId.Width = 125;
            // 
            // BrojRezervacije
            // 
            this.BrojRezervacije.DataPropertyName = "BrojRezervacije";
            this.BrojRezervacije.HeaderText = "Broj rezervacije";
            this.BrojRezervacije.MinimumWidth = 6;
            this.BrojRezervacije.Name = "BrojRezervacije";
            this.BrojRezervacije.ReadOnly = true;
            this.BrojRezervacije.Width = 125;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 125;
            // 
            // Otkazano
            // 
            this.Otkazano.DataPropertyName = "Otkazano";
            this.Otkazano.HeaderText = "Otkazana";
            this.Otkazano.MinimumWidth = 6;
            this.Otkazano.Name = "Otkazano";
            this.Otkazano.ReadOnly = true;
            this.Otkazano.Width = 125;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.MinimumWidth = 6;
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 125;
            // 
            // btnPrikaziRezervacije
            // 
            this.btnPrikaziRezervacije.Location = new System.Drawing.Point(423, 74);
            this.btnPrikaziRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziRezervacije.Name = "btnPrikaziRezervacije";
            this.btnPrikaziRezervacije.Size = new System.Drawing.Size(193, 28);
            this.btnPrikaziRezervacije.TabIndex = 1;
            this.btnPrikaziRezervacije.Text = "Prikazi zahtjeve";
            this.btnPrikaziRezervacije.UseVisualStyleBackColor = true;
            this.btnPrikaziRezervacije.Click += new System.EventHandler(this.btnPrikaziRezervacije_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 554);
            this.Controls.Add(this.btnPrikaziRezervacije);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRezervacije";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahtjevi za rezervacije";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacije1;
        private System.Windows.Forms.Button btnPrikaziRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
    }
}