using CSharp_SQL_App.model;
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
        public static User user;
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
            String query = "SELECT * FROM korisnik ORDER BY username";
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
            int id = 0;
            string username = "";
            string password = "";
            string privilegija = "";
            user = new User(id, username, password, privilegija);
            KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
            if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                fillKorisniciDataGrid();
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e) {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string username = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string privilegija = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            user = new User(id, username, password, privilegija);
            KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
            if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                fillKorisniciDataGrid();
            }
        }
    }
}
