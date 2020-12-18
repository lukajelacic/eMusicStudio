namespace eMuzickiStudio.WinUI.Rezervacije
{
    partial class frmPregledRezervacija
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
            this.Rezervacije = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezervacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rezervacije
            // 
            this.Rezervacije.Controls.Add(this.dataGridView1);
            this.Rezervacije.Location = new System.Drawing.Point(12, 95);
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Size = new System.Drawing.Size(561, 343);
            this.Rezervacije.TabIndex = 0;
            this.Rezervacije.TabStop = false;
            this.Rezervacije.Text = "Rezervacije";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.BrojRezervacije,
            this.DatumRezervacije,
            this.Otkazano,
            this.Cijena});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(419, 59);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(151, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazite rezervacije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite datum";
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
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.MinimumWidth = 6;
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            this.DatumRezervacije.Width = 125;
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
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // frmPregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.Rezervacije);
            this.Name = "frmPregledRezervacija";
            this.Text = "frmPregledRezervacija";
            this.Rezervacije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Rezervacije;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}