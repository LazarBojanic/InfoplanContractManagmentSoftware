using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL_App.app {
    internal class AppCore {
        public static DataSet executeQuery(String parametar) {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT * FROM opstina WHERE id = ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            DataSet resultSet = new DataSet();
            OleDbDataAdapter dataReader = new OleDbDataAdapter(command);
            dataReader.Fill(resultSet);
            myConnection.Close();
            return resultSet;
        }

        public static DataSet executeQuery(int id) {
            OleDbConnection myConnection = GetConnection();
            string query = "SELECT * FROM opstina";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Connection = myConnection;
            DataSet resultSet = new DataSet();
            OleDbDataAdapter dataReader = new OleDbDataAdapter(command);
            dataReader.Fill(resultSet);
            myConnection.Close();
            return resultSet;
        }

        private static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
    }
}
