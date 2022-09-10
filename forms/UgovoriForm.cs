using CSharp_SQL_App.forms;
using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class UgovoriForm : Form {
        public Ugovor ugovor { get; set; }
        public UgovoriForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewUgovori, new object[] { true });
            dateTimeDatumUgovora.Value = DateTime.Today;
            dateTimeKrajnjiRok.Value = DateTime.Today;
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonObrisi.Enabled = false;
            }
            if (MainForm.user.privilegija.Equals("turista")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
            }
            this.AcceptButton = buttonPretraga;
        }
        private void UgovoriForm_Load(object sender, EventArgs e) {
            refreshDataGrid();
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            UpdateForm updateForm = new UpdateForm("load");
            updateForm.loadUgovor(0);
            if (updateForm.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            if(dataGridViewUgovori.RowCount != 0) {
                dataGridViewUgovori.FirstDisplayedScrollingRowIndex = dataGridViewUgovori.RowCount - 1;
                dataGridViewUgovori.Rows[dataGridViewUgovori.RowCount - 1].Selected = true;
            }
        }
        private void buttonIzmeni_Click(object sender, EventArgs e) {
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
                int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells["id"].Value.ToString());
                int index = dataGridViewUgovori.CurrentRow.Index;
                UpdateForm updateForm = new UpdateForm("update");
                updateForm.loadUgovor(id);
                if (updateForm.ShowDialog().Equals(DialogResult.OK)) {
                    refreshDataGrid();
                }
                dataGridViewUgovori.FirstDisplayedScrollingRowIndex = index;
                dataGridViewUgovori.Rows[index].Selected = true;
            }          
        }
        private void buttonRefresh_Click(object sender, EventArgs e) {
            refreshDataGrid();
        }
        public void refreshDataGrid() {
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            DataTable dt;
            String query = "SELECT id, opstina, nazivPlana, urbanista, tipUgovora, faza, napomena," +
                " datumUgovora, rokPoUgovoru, obim, krajnjiRok, prioritet, cena, usvojen, uGuid FROM ugovor ORDER BY id";
            connection = GetConnection();
            connection.Open();
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewUgovori.DataSource = bs;
            connection.Close();
            colorUgovori();
        }
        private void colorUgovori() {
            foreach (DataGridViewRow row in dataGridViewUgovori.Rows) {
                if (row.Cells["usvojen"].Value.ToString().Equals("Da")) {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(0, 255, 0);
                }
                else {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        private void buttonIstorijaPromena_Click(object sender, EventArgs e) {
            if(dataGridViewUgovori.SelectedRows.Count > 0) {
                String uGuid = dataGridViewUgovori.SelectedRows[0].Cells["uGuid"].Value.ToString();
                IstorijaPromenaForm i = new IstorijaPromenaForm(uGuid);
                i.ShowDialog();
            }
        }
        private void UgovoriForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void UgovoriForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout();
        }
        private void buttonPretraga_Click(object sender, EventArgs e) {
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            DataTable dt;
            connection = GetConnection();
            String query = "SELECT id, opstina, nazivPlana, urbanista, tipUgovora, faza, napomena," +
                " datumUgovora, rokPoUgovoru, obim, krajnjiRok, prioritet, cena, usvojen, uGuid FROM ugovor WHERE id IS NOT NULL";
            if (!string.IsNullOrEmpty(textBoxId.Text)) {
                if (radioButtonIdLesser.Checked) {
                    query += " AND id < @id";
                }
                if (radioButtonIdGreater.Checked) {
                    query += " AND id > @id";
                }
                if (radioButtonIdEqual.Checked) {
                    query += " AND id = @id";
                }
                if (radioButtonIdLessOrEqual.Checked) {
                    query += " AND id <= @id";
                }
                if (radioButtonIdGreaterOrEqual.Checked) {
                    query += " AND id >= @id";
                }
            }
            if (!string.IsNullOrEmpty(textBoxOpstina.Text)) {
                query += " AND UCASE(opstina) LIKE '%' + @opstina + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxNazivPlana.Text)) {
                query += " AND UCASE(nazivPlana) LIKE '%' + @nazivPlana + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxUrbanista.Text)) {
                query += " AND UCASE(urbanista) LIKE '%' + @urbanista + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxTipUgovora.Text)) {
                query += " AND UCASE(tipUgovora) LIKE '%' + @tipUgovora + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxFaza.Text)) {
                query += " AND UCASE(faza) LIKE '%' + @faza + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxNapomena.Text)) {
                query += " AND UCASE(napomena) LIKE '%' + @napomena + '%'";
            }
            if (!string.IsNullOrEmpty(dateTimeDatumUgovora.Text) && checkBoxDatumUgovoraIncludeInSearch.Checked) {
                if (radioButtonDatumUgovoraLesser.Checked) {
                    query += " AND datumUgovora < @datumUgovora";
                }
                if (radioButtonDatumUgovoraGreater.Checked) {
                    query += " AND datumUgovora > @datumUgovora";
                }
                if (radioButtonDatumUgovoraEqual.Checked) {
                    query += " AND datumUgovora = @datumUgovora";
                }
                if (radioButtonDatumUgovoraLessOrEqual.Checked) {
                    query += " AND datumUgovora <= @datumUgovora";
                }
                if (radioButtonDatumUgovoraGreaterOrEqual.Checked) {
                    query += " AND datumUgovora >= @datumUgovora";
                }
            }
            if (!string.IsNullOrEmpty(textBoxRokPoUgovoru.Text)) {
                query += " AND UCASE(rokPoUgovoru) LIKE '%' + @rokPoUgovoru + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxObim.Text)) {
                if (radioButtonObimLesser.Checked) {
                    query += " AND obim < @obim";
                }
                if (radioButtonObimGreater.Checked) {
                    query += " AND obim > @obim";
                }
                if (radioButtonObimEqual.Checked) {
                    query += " AND obim = @obim";
                }
                if (radioButtonObimLessOrEqual.Checked) {
                    query += " AND obim <= @obim";
                }
                if (radioButtonObimGreaterOrEqual.Checked) {
                    query += " AND obim >= @obim";
                }
            }
            if (!string.IsNullOrEmpty(dateTimeKrajnjiRok.Text) && checkBoxKrajnjiRokIncludeInSearch.Checked) {
                if (radioButtonKrajnjiRokLesser.Checked) {
                    query += " AND krajnjiRok < @krajnjiRok";
                }
                if (radioButtonKrajnjiRokGreater.Checked) {
                    query += " AND krajnjiRok > @krajnjiRok";
                }
                if (radioButtonKrajnjiRokEqual.Checked) {
                    query += " AND krajnjiRok = @krajnjiRok";
                }
                if (radioButtonKrajnjiRokLessOrEqual.Checked) {
                    query += " AND krajnjiRok <= @krajnjiRok";
                }
                if (radioButtonKrajnjiRokGreaterOrEqual.Checked) {
                    query += " AND krajnjiRok >= @krajnjiRok";
                }
            }
            if (!string.IsNullOrEmpty(textBoxPrioritet.Text)) {
                if (radioButtonPrioritetLesser.Checked) {
                    query += " AND prioritet < @prioritet";
                }
                if (radioButtonPrioritetGreater.Checked) {
                    query += " AND prioritet > @prioritet";
                }
                if (radioButtonPrioritetEqual.Checked) {
                    query += " AND prioritet = @prioritet";
                }
                if (radioButtonPrioritetLessOrEqual.Checked) {
                    query += " AND prioritet <= @prioritet";
                }
                if (radioButtonPrioritetGreaterOrEqual.Checked) {
                    query += " AND prioritet >= @prioritet";
                }
            }
            if (!string.IsNullOrEmpty(textBoxCena.Text)) {
                if (radioButtonCenaLesser.Checked) {
                    query += " AND cena < @cena";
                }
                if (radioButtonCenaGreater.Checked) {
                    query += " AND cena > @cena";
                }
                if (radioButtonCenaEqual.Checked) {
                    query += " AND cena = @cena";
                }
                if (radioButtonCenaLessOrEqual.Checked) {
                    query += " AND cena <= @cena";
                }
                if (radioButtonCenaGreaterOrEqual.Checked) {
                    query += " AND cena >= @cena";
                }
            }
            if (!string.IsNullOrEmpty(textBoxUsvojen.Text)) {
                query += " AND UCASE(usvojen) LIKE '%' + @usvojen + '%'";
            }
            if (!string.IsNullOrEmpty(textBoxUGuid.Text)) {
                query += " AND UCASE(uGuid) LIKE '%' + @uGuid + '%'";
            }


            command = new OleDbCommand(query, connection);
            if (!string.IsNullOrEmpty(textBoxId.Text)) {
                command.Parameters.AddWithValue("@id", textBoxId.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxOpstina.Text)) {
                command.Parameters.AddWithValue("@opstina", textBoxOpstina.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxNazivPlana.Text)) {
                command.Parameters.AddWithValue("@nazivPlana", textBoxNazivPlana.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxUrbanista.Text)) {
                command.Parameters.AddWithValue("@urbanista", textBoxUrbanista.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxTipUgovora.Text)) {
                command.Parameters.AddWithValue("@tipUgovora", textBoxTipUgovora.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxFaza.Text)) {
                command.Parameters.AddWithValue("@faza", textBoxFaza.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(textBoxNapomena.Text)) {
                command.Parameters.AddWithValue("@napomena", textBoxNapomena.Text.ToUpper());
            }
            if (!string.IsNullOrEmpty(dateTimeDatumUgovora.Text) && checkBoxDatumUgovoraIncludeInSearch.Checked) {
                command.Parameters.Add("@datumUgovora", OleDbType.Date).Value = dateTimeDatumUgovora.Value.Date;
            }
            if (!string.IsNullOrEmpty(textBoxRokPoUgovoru.Text)) {
                command.Parameters.AddWithValue("@rokPoUgovoru", textBoxRokPoUgovoru.Text);
            }
            if (!string.IsNullOrEmpty(textBoxObim.Text)) {
                command.Parameters.AddWithValue("@obim", textBoxObim.Text);
            }
            if (!string.IsNullOrEmpty(dateTimeKrajnjiRok.Text) && checkBoxKrajnjiRokIncludeInSearch.Checked) {
                command.Parameters.Add("@krajnjiRok", OleDbType.Date).Value = dateTimeKrajnjiRok.Value.Date;
            }
            if (!string.IsNullOrEmpty(textBoxPrioritet.Text)) {
                command.Parameters.AddWithValue("@prioritet", textBoxPrioritet.Text);
            }
            if (!string.IsNullOrEmpty(textBoxCena.Text)) {
                command.Parameters.AddWithValue("@cena", textBoxCena.Text);
            }
            if (!string.IsNullOrEmpty(textBoxUsvojen.Text)) {
                command.Parameters.AddWithValue("@usvojen", textBoxUsvojen.Text);
            }
            if (!string.IsNullOrEmpty(textBoxUGuid.Text)) {
                command.Parameters.AddWithValue("@uGuid", textBoxUGuid.Text.ToUpper());
            }
            dt = new DataTable();
            bs = new BindingSource();
            query += " ORDER BY id";
            connection.Open();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewUgovori.DataSource = bs;
            connection.Close();
            colorUgovori();
        }
        public DateTime dateTimeWithoutMiliseconds(DateTime dateTime) {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }

        private void buttonObrisi_Click(object sender, EventArgs e) {
            ConfirmationForm confirmationForm = new ConfirmationForm();
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
                if (confirmationForm.ShowDialog().Equals(DialogResult.Yes)) {
                    Ugovor oldUgovor = new Ugovor();
                    Ugovor newUgovor = new Ugovor();
                    int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells["id"].Value.ToString());
                    oldUgovor.loadFromDatabase(id);
                    OleDbConnection connection;
                    OleDbCommand command;
                    String query = "DELETE FROM ugovor WHERE id = @id";
                    connection = GetConnection();
                    connection.Open();
                    command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                    refreshDataGrid();
                    ChangeLog.addChangeLogForUgovor(oldUgovor, newUgovor);
                }
            }
        }
        private void buttonIstorijaPromenaObrisanihUgovora_Click(object sender, EventArgs e) {
            IstorijaPromenaObrisanihUgovoraForm i = new IstorijaPromenaObrisanihUgovoraForm();
            i.ShowDialog();
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
        private void textBoxObim_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
        private void textBoxRokPoUgovoru_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
        

        private void buttonUgovorFiles_Click(object sender, EventArgs e) {
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
                String uGuid = dataGridViewUgovori.SelectedRows[0].Cells["uGuid"].Value.ToString();
                UgovorFilesForm uFF = new UgovorFilesForm(uGuid);
                uFF.ShowDialog();
            }          
        }

        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UgovoriForm_Click(object sender, EventArgs e) {
            dataGridViewUgovori.ClearSelection();
        }

        private void dataGridViewUgovori_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
                int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells[0].Value.ToString());
                int index = dataGridViewUgovori.CurrentRow.Index;
                UpdateForm updateForm = new UpdateForm("update");
                updateForm.loadUgovor(id);
                if (updateForm.ShowDialog().Equals(DialogResult.OK)) {
                    refreshDataGrid();
                }
                dataGridViewUgovori.FirstDisplayedScrollingRowIndex = index;
                dataGridViewUgovori.Rows[index].Selected = true;
            }           
        }

        
    }
}
