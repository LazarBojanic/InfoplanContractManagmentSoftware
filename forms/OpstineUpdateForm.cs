using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App.forms {
    public partial class OpstineUpdateForm : Form {
        public OpstineUpdateForm(String tipAkcije, String izabranaOpstina) {
            InitializeComponent();
            
            if (tipAkcije == "izmena") {
                textBoxOpstina.Text = izabranaOpstina;
                OpstineForm.opstinaZaIzmenu = textBoxOpstina.Text;
            }
            if (tipAkcije == "dodavenje") {
                textBoxOpstina.Text = "";
            }
            this.AcceptButton = buttonSacuvaj;
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            OpstineForm.opstina = textBoxOpstina.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void OpstineUpdateForm_Load(object sender, EventArgs e) {

        }
    }
}
