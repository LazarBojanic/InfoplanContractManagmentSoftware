﻿namespace CSharp_SQL_App {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpstineForm));
            this.dataGridViewOpstine = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttontZatvori = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.opstinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpstine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOpstine
            // 
            this.dataGridViewOpstine.AllowUserToAddRows = false;
            this.dataGridViewOpstine.AllowUserToDeleteRows = false;
            this.dataGridViewOpstine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOpstine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOpstine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOpstine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpstine.Location = new System.Drawing.Point(11, 11);
            this.dataGridViewOpstine.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOpstine.MultiSelect = false;
            this.dataGridViewOpstine.Name = "dataGridViewOpstine";
            this.dataGridViewOpstine.ReadOnly = true;
            this.dataGridViewOpstine.RowHeadersWidth = 51;
            this.dataGridViewOpstine.RowTemplate.Height = 24;
            this.dataGridViewOpstine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOpstine.Size = new System.Drawing.Size(507, 429);
            this.dataGridViewOpstine.TabIndex = 0;
            this.dataGridViewOpstine.TabStop = false;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.Location = new System.Drawing.Point(11, 456);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(112, 63);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttontZatvori
            // 
            this.buttontZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttontZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttontZatvori.Location = new System.Drawing.Point(406, 456);
            this.buttontZatvori.Margin = new System.Windows.Forms.Padding(2);
            this.buttontZatvori.Name = "buttontZatvori";
            this.buttontZatvori.Size = new System.Drawing.Size(112, 63);
            this.buttontZatvori.TabIndex = 3;
            this.buttontZatvori.Text = "Zatvori";
            this.buttontZatvori.UseVisualStyleBackColor = true;
            this.buttontZatvori.Click += new System.EventHandler(this.buttontZatvori_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonIzmeni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonIzmeni.Location = new System.Drawing.Point(142, 456);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(112, 63);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // opstinaBindingSource
            // 
            this.opstinaBindingSource.DataMember = "opstina";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.Location = new System.Drawing.Point(273, 456);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(112, 63);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // OpstineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 530);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttontZatvori);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewOpstine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(545, 569);
            this.Name = "OpstineForm";
            this.Text = "Opštine";
            this.Load += new System.EventHandler(this.OpstineForm_Load);
            this.ResizeBegin += new System.EventHandler(this.OpstineForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.OpstineForm_ResizeEnd);
            this.Click += new System.EventHandler(this.OpstineForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpstine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOpstine;
        private System.Windows.Forms.BindingSource opstinaBindingSource;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttontZatvori;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
    }
}