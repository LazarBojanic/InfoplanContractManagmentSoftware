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

namespace CSharp_SQL_App {
    public partial class OpstineForm : Form {
        public OpstineForm() {
            InitializeComponent();
            fillOpstineDataGrid();
        }
        private void OpstineForm_Load(object sender, EventArgs e) {
        }

        public void fillOpstineDataGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "SELECT * FROM opstina ORDER BY opstina";
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            connection.Close();
        }

        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }

        private void buttonDodaj_Click(object sender, EventArgs e) {
            addOpstina();
            fillOpstineDataGrid();
        }

        public void addOpstina() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "INSERT INTO opstina (opstina) VALUES (@data)";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@data", textBoxOpstina.Text);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            connection.Close();
        }
    }
}
