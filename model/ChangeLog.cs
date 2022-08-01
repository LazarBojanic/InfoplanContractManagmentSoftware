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
            command.Parameters.Add("@eventTime", OleDbType.DBTimeStamp).Value = eventTimeWithoutMilliseconds(eventTime);
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
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "kreairanje", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "kreairanje", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "kreairanje", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "kreairanje", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "kreairanje", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "kreairanje", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "kreairanje", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "kreairanje", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "kreairanje", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "kreairanje", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
            }
            else {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "promena", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "promena", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "promena", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "promena", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "promena", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "promena", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "promena", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "promena", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "promena", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "promena", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
            }
        }

        private static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }
        public static DateTime eventTimeWithoutMilliseconds(DateTime eventTime) {
            return new DateTime(eventTime.Year, eventTime.Month, eventTime.Day, eventTime.Hour, eventTime.Minute, eventTime.Second);
        }
    }
}
