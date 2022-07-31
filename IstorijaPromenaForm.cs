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
    public partial class IstorijaPromenaForm : Form {
        private int id { get;set;}
        
        public IstorijaPromenaForm(int id) {
            InitializeComponent();
            this.id = id;
            fillChangeLogGrid();
        }
        private void IstorijaPromenaForm_Load(object sender, EventArgs e) {
            
        }

        public void fillChangeLogGrid() {
            DataTable dt;
            BindingSource bs;
            OleDbConnection myConnection;
            OleDbCommand command;
            myConnection = GetConnection();
            myConnection.Open();
            String query = "SELECT * FROM changeLog WHERE primaryKey = @id";
            command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@id", id);
            dt = new DataTable();
            bs = new BindingSource();
            dt.Load(command.ExecuteReader());
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
    }
}
