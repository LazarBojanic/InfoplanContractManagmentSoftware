namespace CSharp_SQL_App.forms {
    partial class OpstineUpdateForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpstineUpdateForm));
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.textBoxOpstina = new System.Windows.Forms.TextBox();
            this.labelOpstina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.buttonOtkazi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOtkazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtkazi.Location = new System.Drawing.Point(241, 123);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(122, 63);
            this.buttonOtkazi.TabIndex = 2;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // textBoxOpstina
            // 
            this.textBoxOpstina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOpstina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpstina.Location = new System.Drawing.Point(115, 50);
            this.textBoxOpstina.Name = "textBoxOpstina";
            this.textBoxOpstina.Size = new System.Drawing.Size(214, 23);
            this.textBoxOpstina.TabIndex = 0;
            // 
            // labelOpstina
            // 
            this.labelOpstina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOpstina.AutoSize = true;
            this.labelOpstina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpstina.Location = new System.Drawing.Point(51, 53);
            this.labelOpstina.Name = "labelOpstina";
            this.labelOpstina.Size = new System.Drawing.Size(58, 17);
            this.labelOpstina.TabIndex = 3;
            this.labelOpstina.Text = "Opština";
            // 
            // OpstineUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.labelOpstina);
            this.Controls.Add(this.textBoxOpstina);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSacuvaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(437, 268);
            this.Name = "OpstineUpdateForm";
            this.Text = "Dodavanje/izmena opštine";
            this.Load += new System.EventHandler(this.OpstineUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.TextBox textBoxOpstina;
        private System.Windows.Forms.Label labelOpstina;
    }
}