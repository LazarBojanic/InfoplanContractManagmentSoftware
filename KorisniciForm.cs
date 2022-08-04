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
    public partial class KorisniciForm : Form {
        public KorisniciForm() {
            InitializeComponent();
            fillKorisniciDataGrid();
        }

        private void KorisniciForm_Load(object sender, EventArgs e) {

        }

        public void fillKorisniciDataGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "SELECT username, privilegija FROM korisnik ORDER BY username";
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
    }
}
