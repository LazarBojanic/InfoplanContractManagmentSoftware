﻿using CSharp_SQL_App.model;
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
    public partial class KorisniciForm : Form {
        public static User user;
        public KorisniciForm() {
            InitializeComponent();
            fillKorisniciDataGrid();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
            }
        }
        private void KorisniciForm_Load(object sender, EventArgs e) {

        }
        public void fillKorisniciDataGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
            connection.Open();
            String query = "SELECT id, username, privilegija FROM korisnik ORDER BY id";
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewKorisnici.DataSource = bs;
            connection.Close();
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
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
            int id = int.Parse(dataGridViewKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            string username = dataGridViewKorisnici.SelectedRows[0].Cells[1].Value.ToString();
            string privilegija = dataGridViewKorisnici.SelectedRows[0].Cells[2].Value.ToString();
            user = new User(id, username, "", privilegija);
            KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
            if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                fillKorisniciDataGrid();
            }
        }
        private void KorisniciForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void KorisniciForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int id = int.Parse(dataGridViewKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            string username = dataGridViewKorisnici.SelectedRows[0].Cells[1].Value.ToString();
            string privilegija = dataGridViewKorisnici.SelectedRows[0].Cells[2].Value.ToString();
            user = new User(id, username, "", privilegija);
            KorisniciUpdateForm korisniciUpdateForm = new KorisniciUpdateForm();
            if (korisniciUpdateForm.ShowDialog().Equals(DialogResult.OK)) {
                fillKorisniciDataGrid();
            }
        }
    }
}