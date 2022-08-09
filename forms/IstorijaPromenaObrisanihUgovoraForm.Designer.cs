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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstorijaPromenaObrisanihUgovoraForm));
            this.dataGridViewChangeLogObrisanihUgovora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLogObrisanihUgovora)).BeginInit();
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
            this.dataGridViewChangeLogObrisanihUgovora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangeLogObrisanihUgovora.Location = new System.Drawing.Point(13, 14);
            this.dataGridViewChangeLogObrisanihUgovora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewChangeLogObrisanihUgovora.Name = "dataGridViewChangeLogObrisanihUgovora";
            this.dataGridViewChangeLogObrisanihUgovora.ReadOnly = true;
            this.dataGridViewChangeLogObrisanihUgovora.RowHeadersWidth = 51;
            this.dataGridViewChangeLogObrisanihUgovora.Size = new System.Drawing.Size(1337, 528);
            this.dataGridViewChangeLogObrisanihUgovora.TabIndex = 1;
            // 
            // IstorijaPromenaObrisanihUgovoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 554);
            this.Controls.Add(this.dataGridViewChangeLogObrisanihUgovora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1379, 593);
            this.Name = "IstorijaPromenaObrisanihUgovoraForm";
            this.Text = "Istorija Promena Obrisanih Ugovora";
            this.Load += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_Load);
            this.ResizeBegin += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.IstorijaPromenaObrisanihUgovoraForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangeLogObrisanihUgovora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChangeLogObrisanihUgovora;
    }
}