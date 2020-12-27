namespace eMuzickiStudio.WinUI.MuzickaOprema
{
    partial class frmMuzickaOprema
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMuzickaOprema = new System.Windows.Forms.DataGridView();
            this.MuzickaOpremaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaStanju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBrojNaStanju = new System.Windows.Forms.NumericUpDown();
            this.txtCijena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuzickaOprema)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrojNaStanju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta muzicke opreme";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(188, 78);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(236, 22);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj na stanju";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(433, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMuzickaOprema
            // 
            this.dgvMuzickaOprema.AllowUserToAddRows = false;
            this.dgvMuzickaOprema.AllowUserToDeleteRows = false;
            this.dgvMuzickaOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuzickaOprema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuzickaOpremaId,
            this.Naziv,
            this.Ocjena,
            this.Cijena,
            this.NaStanju});
            this.dgvMuzickaOprema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuzickaOprema.Location = new System.Drawing.Point(4, 19);
            this.dgvMuzickaOprema.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMuzickaOprema.Name = "dgvMuzickaOprema";
            this.dgvMuzickaOprema.ReadOnly = true;
            this.dgvMuzickaOprema.RowHeadersWidth = 51;
            this.dgvMuzickaOprema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuzickaOprema.Size = new System.Drawing.Size(557, 233);
            this.dgvMuzickaOprema.TabIndex = 0;
            this.dgvMuzickaOprema.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMuzickaOprema_MouseDoubleClick);
            // 
            // MuzickaOpremaId
            // 
            this.MuzickaOpremaId.DataPropertyName = "MuzickaOpremaId";
            this.MuzickaOpremaId.HeaderText = "MuzickaOpremaId";
            this.MuzickaOpremaId.MinimumWidth = 6;
            this.MuzickaOpremaId.Name = "MuzickaOpremaId";
            this.MuzickaOpremaId.ReadOnly = true;
            this.MuzickaOpremaId.Visible = false;
            this.MuzickaOpremaId.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
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
            // NaStanju
            // 
            this.NaStanju.DataPropertyName = "NaStanju";
            this.NaStanju.HeaderText = "Na stanju";
            this.NaStanju.MinimumWidth = 6;
            this.NaStanju.Name = "NaStanju";
            this.NaStanju.ReadOnly = true;
            this.NaStanju.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMuzickaOprema);
            this.groupBox1.Location = new System.Drawing.Point(13, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(188, 44);
            this.cmbVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(236, 24);
            this.cmbVrsta.TabIndex = 11;
            this.cmbVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbVrsta_SelectedIndexChanged);
            this.cmbVrsta.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVrsta_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(433, 206);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSacuvaj.Size = new System.Drawing.Size(145, 28);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(325, 206);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(100, 28);
            this.btnDodajSliku.TabIndex = 13;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(188, 174);
            this.txtSlika.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(236, 22);
            this.txtSlika.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cijena";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBrojNaStanju
            // 
            this.txtBrojNaStanju.Location = new System.Drawing.Point(188, 113);
            this.txtBrojNaStanju.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtBrojNaStanju.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBrojNaStanju.Name = "txtBrojNaStanju";
            this.txtBrojNaStanju.Size = new System.Drawing.Size(236, 22);
            this.txtBrojNaStanju.TabIndex = 18;
            this.txtBrojNaStanju.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBrojNaStanju.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojNaStanju_Validating_1);
            // 
            // txtCijena
            // 
            this.txtCijena.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtCijena.Location = new System.Drawing.Point(188, 142);
            this.txtCijena.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtCijena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(237, 22);
            this.txtCijena.TabIndex = 19;
            this.txtCijena.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating_1);
            // 
            // frmMuzickaOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 554);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtBrojNaStanju);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMuzickaOprema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled i dodavanje muzicke opreme";
            this.Load += new System.EventHandler(this.frmMuzickaOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuzickaOprema)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrojNaStanju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMuzickaOprema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuzickaOpremaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaStanju;
        private System.Windows.Forms.NumericUpDown txtCijena;
        private System.Windows.Forms.NumericUpDown txtBrojNaStanju;
    }
}