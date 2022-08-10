using CSharp_SQL_App.model;
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

namespace CSharp_SQL_App {
    public partial class IstorijaPromenaForm : Form {
        private String uGuid { get;set;}
        public IstorijaPromenaForm(String uGuid) {         
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGridViewChangeLog, new object[] { true });
            this.uGuid = uGuid;
            fillChangeLogGrid();
        }
        private void IstorijaPromenaForm_Load(object sender, EventArgs e) {
            
        }

        public void fillChangeLogGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection connection;
            OleDbCommand command;
            connection = GetConnection();
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
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }

        private void IstorijaPromenaForm_ResizeBegin(object sender, EventArgs e) {
            this.SuspendLayout();
        }

        private void IstorijaPromenaForm_ResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true);
        }

        private void buttonNazad_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
