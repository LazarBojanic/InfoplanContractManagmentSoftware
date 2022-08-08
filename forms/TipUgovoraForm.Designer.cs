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
            this.textBoxTipUgovora = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dataGridViewTipUgovora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTipUgovora
            // 
            this.textBoxTipUgovora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxTipUgovora.Location = new System.Drawing.Point(68, 426);
            this.textBoxTipUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTipUgovora.Name = "textBoxTipUgovora";
            this.textBoxTipUgovora.Size = new System.Drawing.Size(227, 20);
            this.textBoxTipUgovora.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Location = new System.Drawing.Point(93, 457);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(176, 63);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
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
            this.dataGridViewTipUgovora.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewTipUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTipUgovora.Name = "dataGridViewTipUgovora";
            this.dataGridViewTipUgovora.ReadOnly = true;
            this.dataGridViewTipUgovora.RowHeadersWidth = 51;
            this.dataGridViewTipUgovora.RowTemplate.Height = 24;
            this.dataGridViewTipUgovora.Size = new System.Drawing.Size(340, 401);
            this.dataGridViewTipUgovora.TabIndex = 2;
            this.dataGridViewTipUgovora.TabStop = false;
            // 
            // TipUgovoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 530);
            this.Controls.Add(this.textBoxTipUgovora);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewTipUgovora);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipUgovoraForm";
            this.Text = "TipUgovoraForm";
            this.Load += new System.EventHandler(this.TipUgovoraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipUgovora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTipUgovora;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridViewTipUgovora;
    }
}