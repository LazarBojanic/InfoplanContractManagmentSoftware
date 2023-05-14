namespace InfoplanContractManagmentSoftware {
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
            this.pictureBoxInfoplan = new System.Windows.Forms.PictureBox();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoplan)).BeginInit();
            this.SuspendLayout();
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
            // buttonZatvori
            // 
            this.buttonZatvori.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori.Location = new System.Drawing.Point(365, 491);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(211, 63);
            this.buttonZatvori.TabIndex = 0;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 566);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.pictureBoxInfoplan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(957, 605);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxInfoplan;
        private System.Windows.Forms.Button buttonZatvori;
    }
}