using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class UgovoriForm : Form {
        public Ugovor ugovor { get; set; }
        public UgovoriForm() {
            InitializeComponent();
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonObrisi.Enabled = false;
            }
        }
        private void UgovoriForm_Load(object sender, EventArgs e) {
            refreshDataGrid();
        }
        private void buttonDodaj_Click(object sender, EventArgs e) {
            UpdateForm updateForm1 = new UpdateForm();
            updateForm1.loadUgovor(0);
            if (updateForm1.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            dataGridViewUgovori.FirstDisplayedScrollingRowIndex = dataGridViewUgovori.RowCount - 1;
            dataGridViewUgovori.Rows[dataGridViewUgovori.RowCount - 1].Selected = true;
        }
        private void buttonIzmeni_Click(object sender, EventArgs e) {
            UpdateForm updateForm2 = new UpdateForm();
            int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells[0].Value.ToString());
            int index = dataGridViewUgovori.CurrentRow.Index;
            updateForm2.loadUgovor(id);
            if (updateForm2.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            dataGridViewUgovori.FirstDisplayedScrollingRowIndex = index;
            dataGridViewUgovori.Rows[index].Selected = true;
        }
        private void buttonRefresh_Click(object sender, EventArgs e) {
            refreshDataGrid();
        }
        public void refreshDataGrid() {
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            DataTable dt;
            String query = "SELECT * FROM ugovor ORDER BY id";
            connection = GetConnection();
            connection.Open();
            command = new OleDbCommand(query, connection);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewUgovori.DataSource = bs;
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        private void buttonIstorijaPromena_Click(object sender, EventArgs e) {
            String uGuid = dataGridViewUgovori.SelectedRows[0].Cells["uGuid"].Value.ToString();
            IstorijaPromenaForm i = new IstorijaPromenaForm(uGuid);
            i.ShowDialog();
        }
        private void UgovoriForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void UgovoriForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
        private void buttonPretraga_Click(object sender, EventArgs e) {
            IEnumerable<Control> controls = this.Controls.OfType<Control>();
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            DataTable dt;
            connection = GetConnection();
            String query = "SELECT * FROM ugovor WHERE id IS NOT NULL";
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
            if (!string.IsNullOrEmpty(dateTimeDatumUgovora.Text) && checkBoxDatumUgovora.Checked) {
                if (radioButtonDatumUgovoraLesser.Checked) {
                    query += " AND datumUgovora < @datumUgovora";
                }
                if (radioButtonDatumUgovoraGreater.Checked) {
                    query += " AND datumUgovora > @datumUgovora";
                }
                if (radioButtonDatumUgovoraEqual.Checked) {
                    query += " AND datumUgovora = @datumUgovora";
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
            }
            if (!string.IsNullOrEmpty(dateTimeKrajnjiRok.Text) && checkBoxKrajnjiRok.Checked) {
                if (radioButtonKrajnjiRokLesser.Checked) {
                    query += " AND krajnjiRok < @krajnjiRok";
                }
                if (radioButtonKrajnjiRokGreater.Checked) {
                    query += " AND krajnjiRok > @krajnjiRok";
                }
                if (radioButtonKrajnjiRokEqual.Checked) {
                    query += " AND krajnjiRok = @krajnjiRok";
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
            if (!string.IsNullOrEmpty(dateTimeDatumUgovora.Text) && checkBoxDatumUgovora.Checked) {
                command.Parameters.Add("@datumUgovora", OleDbType.Date).Value = dateTimeDatumUgovora.Value.Date;
            }
            if (!string.IsNullOrEmpty(textBoxRokPoUgovoru.Text)) {
                command.Parameters.AddWithValue("@rokPoUgovoru", textBoxRokPoUgovoru.Text);
            }
            if (!string.IsNullOrEmpty(textBoxObim.Text)) {
                command.Parameters.AddWithValue("@obim", textBoxObim.Text);
            }
            if (!string.IsNullOrEmpty(dateTimeKrajnjiRok.Text) && checkBoxDatumUgovora.Checked) {
                command.Parameters.Add("@krajnjiRok", OleDbType.Date).Value = dateTimeKrajnjiRok.Value.Date;
            }
            if (!string.IsNullOrEmpty(textBoxPrioritet.Text)) {
                command.Parameters.AddWithValue("@prioritet", textBoxPrioritet.Text);
            }
            if (!string.IsNullOrEmpty(textBoxUGuid.Text)) {
                command.Parameters.AddWithValue("@uGuid", textBoxUGuid.Text.ToUpper());
            }
            dt = new DataTable();
            bs = new BindingSource();
            connection.Open();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridViewUgovori.DataSource = bs;
            this.Text = query;
            connection.Close();
        }
        public DateTime dateTimeWithoutMiliseconds(DateTime dateTime) {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            UpdateForm updateForm2 = new UpdateForm();
            int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells[0].Value.ToString());
            int index = dataGridViewUgovori.CurrentRow.Index;
            updateForm2.loadUgovor(id);
            if (updateForm2.ShowDialog().Equals(DialogResult.OK)) {
                refreshDataGrid();
            }
            dataGridViewUgovori.FirstDisplayedScrollingRowIndex = index;
            dataGridViewUgovori.Rows[index].Selected = true;
        }

        private void buttonObrisi_Click(object sender, EventArgs e) {
            int id = int.Parse(dataGridViewUgovori.SelectedRows[0].Cells[0].Value.ToString());
            OleDbConnection connection;
            OleDbCommand command;
            String query = "DELETE FROM ugovor WHERE id = @id";
            connection = GetConnection();
            connection.Open();
            command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            refreshDataGrid();
            connection.Close();
        }
    }
}
