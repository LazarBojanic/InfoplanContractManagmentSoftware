namespace CSharp_SQL_App {
    partial class MainForm {
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
            this.buttonPrikazOpstina = new System.Windows.Forms.Button();
            this.buttonPrikazUgovora = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPrivilegija = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKorisnici = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrikazOpstina
            // 
            this.buttonPrikazOpstina.Location = new System.Drawing.Point(96, 62);
            this.buttonPrikazOpstina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrikazOpstina.Name = "buttonPrikazOpstina";
            this.buttonPrikazOpstina.Size = new System.Drawing.Size(207, 77);
            this.buttonPrikazOpstina.TabIndex = 0;
            this.buttonPrikazOpstina.Text = "Prikaz Opština";
            this.buttonPrikazOpstina.UseVisualStyleBackColor = true;
            this.buttonPrikazOpstina.Click += new System.EventHandler(this.buttonPrikazOpstina_Click);
            // 
            // buttonPrikazUgovora
            // 
            this.buttonPrikazUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrikazUgovora.Location = new System.Drawing.Point(497, 62);
            this.buttonPrikazUgovora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrikazUgovora.Name = "buttonPrikazUgovora";
            this.buttonPrikazUgovora.Size = new System.Drawing.Size(207, 77);
            this.buttonPrikazUgovora.TabIndex = 1;
            this.buttonPrikazUgovora.Text = "Prikaz Ugovora";
            this.buttonPrikazUgovora.UseVisualStyleBackColor = true;
            this.buttonPrikazUgovora.Click += new System.EventHandler(this.buttonPrikazUgovora_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 399);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 16);
            this.labelUsername.TabIndex = 3;
            // 
            // labelPrivilegija
            // 
            this.labelPrivilegija.AutoSize = true;
            this.labelPrivilegija.Location = new System.Drawing.Point(12, 423);
            this.labelPrivilegija.Name = "labelPrivilegija";
            this.labelPrivilegija.Size = new System.Drawing.Size(0, 16);
            this.labelPrivilegija.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(703, 386);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(85, 54);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonKorisnici
            // 
            this.buttonKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKorisnici.Location = new System.Drawing.Point(521, 386);
            this.buttonKorisnici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKorisnici.Name = "buttonKorisnici";
            this.buttonKorisnici.Size = new System.Drawing.Size(85, 54);
            this.buttonKorisnici.TabIndex = 6;
            this.buttonKorisnici.Text = "Korisnici";
            this.buttonKorisnici.UseVisualStyleBackColor = true;
            this.buttonKorisnici.Click += new System.EventHandler(this.buttonKorisnici_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Location = new System.Drawing.Point(612, 386);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(85, 54);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Detalji";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonKorisnici);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelPrivilegija);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonPrikazUgovora);
            this.Controls.Add(this.buttonPrikazOpstina);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Glavni meni";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrikazOpstina;
        private System.Windows.Forms.Button buttonPrikazUgovora;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPrivilegija;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonKorisnici;
        private System.Windows.Forms.Button buttonInfo;
    }
}