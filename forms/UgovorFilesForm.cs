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
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
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
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
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
                connection = GetConnection();
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
            ConfirmationForm confirmationForm = new ConfirmationForm();
            if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                if (dataGridViewUgovorFiles.SelectedRows.Count > 0) {
                    String selectedFilePath = dataGridViewUgovorFiles.SelectedRows[0].Cells["fajlPutanja"].Value.ToString();
                    OleDbConnection connection;
                    OleDbCommand command;
                    connection = GetConnection();
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
    }
}
