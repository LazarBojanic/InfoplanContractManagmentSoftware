using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class UgovoriForm : Form {
        public Ugovor ugovor { get; set; }
        public UgovoriForm() {
            InitializeComponent();
        }

        private void UgovoriForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'ugovoriDataSet.ugovor' table. You can move, or remove it, as needed.
            this.ugovorTableAdapter.Fill(this.ugovoriDataSet.ugovor);
        }

        private void UgovoriForm_Load_1(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'ugovoriDataSet.ugovor' table. You can move, or remove it, as needed.
            this.ugovorTableAdapter.Fill(this.ugovoriDataSet.ugovor);

        }

        

        private void buttonDodaj_Click(object sender, EventArgs e) {
            UpdateForm updateForm1 = new UpdateForm();
            updateForm1.loadUgovor(0);
            updateForm1.Show();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e) {
            UpdateForm updateForm2 = new UpdateForm();
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            updateForm2.loadUgovor(id);
            updateForm2.Show();
        }
    }
}
