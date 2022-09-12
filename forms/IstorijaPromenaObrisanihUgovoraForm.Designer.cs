namespace CSharp_SQL_App.forms {
    partial class IstorijaPromenaObrisanihUgovoraForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstorijaPromenaObrisanihUgovoraForm));
            this.dataGridViewChangeLogObrisanihUgovora = new System.Windows.Forms.DataGridView();
            this.contextMenuStripIstorijaPromenaObrisanihUgovora = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopirajPoljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopirajRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLogObrisanihUgovora)).BeginInit();
            this.contextMenuStripIstorijaPromenaObrisanihUgovora.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChangeLogObrisanihUgovora
            // 
            this.dataGridViewChangeLogObrisanihUgovora.AllowUserToAddRows = false;
            this.dataGridViewChangeLogObrisanihUgovora.AllowUserToDeleteRows = false;
            this.dataGridViewChangeLogObrisanihUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChangeLogObrisanihUgovora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangeLogObrisanihUgovora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewChangeLogObrisanihUgovora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangeLogObrisanihUgovora.ContextMenuStrip = this.contextMenuStripIstorijaPromenaObrisanihUgovora;
            this.dataGridViewChangeLogObrisanihUgovora.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChangeLogObrisanihUgovora.Name = "dataGridViewChangeLogObrisanihUgovora";
            this.dataGridViewChangeLogObrisanihUgovora.ReadOnly = true;
            this.dataGridViewChangeLogObrisanihUgovora.RowHeadersVisible = false;
            this.dataGridViewChangeLogObrisanihUgovora.RowHeadersWidth = 51;
            this.dataGridViewChangeLogObrisanihUgovora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChangeLogObrisanihUgovora.Size = new System.Drawing.Size(998, 345);
            this.dataGridViewChangeLogObrisanihUgovora.TabIndex = 0;
            this.dataGridViewChangeLogObrisanihUgovora.TabStop = false;
            this.dataGridViewChangeLogObrisanihUgovora.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridViewChangeLogObrisanihUgovora_CellContextMenuStripNeeded);
            // 
            // contextMenuStripIstorijaPromenaObrisanihUgovora
            // 
            this.contextMenuStripIstorijaPromenaObrisanihUgovora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopirajPoljeToolStripMenuItem,
            this.kopirajRedToolStripMenuItem});
            this.contextMenuStripIstorijaPromenaObrisanihUgovora.Name = "contextMenuStripIstorijaPromenaObrisanihUgovora";
            this.contextMenuStripIstorijaPromenaObrisanihUgovora.Size = new System.Drawing.Size(141, 48);
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
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonZatvori.Location = new System.Drawing.Point(428, 375);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(165, 63);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // IstorijaPromenaObrisanihUgovoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dataGridViewChangeLogObrisanihUgovora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1038, 489);
            this.Name = "IstorijaPromenaObrisanihUgovoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Istorija Promena Obrisanih Ugovora";
            this.ResizeBegin += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_ResizeEnd);
            this.Click += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLogObrisanihUgovora)).EndInit();
            this.contextMenuStripIstorijaPromenaObrisanihUgovora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChangeLogObrisanihUgovora;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIstorijaPromenaObrisanihUgovora;
        private System.Windows.Forms.ToolStripMenuItem kopirajPoljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopirajRedToolStripMenuItem;
    }
}