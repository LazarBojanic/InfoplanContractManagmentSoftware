using System;
using System.Windows.Forms;

namespace InfoplanContractManagmentSoftware {
    public partial class InfoForm : Form {
        public InfoForm() {
            InitializeComponent();
        }
        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}