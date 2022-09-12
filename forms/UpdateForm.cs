using CSharp_SQL_App.model;
using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class UpdateForm : Form {
        private Ugovor oldUgovor;
        private Ugovor newUgovor;
        private String loadMethod;
        public UpdateForm(String loadMethod) {
            InitializeComponent();
            loadOpstinaComboBox();
            loadTipUgovoraComboBox();
            this.loadMethod = loadMethod;
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
            try {
                OleDbConnection connection = Util.GetConnection();
                connection.Open();
                string query = "SELECT * FROM opstina ORDER BY opstina";
                OleDbCommand command = new OleDbCommand(query, connection);
                DataTable table = new DataTable("opstina");
                table.Load(command.ExecuteReader());
                foreach (DataRow row in table.Rows) {
                    comboBoxOpstina.Items.Add(row["opstina"].ToString());
                }
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadTipUgovoraComboBox() {
            try {
                OleDbConnection connection = Util.GetConnection();
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateForm_Load(object sender, EventArgs e) {
            manageCheckBoxBehavior();
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
                comboBoxRokPoUgovoru.Text = oldUgovor.rokPoUgovoru.Substring(oldUgovor.rokPoUgovoru.IndexOf(" ") + 1);
            }
            dateTimeKrajnjiRok.Value = oldUgovor.krajnjiRok;
            textBoxObim.Text = oldUgovor.obim.ToString();
            textBoxPrioritet.Text = oldUgovor.prioritet.ToString();
            textBoxCena.Text = oldUgovor.cena.ToString();
            comboBoxOpstina.Text = oldUgovor.opstina;
            comboBoxTipUgovora.Text = oldUgovor.tipUgovora;
            if (oldUgovor.usvojen.Equals("Da")) {
                checkBoxUsvojen.Checked = true;
            }
            else {
                checkBoxUsvojen.Checked = false;
            }
            if (loadMethod.Equals("load")) {
                comboBoxTipUgovora.SelectedIndex = 0;
                comboBoxRokPoUgovoru.SelectedIndex = 2;
            }
            if (oldUgovor.datumUsvajanja == new DateTime(1970, 1, 1)) {
                dateTimeDatumUsvajanja.Value = DateTime.Today;
            }
            else {
                dateTimeDatumUsvajanja.Value = oldUgovor.datumUsvajanja;
            }
            textBoxBrojSluzbenogVlasnika.Text = oldUgovor.brojSluzbenogVlasnika;
            textBoxVremeRada.Text = oldUgovor.vremeRada;
        }
        private void buttonSacuvaj_Click(object sender, EventArgs e) {
            try {
                if (oldUgovor.id != 0) {
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
                newUgovor.krajnjiRok = dateTimeKrajnjiRok.Value;
                newUgovor.obim = Int32.Parse(textBoxObim.Text);
                newUgovor.prioritet = Int32.Parse(textBoxPrioritet.Text);
                newUgovor.cena = Decimal.Parse(textBoxCena.Text);
                if (checkBoxUsvojen.Checked) {
                    newUgovor.usvojen = "Da";
                }
                else {
                    newUgovor.usvojen = "Ne";
                }
                if (checkBoxUsvojen.Checked) {
                    newUgovor.datumUsvajanja = dateTimeDatumUsvajanja.Value;
                    newUgovor.brojSluzbenogVlasnika = textBoxBrojSluzbenogVlasnika.Text;
                }
                else {
                    newUgovor.datumUsvajanja = new DateTime(1970, 1, 1);
                    newUgovor.brojSluzbenogVlasnika = "";
                }
                newUgovor.vremeRada = textBoxVremeRada.Text;
                newUgovor.vremeUgovora = DateTime.Now;
                newUgovor.uGuid = oldUgovor.uGuid;
                newUgovor.saveToDatabase();
                ChangeLog.addChangeLogForUgovor(oldUgovor, newUgovor);
            }
            catch (FormatException) {
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
                if (comboBoxRokPoUgovoru.Text.Equals("Godine")) {
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
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
        private void checkBoxUsvojen_CheckedChanged(object sender, EventArgs e) {
            manageCheckBoxBehavior();
        }
        private void manageCheckBoxBehavior() {
            if (checkBoxUsvojen.Checked) {
                labelDatumUsvajanja.Enabled = true;
                dateTimeDatumUsvajanja.Enabled = true;
                labelBrojSluzbenogVlasnika.Enabled = true;
                textBoxBrojSluzbenogVlasnika.Enabled = true;
            }
            else {
                labelDatumUsvajanja.Enabled = false;
                dateTimeDatumUsvajanja.Enabled = false;
                labelBrojSluzbenogVlasnika.Enabled = false;
                textBoxBrojSluzbenogVlasnika.Enabled = false;
            }
        }
    }
}