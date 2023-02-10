using CSharp_SQL_App.forms;
using CSharp_SQL_App.model;
using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class KorisniciForm : Form {
        public static User user;
        private static int cellIndex;
        public KorisniciForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewKorisnici, new object[] { true });
            fillKorisniciDataGrid();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
                buttonObrisi.Enabled = false;
            }
        }
        public void fillKorisniciDataGrid() {
            try {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                string query = "SELECT id, [username], privilegija FROM korisnik ORDER BY id";
                command = new OleDbCommand(query, connection);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewKorisnici.DataSource = bs;
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
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
            if (dataGridViewKorisnici.SelectedRows.Count > 0) {
                int id = int.Parse(dataGridViewKorisnici.SelectedRows[0].Cells["id"].Value.ToString());
                string username = dataGridViewKorisnici.SelectedRows[0].Cells["username"].Value.ToString();
                string privilegija = dataGridViewKorisnici.SelectedRows[0].Cells["privilegija"].Value.ToString();
                user = new User(id, username, "", privilegija);
                KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
                if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    fillKorisniciDataGrid();
                }
            }
        }
        private void KorisniciForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void KorisniciForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void KorisniciForm_Click(object sender, EventArgs e) {
            dataGridViewKorisnici.ClearSelection();
        }
        private void dataGridViewKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewKorisnici.SelectedRows.Count > 0) {
                int id = int.Parse(dataGridViewKorisnici.SelectedRows[0].Cells["id"].Value.ToString());
                string username = dataGridViewKorisnici.SelectedRows[0].Cells["username"].Value.ToString();
                string privilegija = dataGridViewKorisnici.SelectedRows[0].Cells["privilegija"].Value.ToString();
                user = new User(id, username, "", privilegija);
                KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
                if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                    fillKorisniciDataGrid();
                }
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e) {
            try {
                ConfirmationForm confirmationForm = new ConfirmationForm();
                if (dataGridViewKorisnici.SelectedRows.Count > 0) {
                    if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                        int id = int.Parse(dataGridViewKorisnici.SelectedRows[0].Cells["id"].Value.ToString());
                        OleDbConnection connection;
                        OleDbCommand command;
                        string query = "DELETE FROM korisnik WHERE id = @id";
                        connection = Util.GetConnection();
                        connection.Open();
                        command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                        fillKorisniciDataGrid();
                    }
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void kopirajPoljeToolStripMenuItem_Click(object sender, EventArgs e) {
            User user = Util.getUserFromSelectedRow(dataGridViewKorisnici);
            string value = Util.getUserCellValue(user, cellIndex);
            if (this.dataGridViewKorisnici.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(value);
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void kopirajRedToolStripMenuItem_Click(object sender, EventArgs e) {
            User user = Util.getUserFromSelectedRow(dataGridViewKorisnici);
            if (this.dataGridViewKorisnici.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(Util.buildClipboardUserString(user));
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void dataGridViewKorisnici_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
            cellIndex = e.ColumnIndex;
        }
    }
}