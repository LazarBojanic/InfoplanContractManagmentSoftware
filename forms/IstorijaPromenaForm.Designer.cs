namespace CSharp_SQL_App {
    partial class IstorijaPromenaForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstorijaPromenaForm));
            this.buttonNazad = new System.Windows.Forms.Button();
            this.dataGridViewChangeLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNazad.Location = new System.Drawing.Point(428, 375);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(165, 63);
            this.buttonNazad.TabIndex = 4;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // dataGridViewChangeLog
            // 
            this.dataGridViewChangeLog.AllowUserToAddRows = false;
            this.dataGridViewChangeLog.AllowUserToDeleteRows = false;
            this.dataGridViewChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChangeLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangeLog.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChangeLog.Name = "dataGridViewChangeLog";
            this.dataGridViewChangeLog.ReadOnly = true;
            this.dataGridViewChangeLog.RowHeadersWidth = 51;
            this.dataGridViewChangeLog.Size = new System.Drawing.Size(998, 345);
            this.dataGridViewChangeLog.TabIndex = 3;
            // 
            // IstorijaPromenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.dataGridViewChangeLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1038, 489);
            this.Name = "IstorijaPromenaForm";
            this.Text = "Istorija Promena";
            this.Load += new System.EventHandler(this.IstorijaPromenaForm_Load);
            this.ResizeBegin += new System.EventHandler(this.IstorijaPromenaForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.IstorijaPromenaForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.DataGridView dataGridViewChangeLog;
    }
}