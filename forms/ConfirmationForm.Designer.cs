namespace CSharp_SQL_App.forms {
    partial class ConfirmationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationForm));
            this.buttonDa = new System.Windows.Forms.Button();
            this.buttonNe = new System.Windows.Forms.Button();
            this.labelSigurni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDa
            // 
            this.buttonDa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonDa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDa.Location = new System.Drawing.Point(49, 110);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(114, 63);
            this.buttonDa.TabIndex = 0;
            this.buttonDa.Text = "Da";
            this.buttonDa.UseVisualStyleBackColor = true;
            // 
            // buttonNe
            // 
            this.buttonNe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNe.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNe.Location = new System.Drawing.Point(188, 110);
            this.buttonNe.Name = "buttonNe";
            this.buttonNe.Size = new System.Drawing.Size(114, 63);
            this.buttonNe.TabIndex = 1;
            this.buttonNe.Text = "Ne";
            this.buttonNe.UseVisualStyleBackColor = true;
            // 
            // labelSigurni
            // 
            this.labelSigurni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSigurni.AutoSize = true;
            this.labelSigurni.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSigurni.Location = new System.Drawing.Point(74, 41);
            this.labelSigurni.Name = "labelSigurni";
            this.labelSigurni.Size = new System.Drawing.Size(203, 30);
            this.labelSigurni.TabIndex = 2;
            this.labelSigurni.Text = "Da li ste sigurni?";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 185);
            this.Controls.Add(this.labelSigurni);
            this.Controls.Add(this.buttonNe);
            this.Controls.Add(this.buttonDa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(367, 224);
            this.Name = "ConfirmationForm";
            this.Text = "Brisanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDa;
        private System.Windows.Forms.Button buttonNe;
        private System.Windows.Forms.Label labelSigurni;
    }
}