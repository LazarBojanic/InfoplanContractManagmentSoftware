namespace CSharp_SQL_App {
    partial class InfoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.labelVerzija = new System.Windows.Forms.Label();
            this.labelKreator = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxInfoplan = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVerzija
            // 
            this.labelVerzija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVerzija.AutoSize = true;
            this.labelVerzija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerzija.Location = new System.Drawing.Point(682, 503);
            this.labelVerzija.Name = "labelVerzija";
            this.labelVerzija.Size = new System.Drawing.Size(91, 17);
            this.labelVerzija.TabIndex = 2;
            this.labelVerzija.Text = "Verzija: 1.0";
            this.labelVerzija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKreator
            // 
            this.labelKreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKreator.AutoSize = true;
            this.labelKreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKreator.Location = new System.Drawing.Point(682, 520);
            this.labelKreator.Name = "labelKreator";
            this.labelKreator.Size = new System.Drawing.Size(171, 17);
            this.labelKreator.TabIndex = 3;
            this.labelKreator.Text = "Kreator: Lazar Bojanić";
            this.labelKreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(682, 537);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(247, 17);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail: lazarbojanic5@gmail.com";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxInfoplan
            // 
            this.pictureBoxInfoplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInfoplan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfoplan.Image")));
            this.pictureBoxInfoplan.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInfoplan.Name = "pictureBoxInfoplan";
            this.pictureBoxInfoplan.Size = new System.Drawing.Size(917, 473);
            this.pictureBoxInfoplan.TabIndex = 6;
            this.pictureBoxInfoplan.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 63);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.Location = new System.Drawing.Point(365, 491);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(211, 63);
            this.buttonZatvori.TabIndex = 0;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click_1);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 566);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxInfoplan);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelKreator);
            this.Controls.Add(this.labelVerzija);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(957, 605);
            this.MinimumSize = new System.Drawing.Size(957, 605);
            this.Name = "InfoForm";
            this.Text = "Detalji o firmi i softveru";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVerzija;
        private System.Windows.Forms.Label labelKreator;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxInfoplan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonZatvori;
    }
}