namespace CSharp_SQL_App.forms {
    partial class TipUgovoraUpdateForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipUgovoraUpdateForm));
            this.labelTipUgovora = new System.Windows.Forms.Label();
            this.textBoxTipUgovora = new System.Windows.Forms.TextBox();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTipUgovora
            // 
            this.labelTipUgovora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTipUgovora.AutoSize = true;
            this.labelTipUgovora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipUgovora.Location = new System.Drawing.Point(24, 53);
            this.labelTipUgovora.Name = "labelTipUgovora";
            this.labelTipUgovora.Size = new System.Drawing.Size(85, 17);
            this.labelTipUgovora.TabIndex = 3;
            this.labelTipUgovora.Text = "Tip ugovora";
            // 
            // textBoxTipUgovora
            // 
            this.textBoxTipUgovora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTipUgovora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipUgovora.Location = new System.Drawing.Point(115, 50);
            this.textBoxTipUgovora.Name = "textBoxTipUgovora";
            this.textBoxTipUgovora.Size = new System.Drawing.Size(214, 23);
            this.textBoxTipUgovora.TabIndex = 0;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSacuvaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacuvaj.Location = new System.Drawing.Point(58, 123);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(122, 63);
            this.buttonSacuvaj.TabIndex = 1;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOtkazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtkazi.Location = new System.Drawing.Point(241, 123);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(122, 63);
            this.buttonOtkazi.TabIndex = 2;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // TipUgovoraUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.textBoxTipUgovora);
            this.Controls.Add(this.labelTipUgovora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(437, 268);
            this.Name = "TipUgovoraUpdateForm";
            this.Text = "Dodavanje/izmena tipa ugovora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipUgovora;
        private System.Windows.Forms.TextBox textBoxTipUgovora;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}