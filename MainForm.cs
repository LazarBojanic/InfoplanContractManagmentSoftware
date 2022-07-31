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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void buttonPrikazOpstina_Click(object sender, EventArgs e) {
            OpstineForm o = new OpstineForm();
            o.Show();
        }

        private void buttonPrikazUgovora_Click(object sender, EventArgs e) {
            UgovoriForm u = new UgovoriForm();
            u.ShowDialog();
        }
    }
}
