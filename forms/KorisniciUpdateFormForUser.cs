using CSharp_SQL_App.model;
using CSharp_SQL_App.util;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class KorisniciUpdateFormForUser : Form {
        private User user;
        public KorisniciUpdateFormForUser() {
            InitializeComponent();
            textBoxId.Text = MainForm.user.id.ToString();
            textBoxUsername.Text = MainForm.user.username;
            textBoxPassword.Text = MainForm.user.password;
            textBoxPrivilegija.Text = MainForm.user.privilegija;
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            int id = Int32.Parse(textBoxId.Text);
            string username = textBoxUsername.Text;
            string password = Util.encrypt(textBoxPassword.Text);
            string privilegija = textBoxPrivilegija.Text;
            user = new User(id, username, password, privilegija);
            saveToDatabase(user);
        }
        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }
        public void saveToDatabase(User user) {
            try {
                OleDbConnection connection = Util.GetConnection();
                connection.Open();
                if (user.id == 0) {
                    string query = "INSERT INTO korisnik ([username], [password], privilegija) VALUES" +
                        " (@username, @password, @privilegija)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@privilegija", user.privilegija);
                    command.ExecuteNonQuery();
                }
                else {
                    string query = "UPDATE korisnik SET [username] = @username, [password] = @password," +
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}