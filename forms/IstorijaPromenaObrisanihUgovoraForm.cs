using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

        private void IstorijaPromenaObrisanihUgovoraForm_Load(object sender, EventArgs e) {

        }

        public void fillChangeLogObrisanihUgovoraGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
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
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
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
