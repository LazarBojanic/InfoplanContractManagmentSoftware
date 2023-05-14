namespace InfoplanContractManagmentSoftware {
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPrivilegija = new System.Windows.Forms.Label();
            this.buttonOpstine = new System.Windows.Forms.Button();
            this.buttonPrikazUgovora = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKorisnici = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonIzmenaUsernamePassword = new System.Windows.Forms.Button();
            this.buttonTipoviUgovora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(11, 9);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 17);
            this.labelUsername.TabIndex = 3;
            // 
            // labelPrivilegija
            // 
            this.labelPrivilegija.AutoSize = true;
            this.labelPrivilegija.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivilegija.Location = new System.Drawing.Point(11, 30);
            this.labelPrivilegija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrivilegija.Name = "labelPrivilegija";
            this.labelPrivilegija.Size = new System.Drawing.Size(0, 17);
            this.labelPrivilegija.TabIndex = 4;
            // 
            // buttonOpstine
            // 
            this.buttonOpstine.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpstine.Location = new System.Drawing.Point(81, 78);
            this.buttonOpstine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpstine.Name = "buttonOpstine";
            this.buttonOpstine.Size = new System.Drawing.Size(160, 63);
            this.buttonOpstine.TabIndex = 0;
            this.buttonOpstine.Text = "Opštine";
            this.buttonOpstine.UseVisualStyleBackColor = true;
            this.buttonOpstine.Click += new System.EventHandler(this.buttonOpstine_Click);
            // 
            // buttonPrikazUgovora
            // 
            this.buttonPrikazUgovora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazUgovora.Location = new System.Drawing.Point(359, 78);
            this.buttonPrikazUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrikazUgovora.Name = "buttonPrikazUgovora";
            this.buttonPrikazUgovora.Size = new System.Drawing.Size(160, 63);
            this.buttonPrikazUgovora.TabIndex = 1;
            this.buttonPrikazUgovora.Text = "Ugovori";
            this.buttonPrikazUgovora.UseVisualStyleBackColor = true;
            this.buttonPrikazUgovora.Click += new System.EventHandler(this.buttonPrikazUgovora_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonLogout.Location = new System.Drawing.Point(519, 278);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(71, 44);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonKorisnici
            // 
            this.buttonKorisnici.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonKorisnici.Location = new System.Drawing.Point(369, 278);
            this.buttonKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKorisnici.Name = "buttonKorisnici";
            this.buttonKorisnici.Size = new System.Drawing.Size(71, 44);
            this.buttonKorisnici.TabIndex = 4;
            this.buttonKorisnici.Text = "Korisnici";
            this.buttonKorisnici.UseVisualStyleBackColor = true;
            this.buttonKorisnici.Click += new System.EventHandler(this.buttonKorisnici_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonInfo.Location = new System.Drawing.Point(444, 278);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(71, 44);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Detalji";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonIzmenaUsernamePassword
            // 
            this.buttonIzmenaUsernamePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonIzmenaUsernamePassword.Location = new System.Drawing.Point(359, 192);
            this.buttonIzmenaUsernamePassword.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmenaUsernamePassword.Name = "buttonIzmenaUsernamePassword";
            this.buttonIzmenaUsernamePassword.Size = new System.Drawing.Size(160, 63);
            this.buttonIzmenaUsernamePassword.TabIndex = 3;
            this.buttonIzmenaUsernamePassword.Text = "Izmena Username/Password-a";
            this.buttonIzmenaUsernamePassword.UseVisualStyleBackColor = true;
            this.buttonIzmenaUsernamePassword.Click += new System.EventHandler(this.buttonIzmenaUsernamePassword_Click);
            // 
            // buttonTipoviUgovora
            // 
            this.buttonTipoviUgovora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTipoviUgovora.Location = new System.Drawing.Point(81, 192);
            this.buttonTipoviUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTipoviUgovora.Name = "buttonTipoviUgovora";
            this.buttonTipoviUgovora.Size = new System.Drawing.Size(160, 63);
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
            this.ClientSize = new System.Drawing.Size(600, 333);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(616, 372);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni meni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPrivilegija;
        private System.Windows.Forms.Button buttonOpstine;
        private System.Windows.Forms.Button buttonPrikazUgovora;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonKorisnici;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonIzmenaUsernamePassword;
        private System.Windows.Forms.Button buttonTipoviUgovora;
    }
}