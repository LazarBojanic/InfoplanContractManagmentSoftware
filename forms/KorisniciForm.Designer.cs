namespace CSharp_SQL_App {
    partial class KorisniciForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KorisniciForm));
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.AllowUserToAddRows = false;
            this.dataGridViewKorisnici.AllowUserToDeleteRows = false;
            this.dataGridViewKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(9, 11);
            this.dataGridViewKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKorisnici.MultiSelect = false;
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.ReadOnly = true;
            this.dataGridViewKorisnici.RowHeadersWidth = 51;
            this.dataGridViewKorisnici.RowTemplate.Height = 24;
            this.dataGridViewKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(395, 248);
            this.dataGridViewKorisnici.TabIndex = 2;
            this.dataGridViewKorisnici.TabStop = false;
            this.dataGridViewKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Location = new System.Drawing.Point(11, 274);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(112, 63);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIzmeni.Location = new System.Drawing.Point(150, 274);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(112, 63);
            this.buttonIzmeni.TabIndex = 1;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNazad.Location = new System.Drawing.Point(289, 274);
            this.buttonNazad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(112, 63);
            this.buttonNazad.TabIndex = 3;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // KorisniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 348);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(429, 387);
            this.Name = "KorisniciForm";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.KorisniciForm_Load);
            this.ResizeBegin += new System.EventHandler(this.KorisniciForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.KorisniciForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonNazad;
    }
}