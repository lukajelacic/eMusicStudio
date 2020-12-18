namespace eMuzickiStudio.WinUI.Klijenti
{
    partial class frmKlijenti
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
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijenti);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(592, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijenti";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentId,
            this.Ime,
            this.Prezime,
            this.Telefon,
            this.Email});
            this.dgvKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijenti.Location = new System.Drawing.Point(4, 19);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(584, 416);
            this.dgvKlijenti.TabIndex = 0;
            this.dgvKlijenti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijenti_MouseDoubleClick);
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "KlijentId";
            this.KlijentId.HeaderText = "KlijentId";
            this.KlijentId.MinimumWidth = 6;
            this.KlijentId.Name = "KlijentId";
            this.KlijentId.ReadOnly = true;
            this.KlijentId.Visible = false;
            this.KlijentId.Width = 125;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(508, 41);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(20, 44);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(144, 22);
            this.txtPretraga.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(203, 44);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(140, 22);
            this.txtPrezime.TabIndex = 3;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(17, 16);
            this.lbIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(30, 17);
            this.lbIme.TabIndex = 4;
            this.lbIme.Text = "Ime";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(199, 16);
            this.lbPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(59, 17);
            this.lbPrezime.TabIndex = 5;
            this.lbPrezime.Text = "Prezime";
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 554);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKlijenti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled klijenata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}