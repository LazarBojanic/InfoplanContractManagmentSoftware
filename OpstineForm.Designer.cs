namespace CSharp_SQL_App {
    partial class OpstineForm {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ugovoriDataSet = new CSharp_SQL_App.ugovoriDataSet();
            this.opstinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opstinaTableAdapter = new CSharp_SQL_App.ugovoriDataSetTableAdapters.opstinaTableAdapter();
            this.opstinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opstinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.opstinaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // ugovoriDataSet
            // 
            this.ugovoriDataSet.DataSetName = "ugovoriDataSet";
            this.ugovoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opstinaBindingSource
            // 
            this.opstinaBindingSource.DataMember = "opstina";
            this.opstinaBindingSource.DataSource = this.ugovoriDataSet;
            // 
            // opstinaTableAdapter
            // 
            this.opstinaTableAdapter.ClearBeforeFill = true;
            // 
            // opstinaDataGridViewTextBoxColumn
            // 
            this.opstinaDataGridViewTextBoxColumn.DataPropertyName = "opstina";
            this.opstinaDataGridViewTextBoxColumn.HeaderText = "opstina";
            this.opstinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opstinaDataGridViewTextBoxColumn.Name = "opstinaDataGridViewTextBoxColumn";
            this.opstinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.opstinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // OpstineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OpstineForm";
            this.Text = "OpstineForm";
            this.Load += new System.EventHandler(this.OpstineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ugovoriDataSet ugovoriDataSet;
        private System.Windows.Forms.BindingSource opstinaBindingSource;
        private ugovoriDataSetTableAdapters.opstinaTableAdapter opstinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstinaDataGridViewTextBoxColumn;
    }
}