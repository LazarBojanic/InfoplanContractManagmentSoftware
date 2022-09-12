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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgovorFilesForm));
            this.dataGridViewUgovorFiles = new System.Windows.Forms.DataGridView();
            this.contextMenuStripFajloviUgovora = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopirajPoljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopirajRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovorFiles)).BeginInit();
            this.contextMenuStripFajloviUgovora.SuspendLayout();
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
            this.dataGridViewUgovorFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUgovorFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUgovorFiles.ContextMenuStrip = this.contextMenuStripFajloviUgovora;
            this.dataGridViewUgovorFiles.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUgovorFiles.MultiSelect = false;
            this.dataGridViewUgovorFiles.Name = "dataGridViewUgovorFiles";
            this.dataGridViewUgovorFiles.ReadOnly = true;
            this.dataGridViewUgovorFiles.RowHeadersVisible = false;
            this.dataGridViewUgovorFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUgovorFiles.Size = new System.Drawing.Size(776, 386);
            this.dataGridViewUgovorFiles.TabIndex = 0;
            this.dataGridViewUgovorFiles.TabStop = false;
            this.dataGridViewUgovorFiles.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridViewUgovorFiles_CellContextMenuStripNeeded);
            this.dataGridViewUgovorFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUgovorFiles_CellDoubleClick);
            // 
            // contextMenuStripFajloviUgovora
            // 
            this.contextMenuStripFajloviUgovora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopirajPoljeToolStripMenuItem,
            this.kopirajRedToolStripMenuItem});
            this.contextMenuStripFajloviUgovora.Name = "contextMenuStripFajloviUgovora";
            this.contextMenuStripFajloviUgovora.Size = new System.Drawing.Size(141, 48);
            // 
            // kopirajPoljeToolStripMenuItem
            // 
            this.kopirajPoljeToolStripMenuItem.Name = "kopirajPoljeToolStripMenuItem";
            this.kopirajPoljeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kopirajPoljeToolStripMenuItem.Text = "Kopiraj Polje";
            this.kopirajPoljeToolStripMenuItem.Click += new System.EventHandler(this.kopirajPoljeToolStripMenuItem_Click);
            // 
            // kopirajRedToolStripMenuItem
            // 
            this.kopirajRedToolStripMenuItem.Name = "kopirajRedToolStripMenuItem";
            this.kopirajRedToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kopirajRedToolStripMenuItem.Text = "Kopiraj Red";
            this.kopirajRedToolStripMenuItem.Click += new System.EventHandler(this.kopirajRedToolStripMenuItem_Click);
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrikazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonUkloni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUkloni.Location = new System.Drawing.Point(428, 414);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(152, 63);
            this.buttonUkloni.TabIndex = 3;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            this.buttonUkloni.Click += new System.EventHandler(this.buttonUkloni_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(220, 414);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(152, 63);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 528);
            this.Name = "UgovorFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fajlovi ugovora";
            this.Load += new System.EventHandler(this.UgovorFilesForm_Load);
            this.ResizeBegin += new System.EventHandler(this.UgovorFilesForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.UgovorFilesForm_ResizeEnd);
            this.Click += new System.EventHandler(this.UgovorFilesForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUgovorFiles)).EndInit();
            this.contextMenuStripFajloviUgovora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUgovorFiles;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFajloviUgovora;
        private System.Windows.Forms.ToolStripMenuItem kopirajPoljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopirajRedToolStripMenuItem;
    }
}