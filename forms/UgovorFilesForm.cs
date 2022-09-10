using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App.forms {
    public partial class UgovorFilesForm : Form {
        private String uGuid;
        public UgovorFilesForm(String parUGuid) {
            InitializeComponent();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonUkloni.Enabled = false;
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
                String query = "SELECT * FROM ugovorFiles WHERE uGuid = @uGuid ORDER BY id";
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
            String filePath;
            if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                filePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            String filePath = openFileDialog.FileName;
            if (!filePath.Equals("")) {
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                String query = "INSERT INTO ugovorFiles (uGuid, fajlPutanja) VALUES (@uGuid, @filePath)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@uGuid", uGuid);
                command.Parameters.AddWithValue("@fajlPutanja", filePath);
                command.ExecuteNonQuery();
                connection.Close();
            }
            fillUgovorFilesDataGrid();
        }
        private void buttonUkloni_Click(object sender, EventArgs e) {
            try {
                ConfirmationForm confirmationForm = new ConfirmationForm();
                if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                    if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                        String selectedFilePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                        OleDbConnection connection;
                        OleDbCommand command;
                        connection = Util.GetConnection();
                        connection.Open();
                        String query = "DELETE FROM ugovorFiles WHERE fajlPutanja = @fajlPutanja";
                        command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@fajlPutanja", selectedFilePath);
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
            String filePath;
            if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                filePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                System.Diagnostics.Process.Start(filePath);
            }
        }
    }
}