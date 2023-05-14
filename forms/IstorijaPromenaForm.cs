using InfoplanContractManagmentSoftware.model;
using InfoplanContractManagmentSoftware.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace InfoplanContractManagmentSoftware {
    public partial class IstorijaPromenaForm : Form {
        private string uGuid { get; set; }
        private static int cellIndex;
        public IstorijaPromenaForm(String uGuid) {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewChangeLog, new object[] { true });
            this.uGuid = uGuid;
            fillChangeLogGrid();
        }
        public void fillChangeLogGrid() {
            try {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                string query = "SELECT * FROM changeLog WHERE primarniKljuc = @uGuid";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@uGuid", uGuid);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewChangeLog.DataSource = bs;
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void IstorijaPromenaForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void IstorijaPromenaForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void IstorijaPromenaForm_Click(object sender, EventArgs e) {
            dataGridViewChangeLog.ClearSelection();
        }
        private void kopirajPoljeToolStripMenuItem_Click(object sender, EventArgs e) {
            ChangeLog changeLog = Util.getChangeLogFromSelectedRow(dataGridViewChangeLog);
            string value = Util.getChangeLogCellValue(changeLog, cellIndex);
            if (this.dataGridViewChangeLog.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(value);
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void kopirajRedToolStripMenuItem_Click(object sender, EventArgs e) {
            ChangeLog changeLog = Util.getChangeLogFromSelectedRow(dataGridViewChangeLog);
            if (this.dataGridViewChangeLog.GetCellCount(DataGridViewElementStates.Selected) > 0) {
                try {
                    Clipboard.SetText(Util.buildClipboardChangeLogString(changeLog));
                }
                catch (System.Runtime.InteropServices.ExternalException) {
                    MessageBox.Show("Neuspešno kopiranje u clipboard.");
                }
            }
        }
        private void dataGridViewChangeLog_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
            cellIndex = e.ColumnIndex;
        }
    }
}