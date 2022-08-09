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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOpstine = new System.Windows.Forms.Button();
            this.buttonPrikazUgovora = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPrivilegija = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKorisnici = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonIzmenaUsernamePassword = new System.Windows.Forms.Button();
            this.buttonTipoviUgovora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpstine
            // 
            this.buttonOpstine.Location = new System.Drawing.Point(72, 50);
            this.buttonOpstine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpstine.Name = "buttonOpstine";
            this.buttonOpstine.Size = new System.Drawing.Size(155, 63);
            this.buttonOpstine.TabIndex = 0;
            this.buttonOpstine.Text = "Opštine";
            this.buttonOpstine.UseVisualStyleBackColor = true;
            this.buttonOpstine.Click += new System.EventHandler(this.buttonOpstine_Click);
            // 
            // buttonPrikazUgovora
            // 
            this.buttonPrikazUgovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrikazUgovora.Location = new System.Drawing.Point(373, 50);
            this.buttonPrikazUgovora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrikazUgovora.Name = "buttonPrikazUgovora";
            this.buttonPrikazUgovora.Size = new System.Drawing.Size(155, 63);
            this.buttonPrikazUgovora.TabIndex = 1;
            this.buttonPrikazUgovora.Text = "Ugovori";
            this.buttonPrikazUgovora.UseVisualStyleBackColor = true;
            this.buttonPrikazUgovora.Click += new System.EventHandler(this.buttonPrikazUgovora_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(9, 324);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 13);
            this.labelUsername.TabIndex = 3;
            // 
            // labelPrivilegija
            // 
            this.labelPrivilegija.AutoSize = true;
            this.labelPrivilegija.Location = new System.Drawing.Point(9, 344);
            this.labelPrivilegija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrivilegija.Name = "labelPrivilegija";
            this.labelPrivilegija.Size = new System.Drawing.Size(0, 13);
            this.labelPrivilegija.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(527, 314);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(64, 44);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonKorisnici
            // 
            this.buttonKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKorisnici.Location = new System.Drawing.Point(391, 314);
            this.buttonKorisnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKorisnici.Name = "buttonKorisnici";
            this.buttonKorisnici.Size = new System.Drawing.Size(64, 44);
            this.buttonKorisnici.TabIndex = 4;
            this.buttonKorisnici.Text = "Korisnici";
            this.buttonKorisnici.UseVisualStyleBackColor = true;
            this.buttonKorisnici.Click += new System.EventHandler(this.buttonKorisnici_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Location = new System.Drawing.Point(459, 314);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(64, 44);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Detalji";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonIzmenaUsernamePassword
            // 
            this.buttonIzmenaUsernamePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIzmenaUsernamePassword.Location = new System.Drawing.Point(9, 313);
            this.buttonIzmenaUsernamePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmenaUsernamePassword.Name = "buttonIzmenaUsernamePassword";
            this.buttonIzmenaUsernamePassword.Size = new System.Drawing.Size(135, 44);
            this.buttonIzmenaUsernamePassword.TabIndex = 3;
            this.buttonIzmenaUsernamePassword.Text = "Izmena Username/Password-a";
            this.buttonIzmenaUsernamePassword.UseVisualStyleBackColor = true;
            this.buttonIzmenaUsernamePassword.Click += new System.EventHandler(this.buttonIzmenaUsernamePassword_Click);
            // 
            // buttonTipoviUgovora
            // 
            this.buttonTipoviUgovora.Location = new System.Drawing.Point(72, 132);
            this.buttonTipoviUgovora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTipoviUgovora.Name = "buttonTipoviUgovora";
            this.buttonTipoviUgovora.Size = new System.Drawing.Size(155, 63);
            this.buttonTipoviUgovora.TabIndex = 2;
            this.buttonTipoviUgovora.Text = "Tipovi Ugovora";
            this.buttonTipoviUgovora.UseVisualStyleBackColor = true;
            this.buttonTipoviUgovora.Click += new System.EventHandler(this.buttonTipoviUgovora_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonTipoviUgovora);
            this.Controls.Add(this.buttonIzmenaUsernamePassword);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonKorisnici);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelPrivilegija);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonPrikazUgovora);
            this.Controls.Add(this.buttonOpstine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(616, 405);
            this.Name = "MainForm";
            this.Text = "Glavni meni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpstine;
        private System.Windows.Forms.Button buttonPrikazUgovora;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPrivilegija;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonKorisnici;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonIzmenaUsernamePassword;
        private System.Windows.Forms.Button buttonTipoviUgovora;
    }
}