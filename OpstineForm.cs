using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class OpstineForm : Form {
        public OpstineForm() {
            InitializeComponent();
        }

        private void OpstineForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'ugovoriDataSet.opstina' table. You can move, or remove it, as needed.
            this.opstinaTableAdapter.Fill(this.ugovoriDataSet.opstina);

        }
    }
}
