using CSharp_SQL_App.util;
using System;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class LoginForm : Form {
        public static int id { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static string privilegija { get; set; }
        private static LoginForm instance { get; set; }
        public LoginForm() {
            InitializeComponent();
            textBoxPassword.PasswordChar = '●';
        }
        public static LoginForm getInstance() {
            if (instance == null) {
                instance = new LoginForm();
            }
            return instance;
        }
        private async void buttonLogin_Click(object sender, EventArgs e) {
            username = textBoxUsername.Text;
            //password = textBoxPassword.Text;
            password = Util.encrypt(textBoxPassword.Text);
            if (login() > 0) {
                id = getId();
                privilegija = getPrivilegija();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else {
                labelGreska.Text = "Pogrešan username ili password";
                await Task.Delay(4000);
                labelGreska.Text = "";
            }
        }
        public int login() {
            try {
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                String query = "SELECT COUNT(*) FROM korisnik WHERE [username] = @username AND [password] = @password";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int found = Int32.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                return found;
            }
            catch (Exception) {
                MessageBox.Show("Nemate instaliran Microsoft Access Database Driver ili niste otvorili odgovarajuću verziju programa.");
                return -1;
            }
        }
        public string getPrivilegija() {
            try {
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                String query = "SELECT privilegija FROM korisnik WHERE [username] = @username AND [password] = @password";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                string privilegija = command.ExecuteScalar().ToString();
                connection.Close();
                return privilegija;
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public int getId() {
            try {
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                String query = "SELECT id FROM korisnik WHERE [username] = @username AND [password] = @password";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int id = Int32.Parse(command.ExecuteScalar().ToString());
                connection.Close();
                return id;
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
        private void buttonIzlaz_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}