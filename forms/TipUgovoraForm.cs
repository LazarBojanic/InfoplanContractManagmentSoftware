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
    public partial class TipUgovoraForm : Form {
        public TipUgovoraForm() {
            InitializeComponent();
            fillTipUgovoraDataGrid();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonDodaj.Enabled = false;
            }
        }
        public void fillTipUgovoraDataGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "SELECT * FROM tipUgovora ORDER BY tipUgovora";
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewTipUgovora.DataSource = bs;
            connection.Close();
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        public void addTipUgovora() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "INSERT INTO tipUgovora (tipUgovora) VALUES (@tipUgovora)";
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@tipUgovora", textBoxTipUgovora.Text);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewTipUgovora.DataSource = bs;
            connection.Close();
        }

        private void TipUgovoraForm_Load(object sender, EventArgs e) {

        }

        private void buttonDodaj_Click(object sender, EventArgs e) {
            addTipUgovora();
            fillTipUgovoraDataGrid();
        }

        private void TipUgovoraForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();        
        }

        private void TipUgovoraForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
    }
}
