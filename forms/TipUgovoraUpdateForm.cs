using System;
using System.Windows.Forms;

namespace CSharp_SQL_App.forms {
    public partial class TipUgovoraUpdateForm : Form {
        public TipUgovoraUpdateForm(String tipAkcije, String izabraniTipUgovora) {
            InitializeComponent();
            if (tipAkcije == "izmena") {
                textBoxTipUgovora.Text = izabraniTipUgovora;
                TipUgovoraForm.tipUgovoraZaIzmenu = textBoxTipUgovora.Text;
            }
            if (tipAkcije == "dodavanje") {
                textBoxTipUgovora.Text = "";
            }
            this.AcceptButton = buttonSacuvaj;
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            TipUgovoraForm.tipUgovora = textBoxTipUgovora.Text;
        }
        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}