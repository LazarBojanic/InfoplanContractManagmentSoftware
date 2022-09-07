using CSharp_SQL_App.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class TipUgovoraForm : Form {
        public static String tipUgovoraZaIzmenu;
        public static String tipUgovora;
        public TipUgovoraForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewTipUgovora, new object[] { true });
            fillTipUgovoraDataGrid();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
                buttonObrisi.Enabled = false;
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            TipUgovoraUpdateForm tipUgovoraUpdateForm = new TipUgovoraUpdateForm("dodavanje", "");
            if (tipUgovoraUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                addTipUgovora();
                fillTipUgovoraDataGrid();
            }
        }
        private void buttonIzmeni_Click(object sender, EventArgs e) {
            if (dataGridViewTipUgovora.SelectedRows.Count > 0) {
                TipUgovoraUpdateForm tipUgovoraUpdateForm = new TipUgovoraUpdateForm("izmena",
                    dataGridViewTipUgovora.SelectedRows[0].Cells["tipUgovora"].Value.ToString());
                if (tipUgovoraUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    updateTipUgovora();
                    fillTipUgovoraDataGrid();
                }
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e) {
            ConfirmationForm confirmationForm = new ConfirmationForm();
            if (dataGridViewTipUgovora.SelectedRows.Count > 0) {
                if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                    String tipUgovora = dataGridViewTipUgovora.SelectedRows[0].Cells["tipUgovora"].Value.ToString();
                    OleDbConnection connection;
                    OleDbCommand command;
                    String query = "DELETE FROM tipUgovora WHERE tipUgovora = @tipUgovora";
                    connection = GetConnection();
                    connection.Open();
                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                    command.ExecuteNonQuery();
                    connection.Close();
                    fillTipUgovoraDataGrid();
                }
            }
        }
        public void addTipUgovora() {
            if (!string.IsNullOrEmpty(tipUgovora)) {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = GetConnection();
                connection.Open();
                String query = "INSERT INTO tipUgovora (tipUgovora) VALUES (@tipUgovora)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewTipUgovora.DataSource = bs;
                connection.Close();
            }
        }
        public void updateTipUgovora() {
            if (!string.IsNullOrEmpty(tipUgovora)) {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = GetConnection();
                connection.Open();
                String query = "UPDATE tipUgovora SET tipUgovora = @tipUgovora WHERE tipUgovora = @tipUgovoraZaIzmenu";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                command.Parameters.AddWithValue("@tipUgovoraZaIzmenu", tipUgovoraZaIzmenu);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewTipUgovora.DataSource = bs;
                connection.Close();
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

        private void TipUgovoraForm_Load(object sender, EventArgs e) {

        }
        private void TipUgovoraForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void TipUgovoraForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }

        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void TipUgovoraForm_Click(object sender, EventArgs e) {
            dataGridViewTipUgovora.ClearSelection();
        }

        private void dataGridViewTipUgovora_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewTipUgovora.SelectedRows.Count > 0) {
                TipUgovoraUpdateForm tipUgovoraUpdateForm = new TipUgovoraUpdateForm("izmena",
                    dataGridViewTipUgovora.SelectedRows[0].Cells["tipUgovora"].Value.ToString());
                if (tipUgovoraUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    updateTipUgovora();
                    fillTipUgovoraDataGrid();
                }
            }
        }
    }
}
