namespace CSharp_SQL_App.forms {
    partial class UgovorFilesForm {
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
            this.dataGridViewUgovorFiles = new System.Windows.Forms.DataGridView();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovorFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUgovorFiles
            // 
            this.dataGridViewUgovorFiles.AllowUserToAddRows = false;
            this.dataGridViewUgovorFiles.AllowUserToDeleteRows = false;
            this.dataGridViewUgovorFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUgovorFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUgovorFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUgovorFiles.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUgovorFiles.Name = "dataGridViewUgovorFiles";
            this.dataGridViewUgovorFiles.ReadOnly = true;
            this.dataGridViewUgovorFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUgovorFiles.Size = new System.Drawing.Size(776, 386);
            this.dataGridViewUgovorFiles.TabIndex = 0;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrikazi.Location = new System.Drawing.Point(12, 414);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(152, 63);
            this.buttonPrikazi.TabIndex = 1;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUkloni.Location = new System.Drawing.Point(428, 414);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(152, 63);
            this.buttonUkloni.TabIndex = 2;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            this.buttonUkloni.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Location = new System.Drawing.Point(220, 414);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(152, 63);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.Location = new System.Drawing.Point(636, 414);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(152, 63);
            this.buttonZatvori.TabIndex = 4;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // UgovorFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonUkloni);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewUgovorFiles);
            this.Name = "UgovorFilesForm";
            this.Text = "UgovorFilesForm";
            this.Load += new System.EventHandler(this.UgovorFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovorFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUgovorFiles;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonZatvori;
    }
}