using InfoplanContractManagmentSoftware.model;
using System;
using System.Windows.Forms;

namespace InfoplanContractManagmentSoftware {
    public partial class MainForm : Form {
        public static User user { get; set; }
        public MainForm() {
            InitializeComponent();
            user = new User(LoginForm.id, LoginForm.username, LoginForm.password, LoginForm.privilegija);
            labelUsername.Text = user.username;
            labelPrivilegija.Text = user.privilegija;
            if (!user.privilegija.Equals("administrator")) {
                buttonKorisnici.Enabled = false;
            }
        }
        private void buttonPrikazUgovora_Click(object sender, EventArgs e) {
            UgovoriForm u = new UgovoriForm();
            u.ShowDialog();
        }
        private void buttonOpstine_Click(object sender, EventArgs e) {
            OpstineForm o = new OpstineForm();
            o.ShowDialog();
        }
        private void buttonTipoviUgovora_Click(object sender, EventArgs e) {
            TipUgovoraForm t = new TipUgovoraForm();
            t.ShowDialog();
        }
        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginForm.getInstance().Show();
            this.Close();
        }
        private void buttonKorisnici_Click(object sender, EventArgs e) {
            KorisniciForm korisniciForm = new KorisniciForm();
            korisniciForm.ShowDialog();
        }
        private void buttonInfo_Click(object sender, EventArgs e) {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
        private void buttonIzmenaUsernamePassword_Click(object sender, EventArgs e) {
            KorisniciUpdateFormForUser korisniciUpdateFormForUser = new KorisniciUpdateFormForUser();
            korisniciUpdateFormForUser.ShowDialog();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            LoginForm.getInstance().Show();
        }
    }
}