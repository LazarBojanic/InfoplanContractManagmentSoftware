namespace CSharp_SQL_App {
    partial class UpdateForm {
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
            this.textBoxNazivPlana = new System.Windows.Forms.TextBox();
            this.textBoxUrbanista = new System.Windows.Forms.TextBox();
            this.textBoxFaza = new System.Windows.Forms.TextBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.textBoxObim = new System.Windows.Forms.TextBox();
            this.textBoxRokPoUgovoru = new System.Windows.Forms.TextBox();
            this.textBoxPrioritet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimeKrajnjiRok = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDatumUgovora = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOpstina = new System.Windows.Forms.ComboBox();
            this.labelUGuid = new System.Windows.Forms.Label();
            this.textBoxUGuid = new System.Windows.Forms.TextBox();
            this.opstinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovoriDataSet = new CSharp_SQL_App.ugovoriDataSet();
            this.opstinaTableAdapter = new CSharp_SQL_App.ugovoriDataSetTableAdapters.opstinaTableAdapter();
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorTableAdapter = new CSharp_SQL_App.ugovoriDataSetTableAdapters.ugovorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazivPlana
            // 
            this.textBoxNazivPlana.Location = new System.Drawing.Point(132, 128);
            this.textBoxNazivPlana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNazivPlana.Name = "textBoxNazivPlana";
            this.textBoxNazivPlana.Size = new System.Drawing.Size(301, 22);
            this.textBoxNazivPlana.TabIndex = 1;
            // 
            // textBoxUrbanista
            // 
            this.textBoxUrbanista.Location = new System.Drawing.Point(132, 175);
            this.textBoxUrbanista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUrbanista.Name = "textBoxUrbanista";
            this.textBoxUrbanista.Size = new System.Drawing.Size(301, 22);
            this.textBoxUrbanista.TabIndex = 2;
            // 
            // textBoxFaza
            // 
            this.textBoxFaza.Location = new System.Drawing.Point(132, 222);
            this.textBoxFaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFaza.Name = "textBoxFaza";
            this.textBoxFaza.Size = new System.Drawing.Size(301, 22);
            this.textBoxFaza.TabIndex = 3;
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(132, 269);
            this.textBoxNapomena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(301, 22);
            this.textBoxNapomena.TabIndex = 4;
            // 
            // textBoxObim
            // 
            this.textBoxObim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObim.Location = new System.Drawing.Point(602, 173);
            this.textBoxObim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxObim.Name = "textBoxObim";
            this.textBoxObim.Size = new System.Drawing.Size(301, 22);
            this.textBoxObim.TabIndex = 7;
            // 
            // textBoxRokPoUgovoru
            // 
            this.textBoxRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRokPoUgovoru.Location = new System.Drawing.Point(602, 126);
            this.textBoxRokPoUgovoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRokPoUgovoru.Name = "textBoxRokPoUgovoru";
            this.textBoxRokPoUgovoru.Size = new System.Drawing.Size(301, 22);
            this.textBoxRokPoUgovoru.TabIndex = 8;
            // 
            // textBoxPrioritet
            // 
            this.textBoxPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrioritet.Location = new System.Drawing.Point(602, 267);
            this.textBoxPrioritet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrioritet.Name = "textBoxPrioritet";
            this.textBoxPrioritet.Size = new System.Drawing.Size(301, 22);
            this.textBoxPrioritet.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Opstina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv plana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Urbanista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Faza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Napomena";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Datum ugovora";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rok po ugovoru";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Obim";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Krajnji rok";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Prioritet";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSacuvaj.Location = new System.Drawing.Point(125, 335);
            this.buttonSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(266, 83);
            this.buttonSacuvaj.TabIndex = 20;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOtkazi.Location = new System.Drawing.Point(560, 335);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(266, 83);
            this.buttonOtkazi.TabIndex = 21;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxId.Location = new System.Drawing.Point(132, 32);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(301, 22);
            this.textBoxId.TabIndex = 22;
            // 
            // dateTimeKrajnjiRok
            // 
            this.dateTimeKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeKrajnjiRok.Location = new System.Drawing.Point(602, 220);
            this.dateTimeKrajnjiRok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeKrajnjiRok.Name = "dateTimeKrajnjiRok";
            this.dateTimeKrajnjiRok.Size = new System.Drawing.Size(301, 22);
            this.dateTimeKrajnjiRok.TabIndex = 24;
            // 
            // dateTimeDatumUgovora
            // 
            this.dateTimeDatumUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDatumUgovora.Location = new System.Drawing.Point(602, 79);
            this.dateTimeDatumUgovora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeDatumUgovora.Name = "dateTimeDatumUgovora";
            this.dateTimeDatumUgovora.Size = new System.Drawing.Size(301, 22);
            this.dateTimeDatumUgovora.TabIndex = 25;
            // 
            // comboBoxOpstina
            // 
            this.comboBoxOpstina.FormattingEnabled = true;
            this.comboBoxOpstina.Location = new System.Drawing.Point(132, 79);
            this.comboBoxOpstina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOpstina.Name = "comboBoxOpstina";
            this.comboBoxOpstina.Size = new System.Drawing.Size(301, 24);
            this.comboBoxOpstina.TabIndex = 26;
            // 
            // labelUGuid
            // 
            this.labelUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUGuid.AutoSize = true;
            this.labelUGuid.Location = new System.Drawing.Point(490, 35);
            this.labelUGuid.Name = "labelUGuid";
            this.labelUGuid.Size = new System.Drawing.Size(42, 16);
            this.labelUGuid.TabIndex = 28;
            this.labelUGuid.Text = "uGuid";
            // 
            // textBoxUGuid
            // 
            this.textBoxUGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUGuid.Location = new System.Drawing.Point(602, 32);
            this.textBoxUGuid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUGuid.Name = "textBoxUGuid";
            this.textBoxUGuid.ReadOnly = true;
            this.textBoxUGuid.Size = new System.Drawing.Size(301, 22);
            this.textBoxUGuid.TabIndex = 27;
            // 
            // opstinaBindingSource
            // 
            this.opstinaBindingSource.DataMember = "opstina";
            this.opstinaBindingSource.DataSource = this.ugovoriDataSet;
            // 
            // ugovoriDataSet
            // 
            this.ugovoriDataSet.DataSetName = "ugovoriDataSet";
            this.ugovoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opstinaTableAdapter
            // 
            this.opstinaTableAdapter.ClearBeforeFill = true;
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
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 452);
            this.Controls.Add(this.labelUGuid);
            this.Controls.Add(this.textBoxUGuid);
            this.Controls.Add(this.comboBoxOpstina);
            this.Controls.Add(this.dateTimeDatumUgovora);
            this.Controls.Add(this.dateTimeKrajnjiRok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrioritet);
            this.Controls.Add(this.textBoxRokPoUgovoru);
            this.Controls.Add(this.textBoxObim);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.textBoxFaza);
            this.Controls.Add(this.textBoxUrbanista);
            this.Controls.Add(this.textBoxNazivPlana);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(969, 499);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNazivPlana;
        private System.Windows.Forms.TextBox textBoxUrbanista;
        private System.Windows.Forms.TextBox textBoxFaza;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.TextBox textBoxObim;
        private System.Windows.Forms.TextBox textBoxRokPoUgovoru;
        private System.Windows.Forms.TextBox textBoxPrioritet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimeKrajnjiRok;
        private System.Windows.Forms.DateTimePicker dateTimeDatumUgovora;
        private System.Windows.Forms.ComboBox comboBoxOpstina;
        private ugovoriDataSet ugovoriDataSet;
        private System.Windows.Forms.BindingSource opstinaBindingSource;
        private ugovoriDataSetTableAdapters.opstinaTableAdapter opstinaTableAdapter;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private ugovoriDataSetTableAdapters.ugovorTableAdapter ugovorTableAdapter;
        private System.Windows.Forms.Label labelUGuid;
        private System.Windows.Forms.TextBox textBoxUGuid;
    }
}