using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App.model {
    public class ChangeLog {

        public static void addChangeLogField(String tableName, String fieldName, String eventType,
            String primaryKey, String oldValue, String newValue) {

            OleDbConnection myConnection = GetConnection();
            myConnection.Open();
            DateTime eventTime = DateTime.Now;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string query = "INSERT INTO changeLog (tableName, fieldName, eventType," +
                " eventTime, userName, primaryKey, oldValue, newValue) VALUES" +
                " (@tableName, @fieldName, @eventType, @eventTime, @userName," +
                " @primaryKey, @oldValue, @newValue)";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@tableName", tableName);
            command.Parameters.AddWithValue("@fieldName", fieldName);
            command.Parameters.AddWithValue("@eventType", eventType);
            command.Parameters.Add("@eventTime", OleDbType.DBDate).Value = eventTime;
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@primaryKey", primaryKey);
            command.Parameters.AddWithValue("@oldValue", oldValue);
            command.Parameters.AddWithValue("@newValue", newValue);
            //MessageBox.Show(tableName + " " + fieldName + " " + eventType + " " + eventTime.ToString() + " " + userName + " " + primaryKey + " " + oldValue + " " + newValue);
            command.ExecuteNonQuery();
        }

        public static void addChangeLogForUgovor(Ugovor oldUgovor, Ugovor newUgovor) {
            //MessageBox.Show("old id " + oldUgovor.id.ToString() + " new id " + newUgovor.id.ToString());
            if(oldUgovor.id == 0) {

            }
            else {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "promena", oldUgovor.id.ToString(), oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "promena", oldUgovor.id.ToString(), oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "promena", oldUgovor.id.ToString(), oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "promena", oldUgovor.id.ToString(), oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "promena", oldUgovor.id.ToString(), oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "promena", oldUgovor.id.ToString(), oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "promena", oldUgovor.id.ToString(), oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "promena", oldUgovor.id.ToString(), oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "promena", oldUgovor.id.ToString(), oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "promena", oldUgovor.id.ToString(), oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
            }
        }

        private static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
    }
}
