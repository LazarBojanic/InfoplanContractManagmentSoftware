using CSharp_SQL_App.forms;
using CSharp_SQL_App.model;
using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using TextBox = System.Windows.Forms.TextBox;
using MenuItem = System.Windows.Forms.MenuItem;
using Point = System.Drawing.Point;

namespace CSharp_SQL_App {
    public partial class UgovoriForm : Form {
        public Ugovor ugovor { get; set; }
        private static int cellIndex;
        public UgovoriForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewUgovori, new object[] { true });
            dateTimeDatumUgovora.Value = DateTime.Today;
            dateTimeKrajnjiRok.Value = DateTime.Today;
            dateTimeDatumUsvajanja.Value = DateTime.Today;
            if (!MainForm.user.privilegija.Equals("administrator")) {
                buttonObrisi.Enabled = false;
            }
            if (MainForm.user.privilegija.Equals("turista")) {
                buttonDodaj.Enabled = false;
                buttonIzmeni.Enabled = false;
                buttonExport.Enabled = false;
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
            if (dataGridViewUgovori.RowCount != 0) {
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
            try {
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                DataTable dt;
                String query = "SELECT id, opstina, nazivPlana, urbanista, tipUgovora, faza, napomena," +
                    " datumUgovora, rokPoUgovoru, krajnjiRok, obim, prioritet, cena, usvojen, datumUsvajanja," +
                    " brojSluzbenogVlasnika, vremeRada, uGuid FROM ugovor ORDER BY id";
                connection = Util.GetConnection();
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
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
        private void buttonIstorijaPromena_Click(object sender, EventArgs e) {
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
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
            try {
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                DataTable dt;
                connection = Util.GetConnection();
                String query = "SELECT id, opstina, nazivPlana, urbanista, tipUgovora, faza, napomena," +
                    " datumUgovora, rokPoUgovoru, krajnjiRok, obim, prioritet, cena, usvojen, datumUsvajanja," +
                    " brojSluzbenogVlasnika, vremeRada, uGuid FROM ugovor WHERE id IS NOT NULL";
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
                if (!string.IsNullOrEmpty(dateTimeDatumUsvajanja.Text) && checkBoxDatumUsvajanjaIncludeInSearch.Checked) {
                    if (radioButtonDatumUsvajanjaLesser.Checked) {
                        query += " AND datumUsvajanja < @datumUsvajanja";
                    }
                    if (radioButtonDatumUsvajanjaGreater.Checked) {
                        query += " AND datumUsvajanja > @datumUsvajanja";
                    }
                    if (radioButtonDatumUsvajanjaEqual.Checked) {
                        query += " AND datumUsvajanja = @datumUsvajanja";
                    }
                    if (radioButtonDatumUsvajanjaLessOrEqual.Checked) {
                        query += " AND datumUsvajanja <= @datumUsvajanja";
                    }
                    if (radioButtonDatumUsvajanjaGreaterOrEqual.Checked) {
                        query += " AND datumUsvajanja >= @datumUsvajanja";
                    }
                }
                if (!string.IsNullOrEmpty(textBoxBrojSluzbenogVlasnika.Text)) {
                    query += " AND UCASE(brojSluzbenogVlasnika) LIKE '%' + @brojSluzbenogVlasnika + '%'";
                }
                if (!string.IsNullOrEmpty(textBoxVremeRada.Text)) {
                    query += " AND UCASE(vremeRada) LIKE '%' + @vremeRada + '%'";
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
                if (!string.IsNullOrEmpty(dateTimeKrajnjiRok.Text) && checkBoxKrajnjiRokIncludeInSearch.Checked) {
                    command.Parameters.Add("@krajnjiRok", OleDbType.Date).Value = dateTimeKrajnjiRok.Value.Date;
                }
                if (!string.IsNullOrEmpty(textBoxObim.Text)) {
                    command.Parameters.AddWithValue("@obim", textBoxObim.Text);
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
                if (!string.IsNullOrEmpty(dateTimeDatumUsvajanja.Text) && checkBoxDatumUsvajanjaIncludeInSearch.Checked) {
                    command.Parameters.Add("@datumUsvajanja", OleDbType.Date).Value = dateTimeDatumUsvajanja.Value.Date;
                }
                if (!string.IsNullOrEmpty(textBoxBrojSluzbenogVlasnika.Text)) {
                    command.Parameters.AddWithValue("@brojSluzbenogVlasnika", textBoxBrojSluzbenogVlasnika.Text);
                }
                if (!string.IsNullOrEmpty(textBoxVremeRada.Text)) {
                    command.Parameters.AddWithValue("@vremeRada", textBoxVremeRada.Text);
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e) {
            try {
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
                        connection = Util.GetConnection();
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
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void textBoxRokPoUgovoru_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void buttonUgovorFiles_Click(object sender, EventArgs e) {
            if (dataGridViewUgovori.SelectedRows.Count > 0) {
                String uGuid = dataGridViewUgovori.SelectedRows[0].Cells["uGuid"].Value.ToString();
                UgovorFilesForm ugovorFilesForm = new UgovorFilesForm(uGuid);
                ugovorFilesForm.ShowDialog();
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
        private void buttonExport_Click(object sender, EventArgs e) {
            _Application excelApp = null;
            try {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                _Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                _Worksheet currentWorksheet = (_Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.AutoFit();
                if (dataGridViewUgovori.Rows.Count > 0) {
                    currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                    foreach (DataGridViewColumn dataGridViewColumn in dataGridViewUgovori.Columns) {
                        currentWorksheet.Cells[2, i] = dataGridViewColumn.Name;
                        ++i;
                    }
                    Range headerColumnRange = currentWorksheet.get_Range("A2", "R5");
                    headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dataGridViewUgovori.Rows.Count; rowIndex++) {
                        DataGridViewRow dataGridViewRow = dataGridViewUgovori.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dataGridViewRow.Cells.Count; cellIndex++) {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dataGridViewRow.Cells[cellIndex].Value;
                        }
                    }
                    Range fullTextRange = currentWorksheet.get_Range("A1", "R" + (rowIndex + 1).ToString());
                    fullTextRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                }
                else {
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "Nema grešaka";
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export tabele";
                saveFileDialog.Filter = "Excel 97-2003 Workbook(.xls)|*.xls|Excel Workbook(.xlsx)|*.xlsx|CSV(.csv)|*.csv";
                if (DialogResult.OK == saveFileDialog.ShowDialog()) {
                    string fullFileName = saveFileDialog.FileName;
                    // currentWorkbook.SaveCopyAs(fullFileName);
                    // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                    // the save file dialogue box
                    if (saveFileDialog.FilterIndex == 1) {
                        currentWorkbook.SaveAs(fullFileName, XlFileFormat.xlExcel8, Missing.Value, Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Uspešno export-ovan fajl.", "Uspešan Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (saveFileDialog.FilterIndex == 2) {
                        currentWorkbook.SaveAs(fullFileName, XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Uspešno export-ovan fajl.", "Uspešan Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (saveFileDialog.FilterIndex == 3) {
                        currentWorkbook.SaveAs(fullFileName, XlFileFormat.xlCSV, Missing.Value, Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Uspešno export-ovan fajl.", "Uspešan Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (excelApp != null) {
                    excelApp.Quit();
                }
            }
        }
        private void kopirajPoljeToolStripMenuItem_Click(object sender, EventArgs e) {
            Ugovor ugovor = Util.getUgovorFromSelectedRow(dataGridViewUgovori);
            String value = Util.getUgovorCellValue(ugovor, cellIndex);
            if (this.dataGridViewUgovori.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(value);
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void kopirajRedToolStripMenuItem_Click(object sender, EventArgs e) {
            Ugovor ugovor = Util.getUgovorFromSelectedRow(dataGridViewUgovori);
            if (this.dataGridViewUgovori.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(Util.buildClipboardUgovorString(ugovor));
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void dataGridViewUgovori_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
            cellIndex = e.ColumnIndex;
        }
    }
}