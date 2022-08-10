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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipUgovoraForm));
            this.textBoxTipUgovora = new System.Windows.Forms.TextBox();
            this.dataGridViewTipUgovora = new System.Windows.Forms.DataGridView();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTipUgovora
            // 
            this.textBoxTipUgovora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTipUgovora.Location = new System.Drawing.Point(68, 426);
            this.textBoxTipUgovora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTipUgovora.Name = "textBoxTipUgovora";
            this.textBoxTipUgovora.Size = new System.Drawing.Size(227, 20);
            this.textBoxTipUgovora.TabIndex = 0;
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
            this.dataGridViewTipUgovora.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewTipUgovora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTipUgovora.Name = "dataGridViewTipUgovora";
            this.dataGridViewTipUgovora.ReadOnly = true;
            this.dataGridViewTipUgovora.RowHeadersWidth = 51;
            this.dataGridViewTipUgovora.RowTemplate.Height = 24;
            this.dataGridViewTipUgovora.Size = new System.Drawing.Size(336, 401);
            this.dataGridViewTipUgovora.TabIndex = 2;
            this.dataGridViewTipUgovora.TabStop = false;
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNazad.Location = new System.Drawing.Point(198, 456);
            this.buttonNazad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(131, 63);
            this.buttonNazad.TabIndex = 7;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Location = new System.Drawing.Point(29, 456);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(131, 63);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // TipUgovoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 530);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxTipUgovora);
            this.Controls.Add(this.dataGridViewTipUgovora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(374, 569);
            this.Name = "TipUgovoraForm";
            this.Text = "Tipovi Ugovora";
            this.Load += new System.EventHandler(this.TipUgovoraForm_Load);
            this.ResizeBegin += new System.EventHandler(this.TipUgovoraForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TipUgovoraForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTipUgovora;
        private System.Windows.Forms.DataGridView dataGridViewTipUgovora;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonDodaj;
    }
}