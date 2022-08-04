using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class MainForm : Form {
        public static User user { get;set;}
        public MainForm() {
            InitializeComponent();
            user = new User(LoginForm.id, LoginForm.username, LoginForm.password, LoginForm.privilegija);
            labelUsername.Text = user.username;
            labelPrivilegija.Text = user.privilegija;
            if(!user.privilegija.Equals("administrator")) {
                buttonKorisnici.Enabled = false;
            }
        }
        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void buttonPrikazOpstina_Click(object sender, EventArgs e) {
            OpstineForm o = new OpstineForm();
            o.Show();
        }

        private void buttonPrikazUgovora_Click(object sender, EventArgs e) {
            UgovoriForm u = new UgovoriForm();
            u.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            LoginForm.getInstance().Show();
            this.Close();
        }

        private void buttonKorisnici_Click(object sender, EventArgs e) {
            KorisniciForm korisniciForm = new KorisniciForm();
            korisniciForm.ShowDialog();
        }

        private void buttonInformacije_Click(object sender, EventArgs e) {
            InfoForm infoForm= new InfoForm();
            infoForm.ShowDialog();
        }
    }
}
