using CSharp_SQL_App.util;
using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace CSharp_SQL_App.forms {
    public partial class IstorijaPromenaObrisanihUgovoraForm : Form {
        public IstorijaPromenaObrisanihUgovoraForm() {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewChangeLogObrisanihUgovora, new object[] { true });
            fillChangeLogObrisanihUgovoraGrid();
        }
        public void fillChangeLogObrisanihUgovoraGrid() {
            try {
                DataTable dt;
                BindingSource bs;
                OleDbConnection connection;
                OleDbCommand command;
                connection = Util.GetConnection();
                connection.Open();
                String query = "SELECT * FROM changeLog WHERE tipAkcije = 'brisanje'";
                command = new OleDbCommand(query, connection);
                dt = new DataTable();
                bs = new BindingSource();
                dt.Load(command.ExecuteReader());
                bs.DataSource = dt;
                dataGridViewChangeLogObrisanihUgovora.DataSource = bs;
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void IstorijaPromenaObrisanihUgovoraForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }
        private void IstorijaPromenaObrisanihUgovoraForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }
        private void buttonZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void IstorijaPromenaObrisanihUgovoraForm_Click(object sender, EventArgs e) {
            dataGridViewChangeLogObrisanihUgovora.ClearSelection();
        }
    }
}