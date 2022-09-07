using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App.forms {
    public partial class TipUgovoraUpdateForm : Form {
        public TipUgovoraUpdateForm(String tipAkcije, String izabraniTipUgovora) {
            InitializeComponent();
            if (tipAkcije == "izmena") {    
                textBoxTipUgovora.Text = izabraniTipUgovora;
                TipUgovoraForm.tipUgovoraZaIzmenu = textBoxTipUgovora.Text;
            }
            if(tipAkcije == "dodavenje") {
                textBoxTipUgovora.Text = "";
            }
            this.AcceptButton = buttonSacuvaj;
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            TipUgovoraForm.tipUgovora = textBoxTipUgovora.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
