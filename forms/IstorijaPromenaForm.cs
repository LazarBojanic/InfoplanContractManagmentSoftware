using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class IstorijaPromenaForm : Form {
        private String uGuid { get; set; }
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
                String query = "SELECT * FROM changeLog WHERE primarniKljuc = @uGuid";
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
    }
}