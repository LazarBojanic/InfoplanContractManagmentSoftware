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
    public partial class UpdateForm : Form {
        private Ugovor oldUgovor;
        private Ugovor newUgovor;
        public UpdateForm() {
            InitializeComponent();
            loadOpstinaComboBox();
            loadTipUgovoraComboBox();
            loadStatusComboBox();
        }
        public void loadUgovor(int id) {
            oldUgovor = new Ugovor();
            newUgovor = new Ugovor();
            newUgovor.uGuid = newUgovor.uGuid;
            if (id != 0) {
                oldUgovor.loadFromDatabase(id);
            }
        }
        public void loadOpstinaComboBox() {
            OleDbConnection connection = GetConnection();
            connection.Open();
            string query = "SELECT * FROM opstina ORDER BY opstina";
            OleDbCommand command = new OleDbCommand(query, connection);
            DataTable table = new DataTable ("opstina");
            table.Load(command.ExecuteReader());
            foreach (DataRow row in table.Rows) {
                comboBoxOpstina.Items.Add(row["opstina"].ToString());
            }
            connection.Close();
        }
        public void loadTipUgovoraComboBox() {
            OleDbConnection connection = GetConnection();
            connection.Open();
            string query = "SELECT * FROM tipUgovora ORDER BY tipUgovora";
            OleDbCommand command = new OleDbCommand(query, connection);
            DataTable table = new DataTable("tipUgovora");
            table.Load(command.ExecuteReader());
            foreach (DataRow row in table.Rows) {
                comboBoxTipUgovora.Items.Add(row["tipUgovora"].ToString());
            }
            connection.Close();
        }
        public void loadStatusComboBox() {
            OleDbConnection connection = GetConnection();
            connection.Open();
            string query = "SELECT * FROM status ORDER BY status";
            OleDbCommand command = new OleDbCommand(query, connection);
            DataTable table = new DataTable("status");
            table.Load(command.ExecuteReader());
            foreach (DataRow row in table.Rows) {
                comboBoxStatus.Items.Add(row["status"].ToString());
            }
            connection.Close();
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        private void UpdateForm_Load(object sender, EventArgs e) {
            textBoxId.Text = oldUgovor.id.ToString();
            textBoxUGuid.Text = oldUgovor.uGuid;
            comboBoxOpstina.Text = oldUgovor.opstina.ToString();
            textBoxNazivPlana.Text = oldUgovor.nazivPlana;
            textBoxUrbanista.Text = oldUgovor.urbanista;
            comboBoxTipUgovora.Text = oldUgovor.tipUgovora;
            textBoxFaza.Text = oldUgovor.faza;
            textBoxNapomena.Text = oldUgovor.napomena;
            dateTimeDatumUgovora.Value = oldUgovor.datumUgovora;
            if (!oldUgovor.rokPoUgovoru.Equals("")) {
                textBoxRokPoUgovoru.Text = oldUgovor.rokPoUgovoru.Substring(0, oldUgovor.rokPoUgovoru.IndexOf(" "));
                comboBoxRokPoUgovoru.Text = oldUgovor.rokPoUgovoru.Substring(oldUgovor.rokPoUgovoru.IndexOf(" ") + 1);
            }
            else {
                textBoxRokPoUgovoru.Text = "0";
                comboBoxRokPoUgovoru.SelectedIndex = 2;
            }
            textBoxObim.Text = oldUgovor.obim.ToString();
            dateTimeKrajnjiRok.Value = oldUgovor.krajnjiRok;
            textBoxPrioritet.Text = oldUgovor.prioritet.ToString();
            textBoxCena.Text = oldUgovor.cena.ToString();
            comboBoxOpstina.SelectedIndex = 0;
            comboBoxTipUgovora.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 2;
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e) {         
            try {
                if(oldUgovor.id != 0) {
                    Ugovor dbUgovor = new Ugovor();
                    dbUgovor.loadFromDatabase(oldUgovor.id);
                    if (dbUgovor.vremeUgovora > oldUgovor.vremeUgovora) {
                        MessageBox.Show("Podatke o ovom ugovoru u bazi podataka je neko drugi već izmenio. Morate ponovo da pokrenete formu, osvežiti tabelu i uneti vaše izmene.");
                        return;
                    }
                }               
                newUgovor.id = oldUgovor.id;
                newUgovor.opstina = comboBoxOpstina.Text;
                newUgovor.nazivPlana = textBoxNazivPlana.Text;
                newUgovor.urbanista = textBoxUrbanista.Text;
                newUgovor.tipUgovora = comboBoxTipUgovora.Text;
                newUgovor.faza = textBoxFaza.Text;
                newUgovor.napomena = textBoxNapomena.Text;
                newUgovor.datumUgovora = dateTimeDatumUgovora.Value;
                newUgovor.rokPoUgovoru = textBoxRokPoUgovoru.Text + " " + comboBoxRokPoUgovoru.Text;
                newUgovor.obim = Int32.Parse(textBoxObim.Text);
                newUgovor.krajnjiRok = dateTimeKrajnjiRok.Value;
                newUgovor.prioritet = Int32.Parse(textBoxPrioritet.Text);
                newUgovor.cena = Decimal.Parse(textBoxCena.Text);
                newUgovor.status = comboBoxStatus.Text;
                newUgovor.vremeUgovora = DateTime.Now;
                newUgovor.uGuid = oldUgovor.uGuid;
                newUgovor.saveToDatabase();
                ChangeLog.addChangeLogForUgovor(oldUgovor, newUgovor);
                this.DialogResult = DialogResult.OK;
            }
            catch(FormatException) {
                MessageBox.Show("Nekorektan format podataka.");                
            }
        }
        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void dateTimeDatumUgovora_ValueChanged(object sender, EventArgs e) {
            dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value;
            if (!textBoxRokPoUgovoru.Text.Equals("")) {
                if (comboBoxRokPoUgovoru.Text.Equals("Dani")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Nedelje")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text) * 7);
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Meseci")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddMonths(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Godine")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddYears(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
            }
        }
        private void textBoxRokPoUgovoru_TextChanged(object sender, EventArgs e) {
            dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value;
            if (!textBoxRokPoUgovoru.Text.Equals("")) {
                if (comboBoxRokPoUgovoru.Text.Equals("Dani")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Nedelje")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text) * 7);
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Meseci")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddMonths(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if(comboBoxRokPoUgovoru.Text.Equals("Godine")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddYears(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
            }
        }
        private void comboBoxRokPoUgovoru_SelectedValueChanged(object sender, EventArgs e) {
            dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value;
            if (!textBoxRokPoUgovoru.Text.Equals("")) {
                if (comboBoxRokPoUgovoru.Text.Equals("Dani")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Nedelje")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text) * 7);
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Meseci")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddMonths(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Godine")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddYears(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
            }
        }
        private void textBoxRokPoUgovoru_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
        private void textBoxObim_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void textBoxPrioritet_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void textBoxCena_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.')) {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        
    }
}
