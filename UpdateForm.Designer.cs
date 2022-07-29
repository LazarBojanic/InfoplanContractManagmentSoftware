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
            this.textBoxNazivPlana.Location = new System.Drawing.Point(67, 105);
            this.textBoxNazivPlana.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazivPlana.Name = "textBoxNazivPlana";
            this.textBoxNazivPlana.Size = new System.Drawing.Size(227, 20);
            this.textBoxNazivPlana.TabIndex = 1;
            // 
            // textBoxUrbanista
            // 
            this.textBoxUrbanista.Location = new System.Drawing.Point(67, 137);
            this.textBoxUrbanista.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrbanista.Name = "textBoxUrbanista";
            this.textBoxUrbanista.Size = new System.Drawing.Size(227, 20);
            this.textBoxUrbanista.TabIndex = 2;
            // 
            // textBoxFaza
            // 
            this.textBoxFaza.Location = new System.Drawing.Point(67, 179);
            this.textBoxFaza.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFaza.Name = "textBoxFaza";
            this.textBoxFaza.Size = new System.Drawing.Size(227, 20);
            this.textBoxFaza.TabIndex = 3;
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(67, 220);
            this.textBoxNapomena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(227, 20);
            this.textBoxNapomena.TabIndex = 4;
            // 
            // textBoxObim
            // 
            this.textBoxObim.Location = new System.Drawing.Point(382, 135);
            this.textBoxObim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObim.Name = "textBoxObim";
            this.textBoxObim.Size = new System.Drawing.Size(213, 20);
            this.textBoxObim.TabIndex = 7;
            // 
            // textBoxRokPoUgovoru
            // 
            this.textBoxRokPoUgovoru.Location = new System.Drawing.Point(382, 103);
            this.textBoxRokPoUgovoru.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRokPoUgovoru.Name = "textBoxRokPoUgovoru";
            this.textBoxRokPoUgovoru.Size = new System.Drawing.Size(212, 20);
            this.textBoxRokPoUgovoru.TabIndex = 8;
            // 
            // textBoxPrioritet
            // 
            this.textBoxPrioritet.Location = new System.Drawing.Point(382, 218);
            this.textBoxPrioritet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrioritet.Name = "textBoxPrioritet";
            this.textBoxPrioritet.Size = new System.Drawing.Size(212, 20);
            this.textBoxPrioritet.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Opstina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv plana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Urbanista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Faza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Napomena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Datum ugovora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rok po ugovoru";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Obim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Krajnji rok";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Prioritet";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(121, 289);
            this.buttonSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(160, 53);
            this.buttonSacuvaj.TabIndex = 20;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOtkazi.Location = new System.Drawing.Point(369, 290);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(160, 50);
            this.buttonOtkazi.TabIndex = 21;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(238, 19);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(192, 20);
            this.textBoxId.TabIndex = 22;
            // 
            // dateTimeKrajnjiRok
            // 
            this.dateTimeKrajnjiRok.Location = new System.Drawing.Point(382, 177);
            this.dateTimeKrajnjiRok.Name = "dateTimeKrajnjiRok";
            this.dateTimeKrajnjiRok.Size = new System.Drawing.Size(212, 20);
            this.dateTimeKrajnjiRok.TabIndex = 24;
            // 
            // dateTimeDatumUgovora
            // 
            this.dateTimeDatumUgovora.Location = new System.Drawing.Point(382, 64);
            this.dateTimeDatumUgovora.Name = "dateTimeDatumUgovora";
            this.dateTimeDatumUgovora.Size = new System.Drawing.Size(212, 20);
            this.dateTimeDatumUgovora.TabIndex = 25;
            // 
            // comboBoxOpstina
            // 
            this.comboBoxOpstina.FormattingEnabled = true;
            this.comboBoxOpstina.Location = new System.Drawing.Point(67, 62);
            this.comboBoxOpstina.Name = "comboBoxOpstina";
            this.comboBoxOpstina.Size = new System.Drawing.Size(227, 21);
            this.comboBoxOpstina.TabIndex = 26;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 367);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}