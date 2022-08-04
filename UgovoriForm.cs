using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            refreshDataGrid();
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            UpdateForm updateForm1 = new UpdateForm();
            updateForm1.loadUgovor(0);
            if (updateForm1.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }
        private void buttonIzmeni_Click(object sender, EventArgs e) {
            UpdateForm updateForm2 = new UpdateForm();
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int index = dataGridView1.CurrentRow.Index;
            updateForm2.loadUgovor(id);
            if (updateForm2.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
            dataGridView1.Rows[index].Selected = true;
        }
        private void buttonRefresh_Click(object sender, EventArgs e) {
            refreshDataGrid();
        }
        public void refreshDataGrid() {
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            DataTable dt;
            String query = "SELECT * FROM ugovor ORDER BY id";
            connection = GetConnection();
            connection.Open();
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        private void buttonIstorijaPromena_Click(object sender, EventArgs e) {
            String uGuid = dataGridView1.SelectedRows[0].Cells["uGuid"].Value.ToString();
            IstorijaPromenaForm i = new IstorijaPromenaForm(uGuid);
            i.ShowDialog();
        }
        private void UgovoriForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();           
        }
        private void UgovoriForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }

    }
}
