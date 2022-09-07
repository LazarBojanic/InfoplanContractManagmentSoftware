using CSharp_SQL_App.forms;
using CSharp_SQL_App.model;
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
    public partial class OpstineForm : Form {
        public static String opstina;
        public static String opstinaZaIzmenu;

        public OpstineForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewOpstine, new object[] { true });
            fillOpstineDataGrid();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
                buttonObrisi.Enabled = false;
            }
        }
        private void OpstineForm_Load(object sender, EventArgs e) {
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            OpstineUpdateForm opstineUpdateForm = new OpstineUpdateForm("dodavanje", "");
            if (opstineUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                addOpstina();
                fillOpstineDataGrid();
            }
        }
        private void buttonIzmeni_Click(object sender, EventArgs e) {
            if (dataGridViewOpstine.SelectedRows.Count > 0) {
                OpstineUpdateForm opstineUpdateForm = new OpstineUpdateForm("izmena",
                    dataGridViewOpstine.SelectedRows[0].Cells["opstina"].Value.ToString());
                if (opstineUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    updateOpstina();
                    fillOpstineDataGrid();
                }
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e) {
            ConfirmationForm confirmationForm = new ConfirmationForm();
            if (dataGridViewOpstine.SelectedRows.Count > 0) {
                if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                    String opstina = dataGridViewOpstine.SelectedRows[0].Cells["opstina"].Value.ToString();
                    OleDbConnection connection;
                    OleDbCommand command;
                    String query = "DELETE FROM opstina WHERE opstina = @opstina";
                    connection = GetConnection();
                    connection.Open();
                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@opstina", opstina);
                    command.ExecuteNonQuery();
                    connection.Close();
                    fillOpstineDataGrid();
                }
            }
        }
        public void addOpstina() {
            if (!string.IsNullOrEmpty(opstina)) {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = GetConnection();
                connection.Open();
                String query = "INSERT INTO opstina (opstina) VALUES (@opstina)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@opstina", opstina);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewOpstine.DataSource = bs;
                connection.Close();
            }
        }
        public void updateOpstina() {
            if (!string.IsNullOrEmpty(opstina)) {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = GetConnection();
                connection.Open();
                String query = "UPDATE opstina SET opstina = @opstina WHERE opstina = @opstinaZaIzmenu";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@opstina", opstina);
                command.Parameters.AddWithValue("@opstinaZaIzmenu", opstinaZaIzmenu);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewOpstine.DataSource = bs;
                connection.Close();
            }
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
            dataGridViewOpstine.DataSource = bs;
            connection.Close();
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }

        private void OpstineForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }

        private void OpstineForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }

        private void buttontZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void OpstineForm_Click(object sender, EventArgs e) {
            dataGridViewOpstine.ClearSelection();
        }

        private void dataGridViewOpstine_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewOpstine.SelectedRows.Count > 0) {
                OpstineUpdateForm opstineUpdateForm = new OpstineUpdateForm("izmena",
                    dataGridViewOpstine.SelectedRows[0].Cells["opstina"].Value.ToString());
                if (opstineUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    updateOpstina();
                    fillOpstineDataGrid();
                }
            }
        }
    }
}
