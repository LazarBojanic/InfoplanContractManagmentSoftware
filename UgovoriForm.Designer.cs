namespace CSharp_SQL_App {
    partial class UgovoriForm {
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.ugovoriDataSet = new CSharp_SQL_App.ugovoriDataSet();
            this.ugovoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorTableAdapter = new CSharp_SQL_App.ugovoriDataSetTableAdapters.ugovorTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPlanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urbanistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUgovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokPoUgovoruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajnjiRokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.opstinaDataGridViewTextBoxColumn,
            this.nazivPlanaDataGridViewTextBoxColumn,
            this.urbanistaDataGridViewTextBoxColumn,
            this.fazaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.datumUgovoraDataGridViewTextBoxColumn,
            this.rokPoUgovoruDataGridViewTextBoxColumn,
            this.obimDataGridViewTextBoxColumn,
            this.krajnjiRokDataGridViewTextBoxColumn,
            this.prioritetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ugovorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1486, 648);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(257, 688);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(348, 67);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(912, 688);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(348, 67);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // ugovoriDataSet
            // 
            this.ugovoriDataSet.DataSetName = "ugovoriDataSet";
            this.ugovoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ugovoriDataSetBindingSource
            // 
            this.ugovoriDataSetBindingSource.DataSource = this.ugovoriDataSet;
            this.ugovoriDataSetBindingSource.Position = 0;
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataMember = "ugovor";
            this.ugovorBindingSource.DataSource = this.ugovoriDataSet;
            // 
            // ugovorTableAdapter
            // 
            this.ugovorTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opstinaDataGridViewTextBoxColumn
            // 
            this.opstinaDataGridViewTextBoxColumn.DataPropertyName = "opstina";
            this.opstinaDataGridViewTextBoxColumn.HeaderText = "opstina";
            this.opstinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opstinaDataGridViewTextBoxColumn.Name = "opstinaDataGridViewTextBoxColumn";
            this.opstinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivPlanaDataGridViewTextBoxColumn
            // 
            this.nazivPlanaDataGridViewTextBoxColumn.DataPropertyName = "nazivPlana";
            this.nazivPlanaDataGridViewTextBoxColumn.HeaderText = "nazivPlana";
            this.nazivPlanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivPlanaDataGridViewTextBoxColumn.Name = "nazivPlanaDataGridViewTextBoxColumn";
            this.nazivPlanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urbanistaDataGridViewTextBoxColumn
            // 
            this.urbanistaDataGridViewTextBoxColumn.DataPropertyName = "urbanista";
            this.urbanistaDataGridViewTextBoxColumn.HeaderText = "urbanista";
            this.urbanistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urbanistaDataGridViewTextBoxColumn.Name = "urbanistaDataGridViewTextBoxColumn";
            this.urbanistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fazaDataGridViewTextBoxColumn
            // 
            this.fazaDataGridViewTextBoxColumn.DataPropertyName = "faza";
            this.fazaDataGridViewTextBoxColumn.HeaderText = "faza";
            this.fazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fazaDataGridViewTextBoxColumn.Name = "fazaDataGridViewTextBoxColumn";
            this.fazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "napomena";
            this.napomenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumUgovoraDataGridViewTextBoxColumn
            // 
            this.datumUgovoraDataGridViewTextBoxColumn.DataPropertyName = "datumUgovora";
            this.datumUgovoraDataGridViewTextBoxColumn.HeaderText = "datumUgovora";
            this.datumUgovoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumUgovoraDataGridViewTextBoxColumn.Name = "datumUgovoraDataGridViewTextBoxColumn";
            this.datumUgovoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokPoUgovoruDataGridViewTextBoxColumn
            // 
            this.rokPoUgovoruDataGridViewTextBoxColumn.DataPropertyName = "rokPoUgovoru";
            this.rokPoUgovoruDataGridViewTextBoxColumn.HeaderText = "rokPoUgovoru";
            this.rokPoUgovoruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rokPoUgovoruDataGridViewTextBoxColumn.Name = "rokPoUgovoruDataGridViewTextBoxColumn";
            this.rokPoUgovoruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obimDataGridViewTextBoxColumn
            // 
            this.obimDataGridViewTextBoxColumn.DataPropertyName = "obim";
            this.obimDataGridViewTextBoxColumn.HeaderText = "obim";
            this.obimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obimDataGridViewTextBoxColumn.Name = "obimDataGridViewTextBoxColumn";
            this.obimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // krajnjiRokDataGridViewTextBoxColumn
            // 
            this.krajnjiRokDataGridViewTextBoxColumn.DataPropertyName = "krajnjiRok";
            this.krajnjiRokDataGridViewTextBoxColumn.HeaderText = "krajnjiRok";
            this.krajnjiRokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.krajnjiRokDataGridViewTextBoxColumn.Name = "krajnjiRokDataGridViewTextBoxColumn";
            this.krajnjiRokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioritetDataGridViewTextBoxColumn
            // 
            this.prioritetDataGridViewTextBoxColumn.DataPropertyName = "prioritet";
            this.prioritetDataGridViewTextBoxColumn.HeaderText = "prioritet";
            this.prioritetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prioritetDataGridViewTextBoxColumn.Name = "prioritetDataGridViewTextBoxColumn";
            this.prioritetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 801);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UgovoriForm";
            this.Text = "UgovoriForm";
            this.Load += new System.EventHandler(this.UgovoriForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.BindingSource ugovoriDataSetBindingSource;
        private ugovoriDataSet ugovoriDataSet;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private ugovoriDataSetTableAdapters.ugovorTableAdapter ugovorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPlanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urbanistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUgovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokPoUgovoruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajnjiRokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritetDataGridViewTextBoxColumn;
    }
}