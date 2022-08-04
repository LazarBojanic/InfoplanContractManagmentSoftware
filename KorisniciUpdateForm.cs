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
    public partial class KorisniciUpdateForm : Form {
        private User user;
        public KorisniciUpdateForm() {
            InitializeComponent();
            loadPrivilegijaComboBox();
            textBoxId.Text = KorisniciForm.user.id.ToString();
            textBoxUsername.Text = KorisniciForm.user.username;
            textBoxPassword.Text = KorisniciForm.user.password;
            comboBoxPrivilegija.Text = KorisniciForm.user.privilegija;
        }
        private void KorisniciUpdateForm_Load(object sender, EventArgs e) {

        }
        public void loadPrivilegijaComboBox() {
            OleDbConnection connection = GetConnection();
            connection.Open();
            string query = "SELECT privilegija FROM privilegija";
            OleDbCommand command = new OleDbCommand(query, connection);
            DataTable table = new DataTable("privilegija");
            table.Load(command.ExecuteReader());
            foreach (DataRow row in table.Rows) {
                comboBoxPrivilegija.Items.Add(row["privilegija"].ToString());
            }
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            int id = Int32.Parse(textBoxId.Text);
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string privilegija = comboBoxPrivilegija.Text;
            user = new User(id, username, password, privilegija);
            saveToDatabase(user);
            this.DialogResult = DialogResult.OK;
        }
        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void saveToDatabase(User user) {
            OleDbConnection connection = GetConnection();
            connection.Open();
            if (user.id == 0) {
                string query = "INSERT INTO korisnik (username, [password], privilegija) VALUES" +
                    " (@username, @password, @privilegija)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@privilegija", user.privilegija);
                int recordsAffected = command.ExecuteNonQuery();
            }
            else {
                string query = "UPDATE korisnik SET username = @username, [password] = @password," +
                    " privilegija = @privilegija WHERE id = @id";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@privilegija", user.privilegija);
                command.Parameters.AddWithValue("@id", user.id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
    }
}
