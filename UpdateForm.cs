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
        //private ugovoriDataSet ugovoriDataSet;
        public UpdateForm() {
            InitializeComponent();
            
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
            string query = "SELECT opstina FROM opstina";
            OleDbCommand command = new OleDbCommand(query, connection);
            DataTable table = new DataTable ("opstina");
            table.Load(command.ExecuteReader());

            foreach (DataRow row in table.Rows) {
                comboBoxOpstina.Items.Add(row["opstina"].ToString());
                //MessageBox.Show(row["opstina"].ToString());
            }
            
        }

        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }

        private void UpdateForm_Load(object sender, EventArgs e) {
            loadOpstinaComboBox();
            textBoxId.Text = oldUgovor.id.ToString();
            textBoxUGuid.Text = oldUgovor.uGuid;
            comboBoxOpstina.Text = oldUgovor.opstina.ToString();
            textBoxNazivPlana.Text = oldUgovor.nazivPlana;
            textBoxUrbanista.Text = oldUgovor.urbanista;
            textBoxFaza.Text = oldUgovor.faza;
            textBoxNapomena.Text = oldUgovor.napomena;
            dateTimeDatumUgovora.Value = oldUgovor.datumUgovora;
            textBoxRokPoUgovoru.Text = oldUgovor.rokPoUgovoru;
            comboBoxRokPoUgovoru.Text = "Mesec";
            textBoxObim.Text = oldUgovor.obim.ToString();
            dateTimeKrajnjiRok.Value = oldUgovor.krajnjiRok;
            textBoxPrioritet.Text = oldUgovor.prioritet.ToString();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e) {         
            try {
                newUgovor.id = oldUgovor.id;
                newUgovor.opstina = comboBoxOpstina.Text;
                newUgovor.nazivPlana = textBoxNazivPlana.Text;
                newUgovor.urbanista = textBoxUrbanista.Text;
                newUgovor.faza = textBoxFaza.Text;
                newUgovor.napomena = textBoxNapomena.Text;
                newUgovor.datumUgovora = dateTimeDatumUgovora.Value;
                newUgovor.rokPoUgovoru = textBoxRokPoUgovoru.Text;
                newUgovor.obim = Int32.Parse(textBoxObim.Text);
                newUgovor.krajnjiRok = dateTimeKrajnjiRok.Value;
                newUgovor.prioritet = Int32.Parse(textBoxPrioritet.Text);
                newUgovor.uGuid = oldUgovor.uGuid;
                newUgovor.saveToDatabase();
                ChangeLog.addChangeLogForUgovor(oldUgovor, newUgovor);
                this.DialogResult = DialogResult.OK;
            }
            catch(FormatException ex) {
                MessageBox.Show("Nekorektan format podataka.");                
            }
        }

        private void buttonOtkazi_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBoxObim_TextChanged(object sender, EventArgs e) {

        }

        private void textBoxRokPoUgovoru_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void textBoxRokPoUgovoru_TextChanged(object sender, EventArgs e) {
            dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value;
            if (!textBoxRokPoUgovoru.Text.Equals("")) {
                if (comboBoxRokPoUgovoru.Text.Equals("Sat")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddHours(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Dan")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Nedelja")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text) * 7);
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Mesec")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddMonths(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if(comboBoxRokPoUgovoru.Text.Equals("Godina")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddYears(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
            }
        }

        private void comboBoxRokPoUgovoru_SelectedValueChanged(object sender, EventArgs e) {
            dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value;
            if (!textBoxRokPoUgovoru.Text.Equals("")) {
                if (comboBoxRokPoUgovoru.Text.Equals("Sat")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddHours(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Dan")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Nedelja")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddDays(Int32.Parse(textBoxRokPoUgovoru.Text) * 7);
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Mesec")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddMonths(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
                if (comboBoxRokPoUgovoru.Text.Equals("Godina")) {
                    dateTimeKrajnjiRok.Value = dateTimeDatumUgovora.Value.AddYears(Int32.Parse(textBoxRokPoUgovoru.Text));
                }
            }
        }
    }
}
