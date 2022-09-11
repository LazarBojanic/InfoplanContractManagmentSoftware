namespace CSharp_SQL_App {
    partial class TipUgovoraForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipUgovoraForm));
            this.dataGridViewTipUgovora = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.contextMenuStripTipUgovora = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).BeginInit();
            this.contextMenuStripTipUgovora.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTipUgovora
            // 
            this.dataGridViewTipUgovora.AllowUserToAddRows = false;
            this.dataGridViewTipUgovora.AllowUserToDeleteRows = false;
            this.dataGridViewTipUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTipUgovora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTipUgovora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTipUgovora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipUgovora.ContextMenuStrip = this.contextMenuStripTipUgovora;
            this.dataGridViewTipUgovora.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewTipUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTipUgovora.MultiSelect = false;
            this.dataGridViewTipUgovora.Name = "dataGridViewTipUgovora";
            this.dataGridViewTipUgovora.ReadOnly = true;
            this.dataGridViewTipUgovora.RowHeadersWidth = 51;
            this.dataGridViewTipUgovora.RowTemplate.Height = 24;
            this.dataGridViewTipUgovora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTipUgovora.Size = new System.Drawing.Size(507, 429);
            this.dataGridViewTipUgovora.TabIndex = 0;
            this.dataGridViewTipUgovora.TabStop = false;
            this.dataGridViewTipUgovora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipUgovora_CellDoubleClick);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonZatvori.Location = new System.Drawing.Point(406, 456);
            this.buttonZatvori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(112, 63);
            this.buttonZatvori.TabIndex = 3;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.Location = new System.Drawing.Point(11, 456);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(112, 63);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIzmeni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonIzmeni.Location = new System.Drawing.Point(142, 456);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(112, 63);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.Location = new System.Drawing.Point(273, 456);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(112, 63);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // contextMenuStripTipUgovora
            // 
            this.contextMenuStripTipUgovora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopirajToolStripMenuItem});
            this.contextMenuStripTipUgovora.Name = "contextMenuStripTipUgovora";
            this.contextMenuStripTipUgovora.Size = new System.Drawing.Size(181, 48);
            // 
            // kopirajToolStripMenuItem
            // 
            this.kopirajToolStripMenuItem.Name = "kopirajToolStripMenuItem";
            this.kopirajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopirajToolStripMenuItem.Text = "Kopiraj";
            this.kopirajToolStripMenuItem.Click += new System.EventHandler(this.kopirajToolStripMenuItem_Click);
            // 
            // TipUgovoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 530);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewTipUgovora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(545, 569);
            this.Name = "TipUgovoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipovi ugovora";
            this.ResizeBegin += new System.EventHandler(this.TipUgovoraForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TipUgovoraForm_ResizeEnd);
            this.Click += new System.EventHandler(this.TipUgovoraForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).EndInit();
            this.contextMenuStripTipUgovora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTipUgovora;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTipUgovora;
        private System.Windows.Forms.ToolStripMenuItem kopirajToolStripMenuItem;
    }
}