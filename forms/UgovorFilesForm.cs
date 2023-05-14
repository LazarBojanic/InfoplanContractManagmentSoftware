using InfoplanContractManagmentSoftware.model;
using InfoplanContractManagmentSoftware.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace InfoplanContractManagmentSoftware.forms {
    public partial class UgovorFilesForm : Form {
        private static string uGuid;
        private static int cellIndex;
        public UgovorFilesForm(String parUGuid) {
            InitializeComponent();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonUkloni.Enabled = false;
            }
            if (MainForm.user.privilegija.Equals("turista")) {
                buttonDodaj.Enabled = false;
            }
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewUgovorFiles, new object[] { true });
            uGuid = parUGuid;
        }
        private void UgovorFilesForm_Load(object sender, EventArgs e) {
            fillUgovorFilesDataGrid();
        }
        public void fillUgovorFilesDataGrid() {
            try {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                string query = "SELECT * FROM ugovorFiles WHERE uGuid = @uGuid ORDER BY id";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@uGuid", uGuid);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewUgovorFiles.DataSource = bs;
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPrikazi_Click(object sender, EventArgs e) {
            string filePath;
            if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                filePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Dodavanje fajla";
                openFileDialog.ShowDialog();
                string fajlPutanja = openFileDialog.FileName;
                if (!fajlPutanja.Equals("")) {
                    OleDbConnection connection;
                    OleDbCommand command;
                    connection = Util.GetConnection();
                    connection.Open();
                    string query = "INSERT INTO ugovorFiles (uGuid, fajlPutanja) VALUES (@uGuid, @fajlPutanja)";
                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@uGuid", uGuid);
                    command.Parameters.AddWithValue("@fajlPutanja", fajlPutanja);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                fillUgovorFilesDataGrid();
            }
            catch(OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonUkloni_Click(object sender, EventArgs e) {
            try {
                ConfirmationForm confirmationForm = new ConfirmationForm();
                if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                    if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                        int id = int.Parse(dataGridViewUgovorFiles.SelectedRows[0].Cells["id"].Value.ToString()); OleDbConnection connection;
                        OleDbCommand command;
                        connection = Util.GetConnection();
                        connection.Open();
                        string query = "DELETE FROM ugovorFiles WHERE id = @id";
                        command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                        fillUgovorFilesDataGrid();
                    }
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void UgovorFilesForm_Click(object sender, EventArgs e) {
            dataGridViewUgovorFiles.ClearSelection();
        }
        private void UgovorFilesForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void UgovorFilesForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout();
        }
        private void dataGridViewUgovorFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string filePath;
            if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                filePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }
        private void kopirajPoljeToolStripMenuItem_Click(object sender, EventArgs e) {
            UgovorFile ugovorFile = Util.getUgovorFileFromSelectedRow(dataGridViewUgovorFiles);
            string value = Util.getUgovorFileCellValue(ugovorFile, cellIndex);
            if (this.dataGridViewUgovorFiles.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(value);
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void kopirajRedToolStripMenuItem_Click(object sender, EventArgs e) {
            UgovorFile ugovorFile = Util.getUgovorFileFromSelectedRow(dataGridViewUgovorFiles);
            if (this.dataGridViewUgovorFiles.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(Util.buildClipboardUgovorFileString(ugovorFile));
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void dataGridViewUgovorFiles_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
            cellIndex = e.ColumnIndex;
        }
    }
}