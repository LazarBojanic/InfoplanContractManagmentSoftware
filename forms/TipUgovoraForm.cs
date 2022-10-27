using CSharp_SQL_App.forms;
using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class TipUgovoraForm : Form {
        public static string tipUgovoraZaIzmenu;
        public static string tipUgovora;
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
            try {
                ConfirmationForm confirmationForm = new ConfirmationForm();
                if (dataGridViewTipUgovora.SelectedRows.Count > 0) {
                    if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                        string tipUgovora = dataGridViewTipUgovora.SelectedRows[0].Cells["tipUgovora"].Value.ToString();
                        OleDbConnection connection;
                        OleDbCommand command;
                        string query = "DELETE FROM tipUgovora WHERE tipUgovora = @tipUgovora";
                        connection = Util.GetConnection();
                        connection.Open();
                        command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@tipUgovora", tipUgovora);
                        command.ExecuteNonQuery();
                        connection.Close();
                        fillTipUgovoraDataGrid();
                    }
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void addTipUgovora() {
            try {
                if (!string.IsNullOrEmpty(tipUgovora)) {
                    DataTable dt;
                    BindingSource bs;
                    OleDbConnection connection;
                    OleDbCommand command;
                    connection = Util.GetConnection();
                    connection.Open();
                    string query = "INSERT INTO tipUgovora (tipUgovora) VALUES (@tipUgovora)";
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateTipUgovora() {
            try {
                if (!string.IsNullOrEmpty(tipUgovora)) {
                    DataTable dt;
                    BindingSource bs;
                    OleDbConnection connection;
                    OleDbCommand command;
                    connection = Util.GetConnection();
                    connection.Open();
                    string query = "UPDATE tipUgovora SET tipUgovora = @tipUgovora WHERE tipUgovora = @tipUgovoraZaIzmenu";
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillTipUgovoraDataGrid() {
            try {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                string query = "SELECT * FROM tipUgovora ORDER BY tipUgovora";
                command = new OleDbCommand(query, connection);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewTipUgovora.DataSource = bs;
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
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
        private void kopirajToolStripMenuItem_Click(object sender, EventArgs e) {
            string tipUgovora = dataGridViewTipUgovora.SelectedRows[0].Cells["tipUgovora"].Value.ToString();
            if (this.dataGridViewTipUgovora.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(tipUgovora);
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
    }
}