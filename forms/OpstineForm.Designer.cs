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
            this.dataGridViewOpstine = new System.Windows.Forms.DataGridView();
            this.opstinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxOpstina = new System.Windows.Forms.TextBox();
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
            this.dataGridViewOpstine.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewOpstine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOpstine.Name = "dataGridViewOpstine";
            this.dataGridViewOpstine.ReadOnly = true;
            this.dataGridViewOpstine.RowHeadersWidth = 51;
            this.dataGridViewOpstine.RowTemplate.Height = 24;
            this.dataGridViewOpstine.Size = new System.Drawing.Size(340, 401);
            this.dataGridViewOpstine.TabIndex = 0;
            // 
            // opstinaBindingSource
            // 
            this.opstinaBindingSource.DataMember = "opstina";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDodaj.Location = new System.Drawing.Point(92, 457);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(176, 63);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxOpstina
            // 
            this.textBoxOpstina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxOpstina.Location = new System.Drawing.Point(68, 426);
            this.textBoxOpstina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOpstina.Name = "textBoxOpstina";
            this.textBoxOpstina.Size = new System.Drawing.Size(227, 20);
            this.textBoxOpstina.TabIndex = 1;
            // 
            // OpstineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 530);
            this.Controls.Add(this.textBoxOpstina);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewOpstine);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OpstineForm";
            this.Text = "OpstineForm";
            this.Load += new System.EventHandler(this.OpstineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpstine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOpstine;
        private System.Windows.Forms.BindingSource opstinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxOpstina;
    }
}