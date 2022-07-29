using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL_App.model {
    internal class ChangeLog {

        public void addChangeLogField(String tableName, String fieldName, String eventType,
            String primaryKey, String oldValue, String newValue) {

            OleDbConnection myConnection = GetConnection();
            myConnection.Open();
            DateTime eventTime = DateTime.Now;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string query = "INSERT INTO changeLog (tableName, fieldName, eventType," +
                " eventTime, userName, primaryKey, oldValue, newValue VALUES" +
                " (@tableName, @fieldName, @eventType, @eventTime, @userName," +
                " @primaryKey, @oldValue, @newValue)";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@tableName", tableName);
            command.Parameters.AddWithValue("@fieldName", fieldName);
            command.Parameters.AddWithValue("@eventType", eventType);
            command.Parameters.AddWithValue("@eventTime", eventTime);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@primaryKey", primaryKey);
            command.Parameters.AddWithValue("@oldValue", oldValue);
            command.Parameters.AddWithValue("@newValue", newValue);
            command.ExecuteNonQuery();
        }

        public void addChangeLogForUgovor(Ugovor oldUgovor, Ugovor newUgovor) {
            if(oldUgovor.id == 0) {

            }
        }

        private OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
    }
}
