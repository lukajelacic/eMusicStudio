namespace eMuzickiStudio.WinUI.Klijenti
{
    partial class frmKlijentiDetalji
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.lblPotvrda = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRezervacijeKlijenta = new System.Windows.Forms.Button();
            this.btnBanuj = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(16, 90);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(351, 22);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(16, 151);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(351, 22);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 268);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(16, 329);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(351, 22);
            this.txtKorisnickoIme.TabIndex = 9;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Korisnicko ime";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 450);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(12, 431);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(57, 17);
            this.lblLozinka.TabIndex = 10;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(199, 450);
            this.txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(168, 22);
            this.txtPasswordConfirmation.TabIndex = 13;
            this.txtPasswordConfirmation.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordConfirmation_Validating);
            // 
            // lblPotvrda
            // 
            this.lblPotvrda.AutoSize = true;
            this.lblPotvrda.Location = new System.Drawing.Point(195, 431);
            this.lblPotvrda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPotvrda.Name = "lblPotvrda";
            this.lblPotvrda.Size = new System.Drawing.Size(105, 17);
            this.lblPotvrda.TabIndex = 12;
            this.lblPotvrda.Text = "Potvrda lozinke";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(199, 511);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(169, 28);
            this.btnSnimi.TabIndex = 14;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Grad";
            // 
            // cmbGrad
            // 
            this.cmbGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(16, 396);
            this.cmbGrad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(349, 24);
            this.cmbGrad.TabIndex = 16;
            this.cmbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrad_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(513, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(509, 309);
            this.lblSlika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(38, 17);
            this.lblSlika.TabIndex = 18;
            this.lblSlika.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(513, 329);
            this.txtSlika.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(205, 22);
            this.txtSlika.TabIndex = 19;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(513, 396);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(207, 28);
            this.btnDodajSliku.TabIndex = 20;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRezervacijeKlijenta
            // 
            this.btnRezervacijeKlijenta.Location = new System.Drawing.Point(513, 448);
            this.btnRezervacijeKlijenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervacijeKlijenta.Name = "btnRezervacijeKlijenta";
            this.btnRezervacijeKlijenta.Size = new System.Drawing.Size(207, 28);
            this.btnRezervacijeKlijenta.TabIndex = 21;
            this.btnRezervacijeKlijenta.Text = "Rezervacije klijenta";
            this.btnRezervacijeKlijenta.UseVisualStyleBackColor = true;
            this.btnRezervacijeKlijenta.Click += new System.EventHandler(this.btnRezervacijeKlijenta_Click);
            // 
            // btnBanuj
            // 
            this.btnBanuj.Location = new System.Drawing.Point(13, 513);
            this.btnBanuj.Margin = new System.Windows.Forms.Padding(4);
            this.btnBanuj.Name = "btnBanuj";
            this.btnBanuj.Size = new System.Drawing.Size(169, 28);
            this.btnBanuj.TabIndex = 22;
            this.btnBanuj.Text = "Banuj klijenta";
            this.btnBanuj.UseVisualStyleBackColor = true;
            this.btnBanuj.Click += new System.EventHandler(this.btnBanuj_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPhone.Location = new System.Drawing.Point(16, 212);
            this.txtPhone.Mask = "(999) 000-000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(352, 22);
            this.txtPhone.TabIndex = 23;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
            // 
            // frmKlijentiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 554);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnBanuj);
            this.Controls.Add(this.btnRezervacijeKlijenta);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.lblPotvrda);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKlijentiDetalji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled detalja i dodavanje klijenata";
            this.Load += new System.EventHandler(this.frmKlijentiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblPotvrda;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRezervacijeKlijenta;
        private System.Windows.Forms.Button btnBanuj;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}