using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App.model {
    public class ChangeLog {
        public static void addChangeLogField(String imeTabele, String imePolja, String tipAkcije,
            String primarniKljuc, String staraVrednost, String novaVrednost) {
            OleDbConnection connection = GetConnection();
            connection.Open();
            DateTime vremeAkcije = DateTime.Now;
            string username = MainForm.user.username;
            string query = "INSERT INTO changeLog (imeTabele, imePolja, tipAkcije," +
                " vremeAkcije, username, primarniKljuc, staraVrednost, novaVrednost) VALUES" +
                " (@imeTabele, @imePolja, @tipAkcije, @vremeAkcije, @username," +
                " @primarniKljuc, @staraVrednost, @novaVrednost)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@imeTabele", imeTabele);
            command.Parameters.AddWithValue("@imePolja", imePolja);
            command.Parameters.AddWithValue("@tipAkcije", tipAkcije);
            command.Parameters.Add("@vremeAkcije", OleDbType.DBTimeStamp).Value = vremeAkcijeWithoutMilliseconds(vremeAkcije);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@primarniKljuc", primarniKljuc);
            command.Parameters.AddWithValue("@staraVrednost", staraVrednost);
            command.Parameters.AddWithValue("@novaVrednost", novaVrednost);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void addChangeLogForUgovor(Ugovor oldUgovor, Ugovor newUgovor) {
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
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "kreairanje", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
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
            else if(newUgovor.id == 0) {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "brisanje", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "brisanje", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "brisanje", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "brisanje", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "brisanje", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "brisanje", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "brisanje", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "brisanje", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "brisanje", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "brisanje", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "brisanje", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
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
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "promena", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
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
        public static DateTime vremeAkcijeWithoutMilliseconds(DateTime vremeAkcije) {
            return new DateTime(vremeAkcije.Year, vremeAkcije.Month, vremeAkcije.Day, vremeAkcije.Hour, vremeAkcije.Minute, vremeAkcije.Second);
        }
    }
}
