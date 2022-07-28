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
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovoriDataSet = new CSharp_SQL_App.ugovoriDataSet();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.ugovoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorTableAdapter = new CSharp_SQL_App.ugovoriDataSetTableAdapters.ugovorTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataMember = "ugovor";
            this.ugovorBindingSource.DataSource = this.ugovoriDataSet;
            // 
            // ugovoriDataSet
            // 
            this.ugovoriDataSet.DataSetName = "ugovoriDataSet";
            this.ugovoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(193, 559);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(261, 54);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(684, 559);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(261, 54);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // ugovoriDataSetBindingSource
            // 
            this.ugovoriDataSetBindingSource.DataSource = this.ugovoriDataSet;
            this.ugovoriDataSetBindingSource.Position = 0;
            // 
            // ugovorTableAdapter
            // 
            this.ugovorTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(11, 559);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(156, 54);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UgovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 651);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UgovoriForm";
            this.Text = "UgovoriForm";
            this.Load += new System.EventHandler(this.UgovoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonRefresh;
    }
}