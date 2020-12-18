namespace eMuzickiStudio.WinUI.Rezervacije
{
    partial class frmRezervacijeDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojRezervacije = new System.Windows.Forms.TextBox();
            this.txtDatumRezervacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtkazana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacijaStavke = new System.Windows.Forms.DataGridView();
            this.RezervacijaStavkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuzickaOprema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlacena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijaStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj rezervacije";
            // 
            // txtBrojRezervacije
            // 
            this.txtBrojRezervacije.Location = new System.Drawing.Point(193, 23);
            this.txtBrojRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojRezervacije.Name = "txtBrojRezervacije";
            this.txtBrojRezervacije.Size = new System.Drawing.Size(141, 22);
            this.txtBrojRezervacije.TabIndex = 1;
            // 
            // txtDatumRezervacije
            // 
            this.txtDatumRezervacije.Location = new System.Drawing.Point(193, 85);
            this.txtDatumRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatumRezervacije.Name = "txtDatumRezervacije";
            this.txtDatumRezervacije.Size = new System.Drawing.Size(141, 22);
            this.txtDatumRezervacije.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum rezervacije";
            // 
            // txtOtkazana
            // 
            this.txtOtkazana.Location = new System.Drawing.Point(193, 117);
            this.txtOtkazana.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtkazana.Name = "txtOtkazana";
            this.txtOtkazana.Size = new System.Drawing.Size(141, 22);
            this.txtOtkazana.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otkazana?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacijaStavke);
            this.groupBox1.Location = new System.Drawing.Point(16, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 346);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke rezervacije";
            // 
            // dgvRezervacijaStavke
            // 
            this.dgvRezervacijaStavke.AllowUserToAddRows = false;
            this.dgvRezervacijaStavke.AllowUserToDeleteRows = false;
            this.dgvRezervacijaStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacijaStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaStavkaId,
            this.RezervacijaId,
            this.MuzickaOprema,
            this.Kolicina,
            this.Cijena});
            this.dgvRezervacijaStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacijaStavke.Location = new System.Drawing.Point(4, 19);
            this.dgvRezervacijaStavke.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRezervacijaStavke.Name = "dgvRezervacijaStavke";
            this.dgvRezervacijaStavke.ReadOnly = true;
            this.dgvRezervacijaStavke.RowHeadersWidth = 51;
            this.dgvRezervacijaStavke.Size = new System.Drawing.Size(461, 323);
            this.dgvRezervacijaStavke.TabIndex = 0;
            // 
            // RezervacijaStavkaId
            // 
            this.RezervacijaStavkaId.DataPropertyName = "RezervacijaStavkaId";
            this.RezervacijaStavkaId.HeaderText = "RezervacijaStavkaId";
            this.RezervacijaStavkaId.MinimumWidth = 6;
            this.RezervacijaStavkaId.Name = "RezervacijaStavkaId";
            this.RezervacijaStavkaId.ReadOnly = true;
            this.RezervacijaStavkaId.Visible = false;
            this.RezervacijaStavkaId.Width = 125;
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
            // MuzickaOprema
            // 
            this.MuzickaOprema.DataPropertyName = "MuzickaOprema";
            this.MuzickaOprema.HeaderText = "Muzicka oprema";
            this.MuzickaOprema.MinimumWidth = 6;
            this.MuzickaOprema.Name = "MuzickaOprema";
            this.MuzickaOprema.ReadOnly = true;
            this.MuzickaOprema.Width = 125;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 125;
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
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(342, 144);
            this.btnOdobri.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(143, 28);
            this.btnOdobri.TabIndex = 7;
            this.btnOdobri.Text = "Odobri rezervaciju";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(193, 147);
            this.txtUkupno.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(141, 22);
            this.txtUkupno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ukupna cijena";
            // 
            // txtPlacena
            // 
            this.txtPlacena.Location = new System.Drawing.Point(193, 55);
            this.txtPlacena.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlacena.Name = "txtPlacena";
            this.txtPlacena.Size = new System.Drawing.Size(141, 22);
            this.txtPlacena.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Placena?";
            // 
            // frmRezervacijeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 554);
            this.Controls.Add(this.txtPlacena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOtkazana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumRezervacije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojRezervacije);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRezervacijeDetalji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji rezervacije";
            this.Load += new System.EventHandler(this.frmRezervacijeDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacijaStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojRezervacije;
        private System.Windows.Forms.TextBox txtDatumRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtkazana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacijaStavke;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaStavkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuzickaOprema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlacena;
        private System.Windows.Forms.Label label5;
    }
}