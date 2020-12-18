namespace eMuzickiStudio.WinUI.Rezervacije
{
    partial class frmIspisSlobodnihTermina
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(471, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slobodni termini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminId,
            this.Datum,
            this.VrijemeOd,
            this.VrijemeDo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(463, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.MinimumWidth = 6;
            this.TerminId.Name = "TerminId";
            this.TerminId.ReadOnly = true;
            this.TerminId.Visible = false;
            this.TerminId.Width = 125;
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
            // VrijemeOd
            // 
            this.VrijemeOd.DataPropertyName = "VrijemeOd";
            this.VrijemeOd.HeaderText = "Pocetak";
            this.VrijemeOd.MinimumWidth = 6;
            this.VrijemeOd.Name = "VrijemeOd";
            this.VrijemeOd.ReadOnly = true;
            this.VrijemeOd.Width = 125;
            // 
            // VrijemeDo
            // 
            this.VrijemeDo.DataPropertyName = "VrijemeDo";
            this.VrijemeDo.HeaderText = "Kraj";
            this.VrijemeDo.MinimumWidth = 6;
            this.VrijemeDo.Name = "VrijemeDo";
            this.VrijemeDo.ReadOnly = true;
            this.VrijemeDo.Width = 125;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(283, 53);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(180, 28);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj novi termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmIspisSlobodnihTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 554);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIspisSlobodnihTermina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slobodni termini";
            this.Load += new System.EventHandler(this.frmIspisSlobodnihTermina_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeDo;
        private System.Windows.Forms.Button btnDodaj;
    }
}